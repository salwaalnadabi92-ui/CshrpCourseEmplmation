using System.Collections;
using System.ComponentModel.Design;
using System.Threading.Channels;
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
            var next=checkInQueue.Peek();
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

       // problem 3:  Text Editor Undo System

        public static void TextEditorUndoSystem()
        {

            Stack<string> undoStack = new Stack<string>();

            undoStack.Push("Created page");
            undoStack.Push("Deleted page");
            undoStack.Push("Renamed page");
            undoStack.Push("Duplicated page");
            undoStack.Push("Moved page");
            undoStack.Push("Changed page URL");
            undoStack.Push("Updated page content");
            Console.WriteLine(" display all description ");
            Console.WriteLine("_______________________________");
            foreach (string item in undoStack)

            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_______________________________");
            Console.WriteLine("  undone next ");
            var undo = undoStack.Peek();
            Console.WriteLine(undo);
            Console.WriteLine("_______________________________");
            Console.WriteLine(" Undo the last 2 actions   ");
            var firstAction= undoStack.Pop();
            Console.WriteLine("remove first action " + firstAction);

            var secondAction = undoStack.Pop();
            Console.WriteLine("remove second action " + secondAction);
            Console.WriteLine("_______________________________");
            Console.WriteLine(" display the remaining undo history ");
            foreach (string item in undoStack)

            {
                Console.WriteLine(item);
            }

               Stack<string> tempStack= new Stack<string>();//Temporary stack

            Console.WriteLine("move to tempstack from undostack  ");

            tempStack.Push(undoStack.Pop());
            tempStack.Push(undoStack.Pop());
            undoStack.Pop();

            foreach (string item in undoStack)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine(" SHOW REMIAN VLUES in UNDOSTACK");
            undoStack.Push(tempStack.Pop());
            undoStack.Push(tempStack.Pop());

            foreach (string item in undoStack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Display the final Count"+ undoStack.Count );
        }

        //PROBLEM 4: Hospital Emergency Room Triage

        public static void HospitalEmergencyRoomTriage()
        {
         Queue<string> triageQueue = new Queue<string>();

            triageQueue.Enqueue("patient1");
            triageQueue.Enqueue("patient2");
            triageQueue.Enqueue("patient3");
            triageQueue.Enqueue("patient4");
            triageQueue.Enqueue("patient5");
            triageQueue.Enqueue("patient6");
            triageQueue.Enqueue("patient7");
            triageQueue.Enqueue("patient8");
            Console.WriteLine(" display all ");
            Console.WriteLine("_______________________________");

            int POSTION = 1;
            foreach (var item in triageQueue)
            {
                Console.WriteLine(POSTION + ":" + item);

          POSTION++;
            }
          

            Console.WriteLine("who will be seen next");
             var next= triageQueue.Peek();
            Console.WriteLine(next);

            Console.WriteLine("  result  the first 3 patients remove    ");
            var Name1 = triageQueue.Dequeue();
            Console.WriteLine(Name1);

            var Name2 = triageQueue.Dequeue();
            Console.WriteLine(Name2);

            var Name3 = triageQueue.Dequeue();
            Console.WriteLine(Name3);
            Console.WriteLine(" Display the remaining queue  ");

            foreach (var item in triageQueue)
            {
                Console.WriteLine(item);
            }



            Queue<string> tempQueue= new Queue<string>();//TEMP 

            Console.WriteLine("Remove them from the queue  to temp");
            triageQueue.Enqueue(tempQueue.Dequeue());
            triageQueue.Enqueue(tempQueue.Dequeue());
            triageQueue.Dequeue();

            foreach (string item in triageQueue)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(" SHOW REMIAN VLUES in queue");
            triageQueue.Enqueue(tempQueue.Dequeue());
            triageQueue.Enqueue(tempQueue.Dequeue());

            foreach (string item in triageQueue)
            {
                Console.WriteLine(item);
            }







        }




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
                            TextEditorUndoSystem();

                            break;

                    case 4:

                        HospitalEmergencyRoomTriage();

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
