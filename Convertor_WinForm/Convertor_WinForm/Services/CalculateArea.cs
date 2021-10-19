using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertor_WinForm.Utilities;

namespace Convertor_WinForm.Services
{
    class CalculateArea
    {
        public static double InchToCm2(string numberStr)
        {
            double result = numberStr.ToDouble() * 6.45;
            return result;
        }

        public static double CmToInch2(string numberStr)
        {
            double result = numberStr.ToDouble() / 6.45;
            return result;
        }
        public static double YardToMeter2(string numberStr)
        {
            double result = numberStr.ToDouble() / 1.19;
            return result;
        }
        public static double MeterToYard2(string numberStr)
        {
            double result = numberStr.ToDouble() * 1.19;
            return result;
        }
        public static double MileToKm2(string numberStr)
        {
            double result = numberStr.ToDouble() * 2.59;
            return result;
        }
        public static double KmToMile2(string numberStr)
        {
            double result = numberStr.ToDouble() / 2.59;
            return result;
        }
    }
}
