using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convertor_WinForm.Utilities;

namespace Convertor_WinForm.Services
{
    class CalculateVolume
    {
        public static double LitreToPint(string numberStr)
        {
            double result = numberStr.ToDouble() / 1.75;
            return result;
        }
        public static double PintToLitre(string numberStr)
        {
            double result = numberStr.ToDouble() * 1.75;
            return result;
        }
        public static double LitreToGallon(string numberStr)
        {
            double result = numberStr.ToDouble() / 3.78;
            return result;
        }
        public static double GallonToLitre(string numberStr)
        {
            double result = numberStr.ToDouble() * 3.87;
            return result;
        }
    }
}
