using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogueClockTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type corresponding number to select time format: ");
            PrintEnumValues();
            TimeFormatEnum format = ReadFormat();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Input Hour value: (ex. \"4\")");
                int Hour = ReadHour(format);

                Console.WriteLine("Input Minute value: (ex. \"45\")");
                int Minute = ReadMinute();

                AnalogueClock clock = new AnalogueClock(Hour, Minute, format);
                Console.WriteLine("Lesser angle in degrees between hours arrow and minutes arrow are: " + clock.lesserAngle);
                Console.WriteLine("Try another one?: (Y/N)");
                flag = Console.ReadLine().ToLower() == "n" ? false : true;
            }
        }

        #region Utilities
        /// <summary>
        /// ReadFormat method used to get an input for Enum value, prevents the user from choosing values out of the bounds or typing
        /// banned characters / strings
        /// </summary>
        /// <returns>TimeFormatEnum value</returns>
        public static TimeFormatEnum ReadFormat()
        {
            TimeFormatEnum format;
            while (true)
            {
                string input = Console.ReadLine();
                if (Enum.TryParse(input, out format) && input.All(char.IsNumber) && Enum.IsDefined(typeof(TimeFormatEnum), format))
                    return format;
                else
                    Console.WriteLine("Please type in correct value! (ex. \"1\")");
            }
        }
        /// <summary>
        /// ReadHour method used to get an input for Hour value, prevents the user from typing hours out of bounds or
        /// typing any other character besides number
        /// </summary>
        /// <param name="format">format which sets the bounds between 12 hour clock and 24 hour clock</param>
        /// <returns>returns user's input hour</returns>
        public static int ReadHour(TimeFormatEnum format)
        {
            int hour;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out hour) && input.All(char.IsNumber))

                    if (format == TimeFormatEnum.RegularTime && (hour > 1 && hour < 12))
                        return hour;

                    else if (format == TimeFormatEnum.MilitaryTime && (hour > 0 && hour < 24))
                        return hour;
                    else Console.WriteLine("Please type in correct value! (ex. \"4\")");
                else
                    Console.WriteLine("Please type in correct value! (ex. \"4\")");
            }
            return hour;
        }
        /// <summary>
        /// ReadHour method used to get an input for Minute value, prevents the user from typing minutes out of bounds or
        /// typing any other character besides number
        /// </summary>
        /// <returns></returns>
        public static int ReadMinute()
        {
            int minute;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out minute) && input.All(char.IsNumber) && (minute >= 0 && minute < 60))
                    return minute;
                else
                    Console.WriteLine("Please type in correct value! (ex. \"45\")");
            }
            return minute;
        }
        /// <summary>
        /// Prints the current selection of Enum values
        /// </summary>
        public static void PrintEnumValues()
        {
            foreach (TimeFormatEnum val in Enum.GetValues(typeof(TimeFormatEnum)))
            {
                Console.WriteLine((int)val + " - " + val);
            }
        }
        #endregion
    }
}
