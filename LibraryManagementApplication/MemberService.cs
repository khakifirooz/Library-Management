using FrameworkApplication;
using Library_Manegment_Domain.Entities.Members;
using LibraryManagementContracts.Member;

namespace LibraryManagementApplication
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<OperationResult> CreateAsync(MemberCreateModel command)
        {
            OperationResult result = new();
            try
            {
                if (await _memberRepository.ExistAsync(x => x.NationalCode == command.NationalCode))
                    return result.Failed(ApplicationMessages.DublicateRecord);

                var member = new Member(command.Name, command.Family, command.NationalCode,
                    command.Mobile, command.IsSpecial, command.Image);

                await _memberRepository.CreateAsync(member);
                await _memberRepository.SavaChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {
                return result.Failed(e.Message);
            }
        }

        public async Task<List<MemberViewModel>> GetAllAsync()
        {
            var result = await _memberRepository.GetAllAsync();
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
            var result  = await _memberRepository.GetByIdAsync(id);
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

        public async Task<List<MemberViewModel>> SearchAsync(int id, string? nationalCode)
        {
            var result = await _memberRepository.SearchAsync(id, nationalCode);
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
                var member = await _memberRepository.GetByIdAsync(command.Id);
                if (member is null)
                    return result.Failed(ApplicationMessages.RecordNotFound);

                if (await _memberRepository.ExistAsync(x => x.NationalCode == command.NationalCode && x.Id != command.Id))
                    return result.Failed(ApplicationMessages.DublicateRecord);

                member.Update(command.Name, command.Family, command.NationalCode,
                    command.Mobile, command.IsSpecial, command.Status, command.Image);

                _memberRepository.Update(member);
                await _memberRepository.SavaChangesAsync();
                return result.Succeded();
            }
            catch (Exception e)
            {
                return result.Failed(e.Message);
            }
        }
    }
}
