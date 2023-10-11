using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMA.Sprint1.V13.Lib;
namespace Tyuiu.KomarovMA.Sprint1.V13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число num");
            int num;
            num = int.Parse(Console.ReadLine());

            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Комаров М.А. | СМАРТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода вывода в консольных приложенияхФайл             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Александрович | СМАРТб 23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ConvertMilesToKm(num));



            Console.ReadKey();
        }
    }
}