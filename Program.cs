using System;
using System.Diagnostics.Metrics;

namespace Bibliotekssystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Skapade Library-objekt och lade till GetLibraryInfo-metod
            Library newLibrary = new Library
            {
                LibraryName = "Göteborgs Bibliotek",
                LibraryAdress = "Biskopsgården 11"
            };

            // Hämtar information om biblioteket
            newLibrary.GetLibraryInfo();
            Console.ReadLine();

            // Skapade bibliotekspersonal 
            LibraryStaff staff = new LibraryStaff
            {
                StaffID = 5677654,
                Position = "Bibliotekarie",
                MemberName = "Sara",
                MemberID = 98765,
                ContactInfo = "sara@hotmail.com"
            };
            // Visar personalens information och hanterar inventarier
            staff.GetStaffInfo();
            staff.ManageInventory();
            Console.ReadLine(); 

            // Skapade Book-objekt och lade till i biblioteket
            Book book1 = new Book
            {
                Title = "C#",
                Author = "Nemo",
                Genre = "Programming"
            };
            //Här lägg boken till  i biblioteket
            newLibrary.AddBook(book1);
            Console.ReadLine();

            // Skapade CopyBook-objekt och visade status
            CopyBook copyBook = new CopyBook
            {
                Title = book1.Title,
                Author = book1.Author,
                Genre = book1.Genre,
                CopyID = 112233,
                CopyNumber = 3, 
                BookStatus = "Available"
            };
            
            book1.CheckBookStatus(copyBook);
            Console.ReadLine();

            //Här visar antal kopior av boken
            copyBook.GetCopyNumberOfBook(copyBook);
            
            Console.ReadLine();

            // Skapade studentmedlem och visade information
            Student student = new Student
            {
                StudentID = 1001,
                DepartmentName = "Systemutvecklare .NET",
                MemberName = "Qassem",
                MemberID = 12345,
                ContactInfo = "qassem@hotmail.com"
            };
            //Här Student informatoin
            student.GetStudetInfo();
            Console.ReadLine();

            //// Studenten reserverar och lånar en bok
            student.ReserveBook(copyBook);
            Console.ReadLine();

            //visa information om lånet
            student.BorrowBook(copyBook);
            Console.ReadLine();

            // Bibliotekspersonalen hjälper studenten
            staff.AssistMember(student);
            Console.ReadLine();

            // Skapar ett låneobjekt med datum och status
            Borrowing borrowing = new Borrowing
            {
                BorrowingID = 1,
                BorrowingDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(15),
                ReturnDate = DateTime.UtcNow.AddDays(14),
                BorrowingStatus = "Active"
            };
            //Här att visa information om lånet
            borrowing.GetBorrowingInfo();
            Console.ReadLine();
            // Visar och uppdaterar låneinformation
            borrowing.UppdateBorrowingInfo();
            Console.ReadLine();

            // Studenten returnerar boken
            student.ReturnBook(copyBook);
            Console.ReadLine();

            // Visar uppdaterad information om kopior av boken after renturn boken
            copyBook.GetCopyNumberOfBook(book1);
            Console.ReadLine();

        }
    }
}
