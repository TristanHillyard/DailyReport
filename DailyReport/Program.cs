using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.Read();
            Console.WriteLine("Student Daily Report");
            Console.Read();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("My name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("I am on the " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number");
            string pageNum = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNum);
            Console.WriteLine("Page " + pgNum);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            if (needHelp == true)
            {
                Console.WriteLine("I need help");
            }
            else 
            {
                Console.WriteLine("I don't need help");
            }
            Console.Read();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string advice = Console.ReadLine(); 
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hrsStudied = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hrsStudied);
            Console.WriteLine(hoursStudied);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

        }
    }
}
