using System.Collections;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace stack__queue
{
    internal class Program
    {
        //problem 1:Browser History Tracker  

        public static void BrowserHistoryTracker()
        {
            Stack<string> browserHistory=new Stack<string>();


            browserHistory.Push("https://www.google.com/?utm_source=chatgpt.com");
            browserHistory.Push("https://en.wikipedia.org/wiki/Main_Page?utm_source=chatgpt.com");
            browserHistory.Push("https://openai.com/about/?utm_source=chatgpt.com");
            browserHistory.Push("https://github.com/features?utm_source=chatgpt.com");
            browserHistory.Push("https://www.mozilla.org/firefox/new/?utm_source=chatgpt.com");

            Console.WriteLine(" -----display all URL-------");
            foreach(var item in browserHistory) 
            {
                  Console.WriteLine(item);
            }
            Console.WriteLine("-------show last URL------");
            var topitem = browserHistory.Peek();
            Console.WriteLine(topitem);


            Console.WriteLine("-------REMOVE TWO URL------");
            var firstremove=browserHistory.Pop();
            var  secondremove=browserHistory.Pop();
            Console.WriteLine(firstremove);
            Console.WriteLine(secondremove);

            Console.WriteLine(" -------display  Remain URL------- ");
            foreach(var item in browserHistory) {
                Console.WriteLine(item);
            }

            Console.WriteLine(" check is in the list");

           string serachUrl=" https://www.mozilla.org/firefox/new/?utm_source=chatgpt.com";

            if( browserHistory.Contains(serachUrl))
            {
                Console.WriteLine("URL is found ");
            }
            else
            {
                Console.WriteLine("URL not found ");
            }
            Console.WriteLine(" total number of pages remaining:" +( browserHistory.Count) );


        }

        // problem 2: Hotel Check-In Queue 
         public static void HotelCheckInQueue()
        {
            Queue<string> checkInQueue=new Queue<string>();
            Console.WriteLine(" ____________Display all waiting guests __________");
            checkInQueue.Enqueue("salwa" );
            checkInQueue.Enqueue(" Ali");
            checkInQueue.Enqueue("khalfan");
            checkInQueue.Enqueue("fatam");
            checkInQueue.Enqueue("ahmed");
              foreach(string item in checkInQueue) 
            
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" display who is next ");
            var next=checkInQueue.Dequeue();
            Console.WriteLine(next);

            Console.WriteLine(" ------------------------------ ");
            var serve1 = checkInQueue.Dequeue();
            Console.WriteLine(serve1);
            var serve2 = checkInQueue.Dequeue();
            Console.WriteLine(serve2);
            Console.WriteLine("_______________________________");
            Console.WriteLine("remaining queue after serving");
            foreach (string item in checkInQueue)

            {
                Console.WriteLine(item);
            }

            string guestnName = "Ali ";

            if (checkInQueue.Contains(guestnName)) 
            {
                Console.WriteLine(" guset wait");
            }
            else
                {
                    Console.WriteLine("no guest wait ");
                }


            Console.WriteLine(" the total number of guests   " + (checkInQueue.Count));

            }

        //p





        static void Main(string[] args)
        {


            bool exit = false;

            while (exit == false)
            {

                Console.WriteLine("  Enter your choose");
                Console.WriteLine(" ___________________________________");
                Console.WriteLine("1)Problem : Browser History Tracker  ");
                Console.WriteLine("2)Problem : Hotel Check-In Queue  ");
                Console.WriteLine("3)Problem : Text Editor Undo System");
                Console.WriteLine("4)Problem : Hospital Emergency Room Triage ");
                Console.WriteLine("5)Problem : Parenthesis Validator ");
                Console.WriteLine("6)Problem : Print Spooler with Priority Re-Insertion");
                Console.WriteLine("7)Problem : Reverse a Sentence Word by Word  ");
                Console.WriteLine("8)Problem : Multi-Level Undo with Redo");
                Console.WriteLine("9)Problem : Ticket Counter Simulation ");
                Console.WriteLine("10)Problem:Order Processing Pipeline with Statistics  ");
                int choice = int.Parse(Console.ReadLine());





                switch (choice)
                {

                    case 1:

                        BrowserHistoryTracker();

                        break;

                    case 2:
                        HotelCheckInQueue();

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
