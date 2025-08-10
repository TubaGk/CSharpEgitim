using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            ////DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //String[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Mor";

            ////Console.WriteLine(colors);
            //String[] cities = new String[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            ////Console.WriteLine(cities[4]);
            ///
            //int[] number = new int[10];
            //number[0] = 1;
            //number[1] = 2;
            //number[7] = 748;
            //Console.WriteLine(number[7]);

            //String[] cities = { "roma", "prag", "atina" };
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki tüm Elemanları Listeleme

            //String[] colors = { "kırmızı", "mavi", "beyaz", "sarı", "turuncu", "yeşil", "mor", "pembe" };

            //for (int i = 0; i < colors.Length; i++) {
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] chars = { 'a', 'b', 'c', '*', '/', '-' };
            //Console.WriteLine(chars);

            //int[] myArray = { 47, 85, 95, 21, 41, 635, 999, 86, 100 };
            //int maxNumber=myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //int[] myArray = { 47, 85, 95, 21, 41, 635, 999, 86, 100 };
            //Array.Sort(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}
            #endregion

            #region Dizi Metotlar

            //String[] customers = { "Ali", "Ayşe", "Buse", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers,"Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+numbers.Max()+" Dizinin En Küçük Elemanı: "+numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //String[] Cities = new String[5];
            //for (int i = 0; i < Cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehir Giriniz: ");
            //    Cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < Cities.Length; i++)
            //{
            //    Console.WriteLine(i + ": " + Cities[i]);
            //}

            //int[] numbers = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 11,12,13, 22, 33, 44, 55,56,57, 66, 77, 87,88,89, 99 };
            
            //Console.WriteLine("----Çiftler---------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    { Console.WriteLine(numbers[i]); }
            //}
            //Console.WriteLine("----------Tekler--------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    { Console.WriteLine(numbers[i]); }
            //}
            
            #endregion
        }
    }
}
