using System.Security.Cryptography.X509Certificates;

namespace array
{
    internal class Program
    {

        ///problem 1
        public static void Temp() {


            double[] temperatures = new double[] { 34, 45, 38, 49, 50, 44, 39 };

            for (int i = 0; i<temperatures.Length; i++)
            {

                Console.WriteLine("The day"  + i +"is:");
                Console.WriteLine(temperatures[i]);



            }
        }
        //proplem 2
        //public static void StudentScore()
        //{
        //    int[] scores = new int[] { 70, 90, 60, 87, 56, 84 };

        //    foreach (int number in scores)
        //    {
        //        Console.WriteLine(scores);
        //    }




        //}


        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {

                Console.WriteLine("  Enter your choose");
            Console.WriteLine(" ___________________________________");
            Console.WriteLine("1)Problem :Temperature Log   ");
            Console.WriteLine("2)Problem : Student Score Board  ");
            Console.WriteLine("3)Problem : Product Price Finder ");
            Console.WriteLine("4)Problem : Race Finish Times   ");
            Console.WriteLine("5)Problem : Classroom Grade Report  ");
            Console.WriteLine("6)Problem : Warehouse Inventory Check  ");
            Console.WriteLine("7)Problem : Library Book Shelf Scanner");
            Console.WriteLine("8)Problem : Sales Performance Analyzer  ");
            Console.WriteLine("9)Problem : Flight Seat Allocation Display  ");
            Console.WriteLine("10)Problem : Hospital Patient Priority Queue  ");
            int choice= int.Parse(Console.ReadLine());

            



            switch(choice) 
            {

                case 1:

                        Temp();

                    break;

                case 2:
                        //StudentScore();

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

                    default:

                    break;

            }//switch


                Console.WriteLine("Enter any key");

                Console.ReadKey();
                Console.Clear();


            }//while

        }
    }
}
