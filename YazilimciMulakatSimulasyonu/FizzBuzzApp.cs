using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciMulakatSimulasyonu
{
    // 10. Soru FizzBuzz oyunu
    // Belirli bir sayı aralığındaki sayılar ekrana yazdırırken,
    // eğer sayı 3'ün katı ise 'Fizz'.
    // eğer sayı 5'im katı ise 'Buzz'.
    // her ikisinin katı ise 'FizzBuzz' yazdıracağız.

    // Cevap:
    public class FizzBuzzApp
    {
        // kullanıcıdan alınan başlangıc ve bitiş sayılarına göre ekrana
        // Fizz, Buzz veya FizzBuzz yazdıran app.
        public string FizzBuzz(int beginning, int finish)
        {
            string result = "";
            for (int i = beginning; i <= finish; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    result += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    result += "Buzz ";
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }

            return result;
        }
    }
}
