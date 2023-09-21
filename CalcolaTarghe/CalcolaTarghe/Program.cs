using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolaTarghe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targa, pt1, pt2, pt3;
            double valore1 = 0;
            double valore2 = 0, finaleLettere = 0, somma = 0;
            string lettere;
            int posizione = 0;

            char[] lettereAlfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            Console.Write("Inserisci la targa: ");
            targa = Console.ReadLine();
            pt1 = targa.Substring(2, 3);
            pt2 = targa.Substring(0, 2);
            pt3 = targa.Substring(5);
            lettere = pt2 + pt3;
            for (int i = 0; i < pt1.Length; i++)
            {
                valore1 += Convert.ToInt32(pt1[i]) * Math.Pow(10, i);
            }
            for (int i = 0; i < lettere.Length; i++)
            {
                posizione = Array.IndexOf(lettereAlfabeto, lettere[i]);
                valore2 += posizione * Math.Pow(26, i) * Math.Pow(10, 3);
                finaleLettere = valore2 + posizione;
            }
            somma = finaleLettere + valore1;
            Console.WriteLine(valore1);
            Console.WriteLine(finaleLettere);
            Console.WriteLine($"Il numero della targa è: {somma}");
            Console.ReadLine();
        }
    }
}
