using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Members;

namespace Library_Manegment_Domain.Entities.Books
{
    public class Book : BaseEntity<int>
    {
        public string Titlt { get; private set; }
        public string Author { get; private set; }
        public string Language { get; private set; }
        public byte[] Image { get; private set; }
        public List<Loan> Loans { get; set; }

        public Book(string titlt, string author, string language, byte[] image)
        {
            Titlt = titlt;
            Author = author;
            Language = language;
            Image = image;
            Loans = new List<Loan>();
        }
    }
}
