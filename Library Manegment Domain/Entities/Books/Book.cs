using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Loans;

namespace Library_Manegment_Domain.Entities.Books
{
    public class Book : BaseEntity<int>
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Language { get; private set; }
        public byte[] Image { get; private set; }
        public bool IsDeleted { get; private set; }
        public bool IsLoaned { get; private set; }
        public List<Loan> Loans { get; private set; }

        public Book(string title, string author, string language, byte[] image)
        {
            Title = title;
            Author = author;
            Language = language;
            Image = image;
            Loans = new List<Loan>();
        }

        public void Update(string title, string author, string language, byte[] image)
        {
            Title = title;
            Author = author;
            Language = language;
            Image = image;
        }
        

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Loaned()
        {
            IsLoaned = true;
        }
    }
}
