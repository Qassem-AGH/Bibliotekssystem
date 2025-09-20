namespace Bibliotekssystem
{
    public class Library
    {
        //Här skapar jag attributer
        public string LibraryName;

        public string LibraryAdress; 

        // Här skapar metodar 

        public void GetLibraryInfo()
        {
            Console.WriteLine($"Biblioteket Namn : {LibraryName} , Biblioteket Adress : {LibraryAdress} ");
        }

        //läg till metod för bok som läg till i biblioteket 
        public void  AddBook(Book book)
        {
            Console.WriteLine($"Lägg till en ny bok i biblioteket: Titel: {book.Title}, Författare: {book.Author}, Genre: {book.Genre} ");
        }

        //Lägg till en funktion för att ta bort en bok från biblioteket
        public void Removebook(Book book)
        {
            Console.WriteLine($"Ta bort boken från biblioteket Titel: {book.Title}, Författare: {book.Author}, Genre: {book.Genre}");
        }


    }
}
