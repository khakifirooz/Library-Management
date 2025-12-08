using FrameworkApplication;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Loans;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementContracts.Loan;
using LibraryManagementContracts.Member;

namespace LibraryManagementApplication
{
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<OperationResult> CreateAsync(MemberCreateModel command)
        {
            OperationResult result = new();
            try
            {
                if (await _unitOfWork.MemberRepository.ExistAsync(x => x.NationalCode == command.NationalCode))
                    return result.Failed(ApplicationMessages.DublicateRecord);

                var member = new Member(command.Name, command.Family, command.NationalCode,
                    command.Mobile, command.IsSpecial, command.Image);

                await _unitOfWork.MemberRepository.CreateAsync(member);
                await _unitOfWork.SaveChangesAsync(); 
                return result.Succeded();
            }
            catch (Exception e)
            {
                return result.Failed(e.Message);
            }
        }

        public async Task<List<MemberViewModel>> GetAllAsync()
        {
            var result = await _unitOfWork.MemberRepository.GetAllAsync();
            return result.Select(x => new MemberViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Family = x.Family,
                NationalCode = x.NationalCode,
                Mobile = x.Mobile,
                IsSpecial = x.IsSpecial,
                Status = x.Status,
                Image = x.Image
            }).ToList();
        }

        public async Task<MemberViewModel> GetByIdAsync(int id)
        {
            var result = await _unitOfWork.MemberRepository.GetByIdAsync(id);
            var member = new MemberViewModel()
            {
                Id = result.Id,
                Name = result.Name,
                Family = result.Family,
                NationalCode = result.NationalCode,
                Mobile = result.Mobile,
                IsSpecial = result.IsSpecial,
                Status = result.Status,
                Image = result.Image
            };
            return member;
        }

        public async Task<MemberViewModel> GetMemberWithLoanByIdAsync(int id)
        {
            var member = await _unitOfWork.MemberRepository.GetMemberWithLoanByIdAsync(id);
            if (member is null)
            {
                // new MemberViewModel();
                return null;
            }
                

            var memberViewModel = new MemberViewModel()
            {
                Id = member.Id,
                Name = member.Name,
                Family = member.Family,
                NationalCode = member.NationalCode,
                Mobile = member.Mobile,
                IsSpecial = member.IsSpecial,
                Status = member.Status,
                Image = member.Image,
                Loans = MapLoans(member.Loans),
            };
            return memberViewModel;
        }

        public static List<LoanViewModel> MapLoans(List<Loan> loans)
        {
            return loans
                .Where(loan => loan.Book.IsLoaned)
                .Select(loan => new LoanViewModel()
            {
                Id = loan.Id,
                MemberId = loan.MemberId,
                MemberName = $"{loan.Member.Name} {loan.Member.Family}",
                BookId = loan.BookId,
                BookName = loan.Book.Title,
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate,
                Status = loan.Status,
            }).ToList();
        }

        public async Task<List<MemberViewModel>> SearchAsync(int id, string? nationalCode)
        {
            var result = await _unitOfWork.MemberRepository.SearchAsync(id, nationalCode);
            return result.Select(x => new MemberViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Family = x.Family,
                NationalCode = x.NationalCode,
                Mobile = x.Mobile,
                IsSpecial = x.IsSpecial,
                Status = x.Status,
                Image = x.Image
            }).ToList();
        }

        public async Task<OperationResult> UpdateAsync(MemberUpdateModel command)
        {
            OperationResult result = new();
            try
            {
                var member = await _unitOfWork.MemberRepository.GetByIdAsync(command.Id);
                if (member is null)
                    return result.Failed(ApplicationMessages.RecordNotFound);

                if (await _unitOfWork.MemberRepository.ExistAsync(x => x.NationalCode == command.NationalCode && x.Id != command.Id))
                    return result.Failed(ApplicationMessages.DublicateRecord);

                member.Update(command.Name, command.Family, command.NationalCode,
                    command.Mobile, command.IsSpecial, command.Status, command.Image);

                _unitOfWork.MemberRepository.Update(member);
                await _unitOfWork.SaveChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {
                return result.Failed(e.Message);
            }
        }

        public async Task<OperationResult> AddLoanAsync(LoanCreateModel command)
        {
            OperationResult result = new();
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                var member = await _unitOfWork.MemberRepository.GetByIdAsync(command.MemberId);
                if (member is null)
                    result.Failed(ApplicationMessages.RecordNotFound);

                var loan = new Loan(command.MemberId, command.BookId, command.LoanDate, command.ReturnDate);
                member.addLoan(loan);

                var book = await _unitOfWork.BookRepository.GetByIdAsync(command.BookId);
                if (book is null)
                    result.Failed(ApplicationMessages.RecordNotFound);

                book.Loaned();
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
                return result.Succeded();

            }
            catch (Exception e)
            {
                await _unitOfWork.RollBackTrasactionAsync();
                return result.Failed(e.Message);
            }
        }

    }
}
