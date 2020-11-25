using System;
using System.IO;

namespace using1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\using1.txt";

            if (!File.Exists(path))
            {
                // Create text file.
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine("First");
                    streamWriter.WriteLine("Second");
                    streamWriter.WriteLine("Third");
                }
            }

            // Open text file and read the content.
            using (StreamReader streamReader = File.OpenText(path))
            {
                string stringLine;

                while ((stringLine = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(stringLine);
                }
            }
        }
    }
}
