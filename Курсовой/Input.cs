using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Курсовой
{
    class Input
    {
        public static List<string> Time;
        public Dictionary<string, List<string>> Weekday;
        public Dictionary<string, Dictionary<string, List<string>>> Arrival;
        static public string StartKey(string Start)
        {
            return Start;
        }
        static public string DestinationKey(string Destination)
        {
            return Destination;
        }
        static public void AddWeek(Dictionary<string, List<string>>Weekdays)
        {
            Weekdays.Add("Понедельник", Time);//Запилить раздельную запись для каждого
            Weekdays.Add("Вторник", Time);
            Weekdays.Add("Среда", Time);
            Weekdays.Add("Четверг", Time);
            Weekdays.Add("Пятница", Time);
            Weekdays.Add("Суббота", Time);
            Weekdays.Add("Воскресенье", Time);
        }
        static public void AddTime(List<string>Time)
        {
            Time.Add(Console.ReadLine());
        }
        static public void Sort(List<string> Time)
        {
            Time.Sort();//Запилить сортировку для числовой записи времени
        }
    }
}
