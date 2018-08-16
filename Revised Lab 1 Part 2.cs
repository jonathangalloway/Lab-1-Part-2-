using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Please type in an Date and Time");
            string input1 = Console.ReadLine();
            int DateTime1;
            int.TryParse(input1, out DateTime1);

            DateTime1 = Convert.ToInt16(input1);

            Console.WriteLine("Hello, Please type in an integer");
            string input2 = Console.ReadLine();
            int DateTime2;
            int.TryParse(input2, out DateTime2);

            TimeSpan span = (DateTime1 - DateTime2);
            int answer = DateTime1 - DateTime2

                Console.WriteLine(answer);

            String.Format("{0} days, {1} hours, {2} minutes, {3} seconds)",
                span.Days, span.Hours, span.Minutes, span.Seconds);
        }
    }
}
