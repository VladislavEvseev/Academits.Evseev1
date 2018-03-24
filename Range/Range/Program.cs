using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Range r1 = new Range(0, 18);

            double numberInRange = 8;
            r1.IsInside(numberInRange);

            Range r2 = new Range(1, 19);

            if (r1.GetGeneral(r2) != null)
            {
                Range r3;
                r3 = r1.GetGeneral(r2);
                Console.WriteLine("Главный интервал: {0} {1}", r3.From, r3.To);
            }
            else
            {
                Console.WriteLine("Null");
            }

            Range[] arrayResult;

            arrayResult = r1.GetConcatenationOfIntervals(r2);
            Console.WriteLine("Добавочные интервалы");

            for (int i = 0; i < arrayResult.Length; i++)
            {
                Console.WriteLine("Начало: {0} Конец {1} ", arrayResult[i].From, arrayResult[i].To);
            }

            arrayResult = r1.GetDifferentIntervals(r2);
            Console.WriteLine("Разница массивов");

            r1.GetDifferentIntervals(r2);
            for (int i = 0; i < arrayResult.Length; i++)
            {
                Console.WriteLine("Начало: {0} Конец {1} ", arrayResult[i].From, arrayResult[i].To);
            }
            Console.ReadKey();
        }
    }
}