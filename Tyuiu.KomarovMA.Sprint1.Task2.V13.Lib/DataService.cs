using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KomarovMA.Sprint1.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int num)
        {
            return num / 1.609;
        }
    }
}