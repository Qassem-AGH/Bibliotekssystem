namespace Bibliotekssystem
{
    public class Borrowing
    {
        //Här är attributar 
        public int BorrowingID;
        public DateTime BorrowingDate;
        public DateTime DueDate;
        public DateTime ReturnDate;
        public string BorrowingStatus;

        // Metod för att visa grundläggande information om lånet
        public void GetBorrowingInfo()
        {
            Console.WriteLine($"Lån-ID: {BorrowingID}");
            Console.WriteLine($"Lånedatum: {BorrowingDate}");
            Console.WriteLine($"Förfallodatum: {DueDate}");
            Console.WriteLine($"Status: {BorrowingStatus}");
        }

        // Metod för att visa uppdaterad information efter återlämning
        public void UppdateBorrowingInfo()
        {
            Console.WriteLine("Boken har återlämnats:");
            Console.WriteLine($"Återlämningsdatum: {ReturnDate}");
            Console.WriteLine($"Status: {BorrowingStatus}");
        }
    }
}
