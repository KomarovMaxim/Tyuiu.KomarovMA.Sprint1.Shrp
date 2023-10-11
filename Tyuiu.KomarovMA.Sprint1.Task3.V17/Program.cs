using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint1.Task3.V17.Lib;
namespace Tyuiu.KomarovMA.Sprint1.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Введите число num");
            num = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Комаров М.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Александрович | СМАРТб 23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех цифр  *");
            Console.WriteLine("* из дробной части заданного вещественного числа цифра 0                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ZeroCheck(num));



            Console.ReadKey();
        }
    }
}