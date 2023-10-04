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
    }
}
