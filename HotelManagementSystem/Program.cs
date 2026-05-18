using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //System storge

            string guestName = "";
            string guestPhone = "";
            int    roomNumber = 0;
            string roomType = "";
            double nightlyRate = 0;
            string checkinDate = "";

            string checkout_date = "";
            int     number_Of_Nights = 0;
            string roomNotes ="";
            double discountPercentage = 0;

           double  loyaltyPoints = 0;
            bool guestIsRegistered = false;
           bool    currentlyCheckedIn = false;


            //Main menu

            Console.WriteLine(" user's choice");
            Console.WriteLine("0) Register New Gues ");
            Console.WriteLine("1) View Guest Information");
            Console.WriteLine("2) Check-In Guest");
            Console.WriteLine("3) Check-Out & Bill " );
            Console.WriteLine("4) Apply Discount ");
            Console.WriteLine("5) Upgrade Room");
            Console.WriteLine("6) Add Room Service Note ");
            Console.WriteLine("7) Search Guest by Name");
            Console.WriteLine("8) Calculate Loyalty Points  ");
            Console.WriteLine("9) Print Receipt  ");
            Console.WriteLine("10) Edit Guest Name  ");
            Console.WriteLine("11) Exit ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            
            {

             









        }
    }
}
