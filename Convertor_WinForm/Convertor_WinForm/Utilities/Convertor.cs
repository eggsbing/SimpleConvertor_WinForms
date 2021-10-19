using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_WinForm.Utilities
{
    public static class Convertor
    {
        public static int ToInt(this string numberStr)
        {
            int number = Convert.ToInt32(numberStr);
            return number;
        }

        public static double ToDouble(this string numberStr)
        {
            double number = Convert.ToDouble(numberStr);
            return number;
        }
    }
}
