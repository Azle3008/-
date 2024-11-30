using System;

namespace ifelse
{
    class program
    {
        static void Main(String[] args)
        {
            int firstHour = int.Parse(Console.ReadLine()); //время начала экзамена
            int firstMin = int.Parse(Console.ReadLine());

            int secondHour = int.Parse(Console.ReadLine()); //время прихода студента
            int secondMin = int.Parse(Console.ReadLine());

            if(firstHour > secondHour && firstMin > secondMin || firstHour > secondHour && firstMin < secondMin)
            {
                int value = firstHour - secondHour;
                int VALUE = firstMin - secondMin;
                Console.WriteLine($"Студент пришёл рано на {value}:{VALUE}");
            }
            else
            {
                if(firstHour < secondHour || firstHour == secondHour && firstMin < secondMin)
                {
                    int value = secondHour - firstHour;
                    int VALUE = secondMin - firstMin;
                    if(VALUE < 0)
                    {
                        VALUE = firstMin - secondMin;
                    }
                    Console.WriteLine($"Студент опоздал на {value} минут и {VALUE} секунд по полной программе!");
                }
                else
                {
                    if (firstHour == secondHour && firstMin == secondMin)
                    {
                        Console.WriteLine("Студент пришёл вовремя");
                    }
                }
            }
        }
    }
}