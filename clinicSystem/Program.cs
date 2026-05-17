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
            Console.WriteLine("5)Medical Registor");
            Console.WriteLine("6)EXIT");


                Console.WriteLine("Enter your Opation");
                int opation = int.Parse(Console.ReadLine());


                switch (opation)
                {

              

                case 1:
                        Console.WriteLine("1)Register patient");





                        break;


                    case 2:
                        Console.WriteLine("2) Veiw patient");

                        break;



                    case 3:
                        Console.WriteLine("3)Update patient Information");

                        break;


                       case 4:
                        Console.WriteLine("4)delete patient");


                        break;

                       case 5 :
                        Console.WriteLine("5)Medical Registor");


                        break;


                    case 6:

                        Console.WriteLine("6)EXIT");


                        break;


                } // switch





            }
        }
}
