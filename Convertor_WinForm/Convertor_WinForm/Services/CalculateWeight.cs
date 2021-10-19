using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertor_WinForm.Utilities;

namespace Convertor_WinForm.Services
{
    class CalculateWeight
    {
        public static double GrToKg(string numberStr)
        {
            double result = numberStr.ToDouble() / 1000;
            return result;
        }
        public static double KgToGr(string numberStr)
        {
            double result = numberStr.ToDouble() * 1000;
            return result;
        }
        public static double OunceToGr(string numberStr)
        {
            double result = numberStr.ToDouble() * 28.35;
            return result;
        }
        public static double GrToOunce(string numberStr)
        {
            double result = numberStr.ToDouble() / 28.35;
            return result;
        }
        public static double PoundToKg(string numberStr)
        {
            double result = numberStr.ToDouble() / 2.20;
            return result;
        }
        public static double KgToPound(string numberStr)
        {
            double result = numberStr.ToDouble() * 2.20;
            return result;
        }
    }
}
