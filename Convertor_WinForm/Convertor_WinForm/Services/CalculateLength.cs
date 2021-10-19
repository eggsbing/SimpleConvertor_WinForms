using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertor_WinForm.Utilities;

namespace Convertor_WinForm.Services
{
    class CalculateLength
    {
        public static double CmToInch(string numberStr)
        {
            double result = numberStr.ToDouble() / 2.54;
            return result;
        }

        public static double InchToCm(string numberStr)
        {
            double result = numberStr.ToDouble() * 2.54;
            return result;
        }

        public static double KmToMile(string numberStr)
        {
            double result = numberStr.ToDouble() * 1.6;
            return result;
        }

        public static double MeterToYard(string numberStr)
        {
            double result = numberStr.ToDouble() * 1.9;
            return result;
        }

        public static double MileToKm(string numberStr)
        {
            double result = numberStr.ToDouble() / 1.6;
            return result;
        }

        public static double YardToMeter(string numberStr)
        {
            double result = numberStr.ToDouble() / 1.9;
            return result;
        }
    }
}
