using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public class MemberCredential : BaseEntity<int>
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public bool IsActive { get; private set; }

        // ایجاد یوزر جدید
        public MemberCredential(
        string userName,
        string password,
        string role)
        {
            UserName = userName;
            Password = password;
            Role = role;
            IsActive = true;
        }

        public void ChangeUserName(string userName)
        {
            UserName = userName;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void Disable()
        {
            IsActive = false;
        }

        public void Enable()
        {
            IsActive = true;
        }
    }
}
