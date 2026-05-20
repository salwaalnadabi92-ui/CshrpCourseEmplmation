using System.Timers;
using static System.Collections.Specialized.BitVector32;

namespace LibraryManagementSystem
{
    internal class Program
    {
        //system storage(variables )

        static string MemberName = "";

        static int memberID = 0;

        static string memberEmail ="";

        static string membershipExpiryDate = "";

        static string memberTier = "";

        static bool   MemberIsregistered=false;

        static string bookTitle = "";

        static string bookAuthor = "";

        static string bookGenre = "";

        static int  NumAvailableCopies = 0;

        static bool   bookIsRegistered = false;

        static int totalBooksBorrowed = 0;

        static double totalFinesPaid = 0;


        //funcation call code of main menu
        public static void PrintMainMenu()
        {

          
            Console.WriteLine("Main Menu:");
                Console.WriteLine("0.Register Member");
                Console.WriteLine("1.Display Member");
                Console.WriteLine("2.Search Book by Title ");
                Console.WriteLine("3.Borrow a Book");
                Console.WriteLine("4.Return a Book ");
                Console.WriteLine("5.Calculate Late Fine");
                Console.WriteLine("6.Apply Member ");
                Console.WriteLine("7.Check Borrowing ");
                Console.WriteLine("8.Register Book ");
                Console.WriteLine("9.Generate Member ID");
                Console.WriteLine("10.Display Book Details ");
                Console.WriteLine("11.Display Book Details ");
                Console.WriteLine("12.Update Member Email ");
                Console.WriteLine("13.Session Summary ");
                Console.WriteLine("14.Exit");
                
                } 









        static void Main(string[] args)
        {
                bool exit = false;
                while (exit == false)
                {

                PrintMainMenu();


                Console.WriteLine("please select an option from the menu:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {


                    case 0:

                        if (MemberIsregistered == true) 
                        {
                            Console.WriteLine("  There is no Member  registred");

                        }
                        else 


                        {


                            Console.WriteLine(" Enter full Name ");
                             MemberName  = Console.ReadLine();
                            string Member = MemberName.Substring(0,5);
                            Console.WriteLine(Member);
                            Console.WriteLine(" Enter Member ID ");
                             memberID   = int.Parse(Console.ReadLine());
                            Console.WriteLine(" Enter Member Email ");
                            memberEmail = Console.ReadLine();
                            Console.WriteLine(" Enter Member tier");
                             memberTier   = Console.ReadLine();
                            Console.WriteLine(" Enter membershipExpiry ");
                             membershipExpiryDate = Console.ReadLine();
                            string Now = DateTime.Now.ToString();
                            Console.WriteLine(Now);
                        }




                       //// bool checkResult = CheckisActive();

                       // if (checkResult == false) //there is no account stored
                       // {
                       //     AddAccountInformation();
                       // }//







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

                    case 12:

                        break;
                            case 13:
                        break;

                    case 14:
                        break;

                    default:
                        break;



                } //end switch


                Console.WriteLine("press any key ");
                Console.ReadKey();
                Console.Clear();



            } //end while



















































        }
    }
}
