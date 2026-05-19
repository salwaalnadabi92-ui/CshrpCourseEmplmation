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
                           guestName = Console.ReadLine().Trim();

                        }


                    break;



                case 1:

                        if (guestIsRegistered == false)

                          {
                            Console.WriteLine(" Aguest not found try to registored ");
                        }

                        else

                        {


                        Console.WriteLine(" ___ Aguest  Information---" );
                        Console.WriteLine(" Guest Name " + guestName.ToUpper());
                        string    roomString = Convert.ToString(roomNumber);//Convert.ToString
                        Console.WriteLine("room number " + roomString);
                        Console.WriteLine("phone " + guestPhone);
                        Console.WriteLine("room type " + roomType);
                        Console.WriteLine("nigtlyrate" + Math.Round(nightlyRate,1));//Math.Round
                        }

                      
                        break;

                case 2:

                        Console.WriteLine(" ___ check-in date----");
                        checkinDate = DateTime.Now;


                        if (currentlyCheckedIn==false)

                        {
                            Console.WriteLine("  not registored found  ");

                        }

                        else
                        {
                            Console.WriteLine("enter number Of Nights ");
                        number_Of_Nights = Convert.ToInt32(Console.ReadLine());
                            checkout_date = DateTime.Today;


                        }
                        break;


                case 3:

                        Console.WriteLine("----Check - Out & Bill---- ");

                        if (currentlyCheckedIn ==false)

                        {
                            Console.WriteLine("Guest not found  ");
                        }

                        else
                        {
                            Console.WriteLine("enter number of night ");
                            int totalnight = Convert.ToInt32(Console.ReadLine());

                            double totalbill = totalnight * nightlyRate;

                            Console.WriteLine("enter discount");
                            discountPercentage = Convert.ToDouble(Console.ReadLine());
                            totalbill = totalbill - (totalbill * discountPercentage);
                             totalbill = Math.Round(totalbill, 2); 


                        }






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
