using Library_Manegment_Domain.Common;

namespace Library_Manegment_Domain.Entities.Members
{
    public class MemberCredential : BaseEntity<int>
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        // اگر لازم داشتی می‌توانی Role یا نام نمایشی هم اضافه کنی
        // public string FullName { get; private set; }

        // سازنده برای EF Core
        //protected MemberCredential() { }

        // سازنده اصلی برای ایجاد یوزر جدید
        public MemberCredential(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }
    }
}
