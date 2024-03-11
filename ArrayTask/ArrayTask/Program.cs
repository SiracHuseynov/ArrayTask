using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.ci tapsirig
            //1. Array'dəki ən kiçik elementi tapıb ekrana yazdırın.
            //int[] ededler = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int min = ededler[0];

            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    if (min > ededler[i])
            //    {
            //        min = ededler[i];
            //    }
            //}

            //Console.WriteLine(min);
            #endregion

            #region 2.ci tapsirig
            //2. Array'in içərisindəki sözləri tərsinə çevirən bir alqoritm yazın. 

            //string[] adlar = { "sirac", "aydan", "ayten", "sabina", "lale" };
            //for (int i = adlar.Length - 1; i >= 0; i--)
            //{
            //    for (int j = adlar[i].Length - 1; j >= 0; j--)
            //    {
            //        Console.Write(adlar[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 3.cu tapsirig
            //3. Array'in içərisindəki sözlərin sırasını tərsinə çevirən bir alqoritm yazın.
            //string[] adlar = { "sirac", "nezrin", "leyla", "aysu" };

            //for (int i = adlar.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(adlar[i]);
            //}
            #endregion

            #region 4.cu tapsirig
            //4. Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin.
            //Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.

            //int[] ededler = { 1, 2, 3, -4, 5, 6, -7, 8, 9 };
            //int[] ededlerString = new int[9];

            //for (int i = 0; i <= ededler.Length - 1; i++)
            //{
            //    if (ededler[i] < 0)
            //    {
            //        ededler[i] *= -1;
            //    }
            //}

            //for (int k = 0; k < ededler.Length; k++)
            //{
            //    ededlerString[k] = ededler[k];
            //}

            //for (int j = ededler.Length - 1; j >= 0; j--)
            //{
            //    Console.WriteLine(ededler[j]);
            //}

            #endregion

            #region 5.ci tapsiriq
            //5. Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
            //Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

            //int[] ededler = { 1, -2, 3, -4, 5, 6, -7, 8, 9 };

            //string result;

            //for (int i = 0; i <= ededler.Length; i++)
            //{
            //    result = Convert.ToString(ededler[i]);
            //    Console.WriteLine(result);
            //}

            #endregion





        }
    }
}
