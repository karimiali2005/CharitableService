using System;
using System.Linq;
using System.Threading;

namespace AntelopeSurvey.UI.Classes
{
    public static class ExtensionMethod
    {
        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }



        public static string ToLatinNumber(this string input)
        {
            string[] persian = new string[10] { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            if (input != null)
            {
                for (int j = 0; j < persian.Length; j++)
                    input = input.Replace(persian[j], j.ToString());

                return input;
            }
            else
            {
                return "";
            }

        }

    }
}