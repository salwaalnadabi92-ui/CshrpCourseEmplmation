namespace list
{
    internal class Program
    {


        ///problem 1
        public static void Temp()
        {


            List<double> temperatures = new List<double>() { 34, 45, 38, 49, 50, 44, 39 };

            for (int i = 0; i < temperatures.Count; i++)
            {

                Console.WriteLine("The day" + (i + 1) + ":" + temperatures[i] + "c");

            }

            Console.WriteLine("The total reading" + temperatures.Count);

        }

        //proplem 2
        public static void StudentScore()
        {
           List <int> scores = new  List<int> { 70, 90, 60, 87, 56, 84 };

            Console.WriteLine(" original order");
            foreach (int number in scores)
            {
                Console.WriteLine(number);
            }

            scores.Reverse();
            Console.WriteLine(" Reverse Scores");

            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);


            }

        }



        //proplem 3:Product Price Finder 
        public static void Price()
        {

            List<double> prices = new List<double> { 2.4, 3.8, 5.9, 6.8, 4.5 };

            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine("The product" + (i + 1) + ":" + prices[i]);

            }

            //double targetprice = 5.9;
            // int index= Array.IndexOf(prices, targetprice);
            int index = prices.IndexOf( 5.9);
            if (index == -1)
            {
                Console.WriteLine(" price is not found");

            }
            else
            {
                Console.WriteLine(" price is found" + index);

            }

        }


        //problem 4 :Race Finish Times  
        public static void RaceFinishTimes()
        {
            List<int>finishTimes = new List<int> { 90, 87, 120, 78, 95, 110, 100, 105 };
            Console.WriteLine(" original order");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time);
            }


            finishTimes.Sort();
            Console.WriteLine("DISPLAY SORT");
            foreach (int time in finishTimes)
            {
                Console.WriteLine(time);
            }


            Console.WriteLine(" participants  " + finishTimes.Count);
        }



        //problem 5: Classroom Grade Report 
        public static void ClassroomGradeReport()
        {

            List<int> grades = new List<int> { 99, 98, 100, 87, 80, 76, 95, 87, 70, 86 };

            grades.Sort();
            grades.Reverse();

            Console.WriteLine(" rank label  ");

            for (int i = 0; i < grades.Count; i++)
            {

                Console.WriteLine("Rank" + (i + 1) + ":" + grades[i]);
            }


        }

        //problem 6:  Warehouse Inventory Check  
        public static void WarehouseInventoryCheck()
        {

            List<int> quantities = new  List<int>{ 70, 60, 56, 48, 55, 56, 76, 82 };

            int total = 0;

            for (int i = 0; i < quantities.Count; i++)
            {
                total += quantities[i];
            }
            Console.WriteLine(" toatl" + ":" + total);



            double average = (double)total / quantities.Count;

            Console.WriteLine(" average " + ":" + average);

            int index = quantities.IndexOf( 55);
            if (index == -1)
            {
                Console.WriteLine(" quantity is not found");

            }
            else
            {
                Console.WriteLine("quantity is found" + ":" + index);

            }


        }

        // Problem 7: Library Book Shelf Scanner

        public static void LibraryBookShelfScanner()
        {
            List<int>copies = new List<int>{ 7, 5, 4, 3, 2, 1, 5, 8, 4 };

            Console.WriteLine("original order ");
            foreach (int number in copies)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("sort copies  ");
            copies.Sort();

            foreach (int number in copies)
            {
                Console.WriteLine(number);
            }


            bool contains0=copies.Contains(0);
            Console.WriteLine( "list contains zero" + contains0);

        }






















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
                int choice = int.Parse(Console.ReadLine());





                switch (choice)
                {

                    case 1:

                        Temp();

                        break;

                    case 2:
                        StudentScore();

                        break;

                    case 3:
                        Price();

                        break;

                    case 4:

                        RaceFinishTimes();
                        break;

                    case 5:
                        ClassroomGradeReport();

                        break;

                    case 6:

                        WarehouseInventoryCheck();

                        break;

                    case 7:

                        LibraryBookShelfScanner();


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
