using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        //COmpletely broken and doesn't orwork.
        static void Main(string[] args)
        {
            int[] attempts = new int[] {319, 680, 180, 690, 129, 620, 762, 689, 762, 318, 368, 710, 720, 710, 629, 168, 160, 689, 716, 731, 736, 729, 316, 729, 729, 710, 769, 290, 719, 680, 318, 389, 162, 289, 162, 718, 729, 319, 790, 680, 890, 362, 319, 760, 316, 729, 380, 319, 728, 716 };
            //int tryout = 99;
            int tryout = 73162890 - 90;
            string attemptString = "0";

            int tryoutDigitLocation(string tryoutString, int tryoutDigitLength, string attempt, int tryoutDigit)
            {
                for (int iii = 0; iii < tryoutDigitLength; iii++)
                {
                    if (attempt.Substring(tryoutDigit, 1) == tryoutString.Substring(iii, 1)) 
                    {
                        return iii;
                    }
                }
                return -1; //won't happen i think...?
            }

            bool checkIfContains = true;
            while (true)
            {
                tryout++;
                string tryoutString = Convert.ToString(tryout);
                int tryoutDigitLength = Convert.ToString(tryout).Length;
                string[] tryoutDigit = new string[100];
                for (int i = 0; i < 50; i++)
                {

                    attemptString = Convert.ToString(attempts[i]);
                    int[] attemptDigit = new int[] { Convert.ToInt32(attemptString.Substring(0, 1)), Convert.ToInt32(attemptString.Substring(1, 1)), Convert.ToInt32(attemptString.Substring(2, 1)) };
                    //for (int ii = 0; ii < tryoutDigitLength; ii++)
                    //{
                    //    tryoutDigit[ii] = Convert.ToString(tryout).Substring(ii, 1);
                    //}
                    for (int ii = 0; ii < 3; ii++)
                    {
                        if (tryoutString.Contains(Convert.ToString(attemptDigit[ii])))
                        {
                            checkIfContains = true;
                        }
                        else
                        {
                            checkIfContains = false;
                            break;
                        }
                    }
                    if (!checkIfContains)
                    {
                        Console.WriteLine("br");
                        Console.Read();
                        break;
                    }
                }
                if (checkIfContains == true)
                {
                    int digit0Location = tryoutDigitLocation(tryoutString, tryoutDigitLength, attemptString, 0);
                    int digit1Location = tryoutDigitLocation(tryoutString, tryoutDigitLength, attemptString, 1);
                    int digit2Location = tryoutDigitLocation(tryoutString, tryoutDigitLength, attemptString, 2);
                    if (digit0Location < digit1Location && digit1Location < digit2Location)
                    {
                        Console.WriteLine("the answer is " + tryoutString);
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("failed " + tryoutString);
                    break;
                }
            }
        }
    }


}
