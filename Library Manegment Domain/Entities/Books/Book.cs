namespace Library_Manegment_Domain.Entities.Books
{
    public class Book
    {
        public int Id { get; private set; }
        public string Titlt { get; private set; }
        public string Author { get; private set; }
        public string Language { get; private set; }
        public byte[] Image { get; private set; }

        public Book(string titlt, string author, string language, byte[] image)
        {
            Titlt = titlt;
            Author = author;
            Language = language;
            Image = image;
        }
    }
}
