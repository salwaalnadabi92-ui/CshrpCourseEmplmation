using Microsoft.Win32;
using System.Xml.Linq;
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
            DateTime checkinDate;

            DateTime checkout_date;
            int     number_Of_Nights = 0;
            string roomNotes ="";
            double discountPercentage = 0;

           int   loyaltyPoints = 0;
            bool guestIsRegistered = false;
           bool    currentlyCheckedIn = false;


            //Main menu

            bool exit = false;

            while (exit == false) {

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
            Console.WriteLine("enter your choice");


                int choice = int.Parse(Console.ReadLine());

            switch (choice)
            
            {

                case 0:

                    if (guestIsRegistered = false)
                    {

                        Console.WriteLine(" already you are registered ");
                    }


                    else
                    {

                        Console.WriteLine(" enter your full name");
                            guestName = Console.ReadLine().Trim();

                            Console.WriteLine(" enter your phone number");
                        guestPhone = Console.ReadLine();

                        Console.WriteLine(" enter  nightly rate");
                            nightlyRate =double.Parse (Console.ReadLine());

                            Console.WriteLine(" choose room number");

                            Random random = new Random();///first declared random 

                            roomNumber = random.Next(1, 10);

                            Console.WriteLine("random number " + roomNumber);


                            guestIsRegistered = true;


                            Console.WriteLine("Aguest registored successfully ");
                           

                        }


                    break;



                case 1:

                    break;

                case 2:

                    break;


                case 3:

                    break;


                case 4:

                    break;

                case 5:

                    break;


                case 6:

                    break;

                case 7:

                    break;

                case 8:

                    break;

                case 9:

                    break;

                case 10:

                    break;


                case 11:

                    break;

                        exit = true;

                default :

                    break;




                }//end switch



                Console.WriteLine("press any key ");
                Console.ReadKey();
                Console.Clear();


            } //end while 







        }
    }
}
