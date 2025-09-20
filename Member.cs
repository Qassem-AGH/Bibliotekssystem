using System.Globalization;
using System.Xml.Linq;

namespace Bibliotekssystem
{
    public class Member
    {
        //Här är attributer om Medlem
        public string MemberName;
        public int MemberID;
        public string ContactInfo;

        //Metod för att låna en bokkopia
        public void BorrowBook(CopyBook copyBook)
        {
            // Kontrollera om det finns exemplar kvar att låna
            if (copyBook.CopyNumber > 0)
            {
                // Minska antalet tillgängliga exemplar med 1
                copyBook.CopyNumber -= 1;
                // Visa hur många exemplar som återstår
                Console.WriteLine($"Antal exemplar kvar: {copyBook.CopyNumber}");
            }
            else
            {
                // Meddela att inga exemplar finns tillgängliga
                Console.WriteLine("Inga exemplar finns tillgängliga för bokning.");
            }
        }
        // Metod för att returnera en bokkopia
        public void ReturnBook(CopyBook copyBook)
         {
            // Kontrollera att bokkopian inte är null
            if (copyBook != null)
            {
                // Uppdatera bokstatusen till "Available"
                copyBook.BookStatus = "Available";
                // Öka antalet tillgängliga exemplar med 1
                copyBook.CopyNumber += 1;
                // Bekräfta att boken har returnerats
                Console.WriteLine($"Boken har returnerats av medlemmen {MemberName}");
                Console.WriteLine($"Status: {copyBook.BookStatus}");
                Console.WriteLine($"Antal exemplar nu: {copyBook.CopyNumber}");
            }
            else
            {
                // Meddela att det inte finns någon bok att returnera
                Console.WriteLine("Ingen bok att returnera.");
            }
         }


    }

}
