namespace Contracts.Book
{
    public class BookDTO  // data transform object
    {
        public int Id { get; set; }
        public string Titlt { get; private set; }
        public string Author { get; private set; }
        public string Language { get; private set; }
        public byte[] Image { get; private set; }
    }
}
