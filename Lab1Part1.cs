using System;

namespace WindowsFormsApp2
{
    public class Hello
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please type in an integer");
            string input1 = Console.ReadLine();
            int num1;
            int.TryParse(input1, out num1);

            num1 = Convert.ToInt16(input1);

            Console.WriteLine("Hello, Please type in an integer");
            string input2 = Console.ReadLine();
            int num2;
            int.TryParse(input2, out num2);

            num2 = Convert.ToInt16(input2);

            int answer = num1 - num2


         Console.WriteLine(answer);

        }
    }
}
