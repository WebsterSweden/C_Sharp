using System;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeOne = new DateTime();
            // 1/1/0001 12:00:00 AM
            Console.WriteLine(dateTimeOne);
            DateTime dateTimeOneNow = DateTime.Now;
            Console.WriteLine(dateTimeOneNow);

            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine(dateTimeNow);

            string[] dateTimeProperties = { "Year", "Month", "Hour", "Minute", "Second", "Milliseconds" };
            Console.WriteLine("dateTimeProperties.Length: " + dateTimeProperties.Length);

            foreach (string property in dateTimeProperties)
            {
                // TODO: Loop all DateTime properties.
                // How to loop through array elements?
            }

            Console.WriteLine("DateTime.Now.Year: " + DateTime.Now.Year);
            Console.WriteLine("DateTime.Now.Month: " + DateTime.Now.Month);
            Console.WriteLine("DateTime.Now.Hour: " + DateTime.Now.Hour);
            Console.WriteLine("DateTime.Now.Minute: " + DateTime.Now.Minute);
            Console.WriteLine("DateTime.Now.Minute: " + DateTime.Now.Second);
            Console.WriteLine("DateTime.Now.Millisecond: " + DateTime.Now.Millisecond);

            // Day of week.
            Console.WriteLine("DateTime.Now.DayOfWeek: " + DateTime.Now.DayOfWeek);

            // Day of year.
            Console.WriteLine("DateTime.Now.DayOfYear: " + DateTime.Now.DayOfYear);

            // Set first day of the week to Monday.
            int MondayFirstDayOfWeek = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(MondayFirstDayOfWeek);
        }
    }
}
