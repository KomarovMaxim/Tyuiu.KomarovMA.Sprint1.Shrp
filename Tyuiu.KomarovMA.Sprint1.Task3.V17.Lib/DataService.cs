using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KomarovMA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double num)
        {
            int x = (int)(num * 1000);
            return (x % 10 == 0 || x % 100 / 10 == 0 || x % 1000 / 100 == 0);
        }
    }
}