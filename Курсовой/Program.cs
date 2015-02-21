using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовой
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> Departures = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();
            Dictionary<string, Dictionary<string, List<string>>> Arrivals = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string, List<string>> Weekdays = new Dictionary<string, List<string>>();
            List<string> Time = new List<string>();//Запилить время в численном формате
            //Time.Add("8:30");
            //Time.Add("17:10");
            //Weekdays.Add("Суббота", Time);
            //Arrivals.Add("Учалы", Weekdays);
            //Departures.Add("Челябинск", Arrivals);
            Input.AddWeek(Weekdays);
            Input.AddTime(Time);
            //Input.Sort(Time);
            foreach (KeyValuePair<string, List<string>> kvp in Weekdays)
            {
                Console.WriteLine("{0}:",kvp.Key);
                foreach (string moment in Time)
                {
                    Console.WriteLine(moment);
                }

            }
            Console.ReadKey();
        }
    }
}
