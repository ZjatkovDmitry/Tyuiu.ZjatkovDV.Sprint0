using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZjatkovDV.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ZjatkovDV.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по скрипту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("* Значение элементов массива #1                                           *");
            Console.Write("* ");

            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("* Значение элементов массива #2                                           *");
            Console.Write("* ");

            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.Write('\n');

            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine(new string('*', 75));

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("* Сумма элементов массива равна:                                          *");
                Console.Write("* ");

                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }

                Console.Write('\n');
                Console.WriteLine(new string('*', 75));
            }
            else
            {
                Console.WriteLine("* Ошибка! Исходные массивы имеют разное количество элементов              *");
                Console.WriteLine(new string('*', 75));
            }

            Console.ReadKey();
        }
    }
}
