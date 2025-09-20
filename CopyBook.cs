namespace Bibliotekssystem
{
    public class CopyBook : Book
    {
        //Attributer för bok kopia
        public int CopyID;
        public int CopyNumber;
        public string BookStatus;

        //Här skapar en metod för att för att visa information om en bokkopia
        public void GetCopyNumberOfBook(Book book1)
        {
            Console.WriteLine("Kopieinformation:");
            Console.WriteLine($"Titel:{Title}");
            Console.WriteLine($"Författare: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Kopienummer: {CopyNumber}");
            Console.WriteLine($"Kopie-ID: {CopyID}");
            Console.WriteLine($"Status: {BookStatus}");            
        }
    }
}
