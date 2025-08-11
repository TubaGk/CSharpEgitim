using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //1:Değişken Türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon,Dizi


            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 1, 2, 8, 156, 785, 4, 23, 77,99,25,65,147};

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //int[] numbers = { 1, 2, 8, 156, 785, 4, 23, 77, 99, 25, 65, 147 };
            //int sum = 0;

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine(sum);


            //List <int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("************* Sınav Uygulaması ***********");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Öğrenci Sayısı
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Sınıfta Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            //öğrenci Not ve Ortalama 
            string[] studentNames =new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için üç sınav girişi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value =double.Parse(Console.ReadLine());
                    totalExamResult+= value;

                }
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
 
            }

            //Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortlaması {studentExamAvg[i]}");


                //Öğrencinin ortalamasına göre geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");

                }
                Console.WriteLine("----------------------------------------------------");
            }
           





            #endregion
        }
    }
}
