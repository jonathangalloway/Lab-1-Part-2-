using System;

namespace Lab_1_Part_2
{
    class Program
    {
        static void Main()
        {
            //year, month, date, hour, minute, seconds
            DateTime date1 = new DateTime(2017, 08, 14, 00, 00, 00);
            DateTime date2 = new DateTime(2016, 06, 13, 00, 00, 00);
            double totalhours = (date1 - date2).TotalHours;
            double totalminutes = (date1 - date2).TotalMinutes;

            Console.WriteLine("Days:{0}, Hours{1}, Minutes:{2}", totaldays, totalhours, totalminutes);
                
        }
    }
}
