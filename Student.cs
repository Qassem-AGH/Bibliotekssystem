namespace Bibliotekssystem
{
    public class Student : Member
    {
        //Här är attributar för student 
        public int StudentID;
        public string DepartmentName;

        //Här vissar jag studunt information och avr från Member klass 
        public void GetStudetInfo()
        {
            Console.WriteLine($"{MemberName} är en student");
            Console.WriteLine($"Medlem Namn: {MemberName}");
            Console.WriteLine($"Student ID: {MemberID}");
            Console.WriteLine($"Kontaktinformation: {ContactInfo}");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"Avdelning: {DepartmentName}");
        }
        //Här metod för att reservera en bokkopia 
        public void ReserveBook(CopyBook copyBook)
        {
            Console.WriteLine($"{MemberName} har reserverat boken med ID: {copyBook.CopyID}");

            // Kontrollerar om boken är tillgänglig för reservation
            if (copyBook.BookStatus == "Available")
            {
                copyBook.BookStatus = "Reserverad";
                Console.WriteLine("Boken har reserverats.");
            }
            else
            {
                Console.WriteLine("Boken är inte tillgänglig för reservation.");
            }
        }

    }
}
