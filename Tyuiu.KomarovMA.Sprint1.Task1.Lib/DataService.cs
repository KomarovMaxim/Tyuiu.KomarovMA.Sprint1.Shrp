using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KomarovMA.Sprint1.Task1.Lib
{
    public class DataService : ISprint1Task1V9
    {
        public double Calculate(double a, double b)
        {
            return (1 + 3 * a)/(4*b);
        }
    }
}