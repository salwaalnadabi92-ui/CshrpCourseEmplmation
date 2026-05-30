using Microsoft.Win32;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        static string bookTitle = "program";

        static string bookAuthor = "";

        static string bookGenre = "";

        static int  NumAvailableCopies = 6;

        static bool   bookIsRegistered = true;

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
                Console.WriteLine("11.Calculate Renewal ");
                Console.WriteLine("12.Update Member Email ");
                Console.WriteLine("13.Session Summary ");
                Console.WriteLine("14.Exit");
                
                }

        //funcation call code for  check if is register or not 
        public static bool checkIsRegisterer()

        {
            if (MemberIsregistered == true)
            {
                Console.WriteLine("account information already exists ");
                return true;
            }
            else
            {
                return false;
            }

        }


        //funcation call code for  add Member

        public static void AddMember()
        {
            Console.WriteLine(" Enter your Name ");
            MemberName = Console.ReadLine();

             string Member =MemberName.Substring(0, 5);
         
            Console.WriteLine(" Enter Member ID ");
                    memberID = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Enter Member Email ");
                    memberEmail = Console.ReadLine();
                    Console.WriteLine(" Enter Member tier");
                    memberTier = Console.ReadLine();
                    Console.WriteLine(" Enter membershipExpiry ");
                    membershipExpiryDate = Console.ReadLine();
                    string Now = DateTime.Now.ToString();
                    Console.WriteLine(Now);


                    MemberIsregistered = true;

                    Console.WriteLine(" added successfully");
                }



        // funcation to check member 
        public static bool checkmember()

        {
            if (MemberIsregistered == false)
            {
                Console.WriteLine("No member found try to registere");
                return false;
            }
            else
            {
                return true;
            }

        }
        //funcation to display all member
        public static void Displaymember()
        {

            Console.WriteLine(" Name " + MemberName);

            Console.WriteLine("Member ID" + memberID);

            Console.WriteLine("Member Email " + memberEmail);

            Console.WriteLine("Member tier" + memberTier);

            Console.WriteLine(" membershipExpiry " + membershipExpiryDate);

        }


        // case 2:Search Book by Title

        public static bool searchofbook(string keyword)
        {
            if(bookTitle.Contains(keyword) && bookIsRegistered==true)

           {
                return true;

            }

            return false;

        }


       //case 3 // borro book

        public static void borrowBook(int copies)

        {


            copies--;

        }

        //case 4 return book

        public static void returnBook(int copies)

        {


            copies++;

        }





        // case:6

        public static double ApplyDiscount(double  amount)
        {

            double discount = amount * 0.10;

            return amount - discount;

        }

        public static double ApplyDiscount(double amount, string tier)

        {
            double discount = 0;


            if (tier == "silver")
            {
                discount = 0.10;
            }

            else if (tier == "gold")

            {
                discount = 0.20;
            }

            else
            {

                discount = 0.5;
                }

                return amount * discount;
            }

        //case3 // funaction to Borrow a Book 

            //public static void BorrowBook (ref int NumAvailableCopies )
            //{

            //    if (NumAvailableCopies>0)

            //     {
            //        NumAvailableCopies = NumAvailableCopies - 1;

            //        Console.WriteLine(" );


            //    }


            //case 8 //Register Book

        public static void libraryregister //funcation ADD BOOK 

            (string Title,
            string Author,
            int AvailableCopies,
            string Genre = "")

        {
            bookTitle = Title;
            bookAuthor = Author;
            NumAvailableCopies = AvailableCopies;
            bookGenre = Genre;

            Console.WriteLine(" BOOK ADD TO LIBRARY SUCCESSFULY");

        }

        //case 5 //Calculate Late Fine 

        public static double CalculateLateFine(int DAYOVER) //FUNCATION TO CALCULATE LATE FINE 

        {

            double Fine = Math.Sqrt(DAYOVER) *2;
            return Fine;

        }


        //case 7 //checke ligibility

       public  static bool checkEligibility(string expirtDate)
        {
            DateTime expiry = DateTime.Parse(expirtDate);

            if (expiry >= DateTime.Today)
            {
                return true;
                  }
            {
                return false;
            }


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

                        bool checkResult = checkIsRegisterer();// this  funcation to call if it register


                        if (checkResult == false) 
                        {
                           AddMember();//funcation to add
                        }
                        
                        break;




                    case 1:

                       bool   result  = checkmember(); //this  funcation to call  if not register

                        if (MemberIsregistered==true)
                        {
                            Displaymember();//funcation to display member

                        }


                        break;





                    case 2:
                        Console.WriteLine("enter keyword");

                           string keyword = Console.ReadLine();
                        bool found = searchofbook(keyword);

                        if (found==true)
                        {

                            Console.WriteLine("book  is found");
                        }

                        else 
                        {
                            Console.WriteLine("book  is not  found");
                        }

                        break;

                    case 3:
                        int copies = 7;
                        borrowBook(copies);
                        Console.WriteLine(  "copies"  +copies);






                                break;

                            case 4:

                        returnBook(copies);
                        Console.WriteLine("copies" + copies);



                        break;

                            case 5:

                        Console.WriteLine(" Enter overdue days");
                        int days = int.Parse(Console.ReadLine());
       
                              double  finalFine  = CalculateLateFine(days);


                        Console.WriteLine("late final " + finalFine);



                        break;




                            case 6:

                        Console.WriteLine(" enter amount:" );
                        double amount=double.Parse(Console.ReadLine());
                        Console.WriteLine(" enter tier:");
                        string tier =Console.ReadLine();
                        double Result = ApplyDiscount(amount);
                        double Result1 = ApplyDiscount(amount,tier);
                        Console.WriteLine(" normal discount" + Result);
                        Console.WriteLine(" tier discount" + Result1);




                        break;

                            case 7:
                    
                        DateTime Date = DateTime.Parse(Console.ReadLine());
                        bool eligible = checkEligibility(Date);
                              if (eligible)
                        {
                            Console.WriteLine(" member can borrow");
                        }
                        else
                            {
                                Console.WriteLine(" member expired");

                            }


                            break;






                            case 8:
                                Console.WriteLine(" enter book title");
                                string bookTitle = Console.ReadLine();
                                Console.WriteLine(" enter auther name");
                                string bookAuthor = Console.ReadLine();
                                Console.WriteLine(" enter number of copies");
                                int NumAvailableCopies = int.Parse(Console.ReadLine());
                                Console.WriteLine(" enter genre");
                                string bookGenre = Console.ReadLine();

                                libraryregister(bookTitle, bookAuthor, NumAvailableCopies, bookGenre);




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
