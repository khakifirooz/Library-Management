using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public class MemberCredential : BaseEntity<int>
    {
        public int MemberId { get; private set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public Member Member { get; private set; }


        public MemberCredential(int memberId, string userName, string password)
        {
            MemberId = memberId;
            UserName = userName;
            Password = password;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
