using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3_ps2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to an integer using TryParse

            Console.WriteLine("Enter a number to convert to an Integer:");
            string numberString = Console.ReadLine();
            int number;

            if (int.TryParse(numberString, out number))
            {
                int multipliedValue = number * 5;
                Console.WriteLine("Conversion successful. Result after multiplying by 5: " + multipliedValue);
            }
            else
            {
                Console.WriteLine("Conversion failed. Invalid input for Integer.");

            }
            Console.ReadKey();


            // Convert a string to a DateTime object using Convert and subtract 1 month
            Console.WriteLine("\nEnter a date to convert to a DateTime (MM/dd/yyyy format):");
            string dateString = Console.ReadLine();

            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(dateString);
                DateTime modifiedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Conversion successful. Date 1 month ago: " + modifiedDateTime.ToString("MM/dd/yyyy"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input for DateTime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadKey();


            // Convert a string to a TimeSpan object using Parse and add 2 hours
            Console.WriteLine("\nEnter a time duration (e.g., 02:30 for 2 hours 30 minutes):");
            string timeString = Console.ReadLine();

            try
            {
                TimeSpan timeSpan = TimeSpan.Parse(timeString);
                TimeSpan modifiedTimeSpan = timeSpan.Add(new TimeSpan(2, 0, 0)); // Adding 2 hours
                Console.WriteLine("Conversion successful. Time after adding 2 hours: " + modifiedTimeSpan);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion failed. Invalid input for TimeSpan.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadKey();



        }
    }
}
