using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    public static class RomanNumeral
    {
        public static int ConvertFromRN(string rn)
        {
            int val = 0;
            for (int i = 0; i < rn.Length; i++)
            {
                string thisNumeral = rn[i].ToString().ToUpper();
                switch (thisNumeral)
                {
                    case "I":
                        if (i < rn.Length-1)
                        {
                            string nextNumeral = rn[i+1].ToString().ToUpper();
                            switch (nextNumeral)
                            {
                                case "V":
                                    val += 4;
                                    i++;
                                    break;
                                case "X":
                                    val += 9;
                                    i++;
                                    break;
                                default:
                                    val += 1;
                                    break;
                            }
                        }
                        else
                        {
                            val += 1;
                        }
                        break;
                    case "V":
                        val += 5;
                        break;
                    case "X":
                        if (i < rn.Length - 1)
                        {
                            string nextNumeral = rn[i + 1].ToString().ToUpper();
                            switch (nextNumeral)
                            {
                                case "L":
                                    val += 40;
                                    i++;
                                    break;
                                case "C":
                                    val += 90;
                                    i++;
                                    break;
                                default:
                                    val += 10;
                                    break;
                            }
                        }
                        else
                        {
                            val += 10;
                        }
                        break;
                    case "L":
                        val += 50;
                        break;
                    case "C":
                        if (i < rn.Length - 1)
                        {
                            string nextNumeral = rn[i + 1].ToString().ToUpper();
                            switch (nextNumeral)
                            {
                                case "M":
                                    val += 900;
                                    i++;
                                    break;
                                default:
                                    val += 100;
                                    break;
                            }
                        }
                        else
                        {
                            val += 100;
                        }
                        break;
                    case "D":
                        val += 500;
                        break;
                    case "M":
                        val += 1000;
                        break;
                    default:
                        val = 0;
                        break;
                }
            }

            return val;
        }

        public static string ConvertToRN(int num)
        {
            string rn = string.Empty;

            int multiplier = 1;
            int remainder = 0;
            int divisor = 10;
            var stack = new Stack<int>();

            do
            {
                remainder = num % divisor;
                num = num / divisor;
                int val = remainder * multiplier;
                multiplier *= 10;
                stack.Push(val);

            } while (num > 0);

            while (stack.Count > 0)
            {
                rn += ConvertDigit(stack.Pop());
            }

            return rn;
        }

        private static string ConvertDigit(int num)
        {
            string rn = string.Empty;

            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    for (int i = 0; i < num; i++)
                    {
                        rn += "I";
                    }
                    break;
                case 4:
                    rn = "IV";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    rn = "V";
                    for (int i = 0; i < num-5; i++)
                    {
                        rn += "I";
                    }
                    break;
                case 9:
                    rn = "IX";
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                    rn = "X";
                    for (int i = 0; i < num - 10; i++)
                    {
                        rn += "I";
                    }
                    break; 
                case 20:
                    rn = "XX";
                    break;
                case 30:
                    rn = "XXX";
                    break;
                case 40:
                    rn = "XL";
                    break;
                case 50:
                    rn = "L";
                    break;
                case 60:
                    rn = "LX";
                    break;
                case 70:
                    rn = "LXX";
                    break;
                case 80:
                    rn = "LXXX";
                    break;
                case 90:
                    rn = "XC";
                    break;
                case 100:
                case 200:
                case 300:
                    var hundreds = num / 100;
                    for (int i = 0; i < hundreds; i++)
                    {
                        rn += "C";
                    }
                    break;
                case 400:
                    rn = "CD";
                    break;
                case 500:
                case 600:
                case 700:
                case 800:
                    rn = "D";
                    var fiveHundreds = num / 100;
                    for (int i = 0; i < fiveHundreds-5; i++)
                    {
                        rn += "C";
                    }
                    break;
                case 900:
                    rn = "CM";
                    break;
                case 1000:
                    rn = "M";
                    break; 
                default:
                    break;
            }

            return rn;
        }
    }
}
