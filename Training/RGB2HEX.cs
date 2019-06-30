using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class RGB2HEX
    {
        static string HLetter(string val)
        {
            switch (val)
            {
                case "10":
                    return val = "A";
                case "11":
                    return val = "B";
                case "12":
                    return val = "C";
                case "13":
                    return val = "D";
                case "14":
                    return val = "E";
                case "15":
                    return val = "F";
                default:
                    return val;
            }
        }
        static string CalcHex(int val)
        {
            string hex1 = (val / 16).ToString();
            string hex2 = (val % 16).ToString();
            return HLetter(hex1) + HLetter(hex2);
        }
        public static string TurnToHex(int[] RGBVal)
        {
            string hex1 = CalcHex(RGBVal[0]);
            string hex2 = CalcHex(RGBVal[1]);
            string hex3 = CalcHex(RGBVal[2]);
            return hex1+hex2+hex3;
        }
    }
}
