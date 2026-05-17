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


        
           

                Console.WriteLine("Main Menu");
            Console.WriteLine("1)Register patient");
            Console.WriteLine("2) Veiw patient");
            Console.WriteLine("3)Update patient Information");
            Console.WriteLine("4)delete patient");
            Console.WriteLine("5)Medical hoistory");
            Console.WriteLine("6)EXIT");


                Console.WriteLine("Enter your Opation");
                int opation = int.Parse(Console.ReadLine());


                switch (opation)
                {

              

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



                    case 3:
                        Console.WriteLine("3)Update patient Information");




                        break;


                       case 4:
                        Console.WriteLine("4)delete patient");


                        break;

                       case 5 :
                        Console.WriteLine("5)Medical hoistory");


                        break;


                    case 6:

                        Console.WriteLine("6)EXIT");


                        break;



                default:

                    Console.WriteLine("invaild");

                    break;


                } // switch





            }
        }
}
