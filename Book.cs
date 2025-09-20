namespace Bibliotekssystem
{
    public class Book
    {
        // Här är attribuar för bok Titel,Författare och Genre
        public string Title;
        public string Author;
        public string Genre;

        // Metod för att  visa status för bokkopia
        public void CheckBookStatus(CopyBook copyBook)
        {
            Console.WriteLine($"Boken med titeln {Title} har kopie ID: {copyBook.CopyID} ");
            Console.WriteLine($"Antal exemplar av samma bok : {copyBook.CopyNumber}");
            Console.WriteLine($"Status för boken: {copyBook.BookStatus}");

        }


    }
}

