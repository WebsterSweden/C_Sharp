using System;
using System.Globalization;

namespace Globalization1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CultureInfo.CurrentCulture);

            Console.WriteLine(CultureInfo.CurrentUICulture);

            Console.WriteLine(CultureInfo.DefaultThreadCurrentCulture);

            Console.WriteLine(CultureInfo.DefaultThreadCurrentUICulture);

            // TODO: List all values from CultureInfo.

            Console.WriteLine(CultureInfo.GetCultureInfo("en-US").ThreeLetterISOLanguageName);

            Console.WriteLine(CultureInfo.GetCultureInfo("en-US").Calendar);

            Console.WriteLine("----------");

            foreach (CultureInfo cultureInfoItem in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(cultureInfoItem);
            }
        }
    }
}
