namespace Bibliotekssystem
{
    public class LibraryStaff : Member
    {
        //Här är attributar för bibliotekarie 
        public int StaffID;
        public string Position;

        // Metoder
        //Här metod för att visa statt infornation och avr från Member klass 
        public void GetStaffInfo()
        {
            Console.WriteLine($"{MemberName} är Bibliotekarie");
            Console.WriteLine($"Bibliotekarie Namn: {MemberName}");
            Console.WriteLine($"Staff ID: {StaffID}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Kontakt: {ContactInfo}");
        }
        //Här metod vad kan sfatt göra och avr från Member klass 
        public void ManageInventory()
        {
            Console.WriteLine($"{MemberName} hanterar bokinventariet.");
        }
        //Detta metod beskriva hur kan personal hjälper student och avr från Member klass och Student klass
        public void AssistMember(Student member)
        {
            Console.WriteLine($"{MemberName} hjälper medlemmen {member.MemberName}.");
        }
    }

}
