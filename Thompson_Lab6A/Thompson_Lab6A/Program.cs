using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_Lab6A
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            do
            {
                Console.Write("Enter time in 24-hour notation: ");

                try
                {
                    string time24 = Console.ReadLine();
                    int hour24, min24;
                    try
                    {
                        hour24 = Int32.Parse(time24.Substring(0, 2));
                        min24 = Int32.Parse(time24.Substring(3, 2));
                    }
                    catch (Exception)
                    {
                        throw new TimeFormatException(time24);
                    }

                    validateTime(time24, hour24, min24);

                    string time12 = convertTo12Hr(hour24, min24);
                    Console.WriteLine("That is the same as: " + time12);
                }
                catch (TimeFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Write("Again?(y/n): ");
                again = char.Parse(Console.ReadLine());
            } while (again == 'y');

            Console.WriteLine("Thank you - end of program.");
        }

        static void validateTime(string time, int hour, int min)
        {
            if (hour >= 24 || hour < 0)
            {
                throw new TimeFormatException(time);
            }
            else if (min >= 60 || min < 0)
            {
                throw new TimeFormatException(time);
            }
        }

        static string convertTo12Hr (int hour, int min)
        {
            string AMorPM = "";
            string minString;
            if (hour == 0)
            {
                hour = 12;
                AMorPM = "AM";
            }
            else if (hour >= 1 && hour <= 11)
            {
                AMorPM = "AM";
            }
            else if (hour == 12)
            {
                AMorPM = "PM";
            }
            else if (hour >= 13 && hour <= 23)
            {
                hour = hour - 12;
                AMorPM = "PM";
            }

            if (min < 10)
            {
                minString = "0" + min;
            }
            else
            {
                minString = min.ToString();
            }

            return hour + ":" + minString + " " + AMorPM;
        }
    }
}
