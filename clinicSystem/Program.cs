using Microsoft.VisualBasic;

namespace clinicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string PatientName = "";

            int PatientID = 0;

            int PatientAge = 0;

            string PatientPhone = "";

            bool IsActive = false;



            bool exit  = false;

        while (exit == false) {
           

            Console.WriteLine("Main Menu");
            Console.WriteLine("1)Register patient");
            Console.WriteLine("2) Veiw patient");
            Console.WriteLine("3)Update patient Information");
            Console.WriteLine("4)delete patient");
            Console.WriteLine("5)EXIT");


                Console.WriteLine("Enter your Opation");
                int opation = int.Parse(Console.ReadLine());


                switch (opation)
                {



                    ////ADD patient

                    case 1:
                        Console.WriteLine("1)Register patient");
                    if (IsActive == true)
                    {
                        Console.WriteLine("patient information already exists please edit  information if you want to change it");
                    }

                    else
                    {
                        Console.WriteLine("enter your name");
                        PatientName = Console.ReadLine();

                        Console.WriteLine("enter your ID");
                        PatientID =int.Parse(Console.ReadLine());

                        Console.WriteLine("enter your age ");
                        PatientAge =int.Parse(Console.ReadLine());

                        Console.WriteLine("enter your phone ");
                        PatientPhone =Console.ReadLine();

                        IsActive = true;

                        Console.WriteLine("information added successfully");
                    }

                    break;


                        //////Veiw patient

                    case 2:

                        Console.WriteLine("2) Veiw patient");

                    if (IsActive == false)
                    {
                        Console.WriteLine("no account information found please add patient information first");
                    }
      
                    else

                    {
                        Console.WriteLine("patient name : "+  PatientName);
                        Console.WriteLine("patient ID: "+   PatientID);
                        Console.WriteLine("patient Age : "+  PatientAge);
                        Console.WriteLine("patient name :" +   PatientPhone);
                    }

                    break;


                       ////// Update patient Information

                    case 3:
                        Console.WriteLine("3)Update patient Information");


                        Console.WriteLine(" choice your edit:   ");
                        Console.WriteLine("1. Edit  Name");
                        Console.WriteLine("2. Edit phone ");
                        int choice =int.Parse(Console.ReadLine());

                        if (choice ==1)
                        {

                            Console.WriteLine(" Enter new name  ");
                            PatientName =Console.ReadLine();
                            Console.WriteLine(" update  successfully ");
                        }

                        else if (choice == 2)

                        {

                            Console.WriteLine(" Enter new phone ");
                            PatientPhone = Console.ReadLine();
                            Console.WriteLine(" update  successfully ");
                        }

                        else
                        {

                            Console.WriteLine(" invlaid opatin try again ");
                }


                break;



                    //////delete patient Information


                    case 4:

                        Console.WriteLine("4)delete patient");

                        Console.WriteLine("enter your name :  ");
                        string name = Console.ReadLine();

                        if (IsActive && name ==PatientName  )
                        {

                            PatientName = "";

                            PatientID = 0;

                            PatientAge = 0;

                             PatientPhone = "";

                             IsActive = false;

                            Console.WriteLine("patien deleted  successfully");

                        }
                        else

                        {
                            Console.WriteLine("patient not found ");
                        }

                        break;

                       

                      ///   EXIT
                      
                    case 5:

                        Console.WriteLine("5)EXIT");

                        exit = true;

                        break;

                default:

                    Console.WriteLine("invaild");

                    break;


                } // switch

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); 




            } //while




        }
        }
}
