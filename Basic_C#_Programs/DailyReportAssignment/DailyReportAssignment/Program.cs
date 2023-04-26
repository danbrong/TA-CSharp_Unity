using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNum = Console.ReadLine();
            int myPage = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with anything else? Please answer True or False");
            string myHelp = Console.ReadLine();
            bool HelpMe = bool.Parse(myHelp);

            Console.WriteLine("Is there any other feedback you'd like to provide? Be Specific.");
            string myFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string myStudy = Console.ReadLine();
            int studyHours = Convert.ToInt32(myStudy);


            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");


            //// Answer Checking
            //Console.WriteLine(yourName);
            //Console.WriteLine(yourCourse);
            //Console.WriteLine(myPage);
            //Console.WriteLine(HelpMe);
            //Console.WriteLine(myFeedback);
            //Console.WriteLine(studyHours);
            //Console.ReadLine();

        }
    }
}
