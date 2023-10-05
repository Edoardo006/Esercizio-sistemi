using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dp = new int[4];

            for (int i = 0; i < dp.Length; i++)
            {
                Console.WriteLine($"Inserire la {i + 1}° otteto");
                dp[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool[] bn = Convert_dp_to_binario(dp);

            for (int i = 0; i < bn.Length; i++)
            {
                Console.Write(Convert.ToInt32(bn[i]));
            }
            Console.WriteLine();
            Console.WriteLine(Convert_dp_to_intero(dp));
            Console.WriteLine();
            Console.WriteLine(Convert_binario_to_int(bn));
            Console.WriteLine();
            Console.WriteLine(Convert_binario_to_decimale(bn));
            Console.ReadLine();
            Console.ReadLine();
        }
        static bool[] Convert_dp_to_binario(int[] dp)
        {
            int z = 0;
            bool[] bn = new bool[32];

            for (int i = 0; i < dp.Length; i++)
            {
                do
                {
                    if (dp[i] % 2 == 0)
                        bn[z] = false;
                    else
                        bn[z] = true;

                    dp[i] = dp[i] / 2;
                    z++;
                } while (dp[i] > 0);
            }
            return bn;
        }
        static int Convert_dp_to_intero(int[] dp)
        {
            int intero = 0;
            int potenza = 0;
            for (int i = dp.Length - 1; i >= 0; i--)
            {
                intero += dp[i] * (int)Math.Pow(256, potenza);
                potenza++;
            }
            return intero;
        }
        static int Convert_binario_to_int(bool[] bn)
        {
            int intero = 0;
            int potenza = 0;
            for (int i = 0; i < bn.Length; i++)
            {
                intero += (int)(Convert.ToInt32(bn[i]) * Math.Pow(2, potenza));

            }
            return intero;
        }
        static int Convert_binario_to_decimale(bool[] bn)
        {
            int d = 0;
            for (int i = bn.Length - 1; i >= 0; i--)
            {
                if (bn[i])
                {
                    d += (int)Math.Pow(2, bn.Length - 1 - i);
                }
            }
            return d;
        }
    }
}
