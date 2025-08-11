using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer ---> Listele,Ekle,Sil,Güncelle
            //Void
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali");
            //    Console.WriteLine("Veli");
            //    Console.WriteLine("Atıl");
            //    Console.WriteLine("Aliç");
            //    Console.WriteLine("Halil");
            //}

            //CustomerList();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string name) 
            //{ 
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Ali");



            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Mert", "Yaz");
            //CustomerCard("Ali", "Yıldırım");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result =number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //String StudentCard() {
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname; 
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //String CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo  = "Ülke Bilgileri:  " +countryName+" "+capital+" "+flagColor;
            //    return cardInfo;
            //}
            ////Console.WriteLine(CountryCard("Türkiye", "Ankara", "KırmızıBeyaz"));
            //string x, y, z;
            //Console.Write("ülke Adı Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("BAşkent Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengi Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int n1,int n2) {
            //    int result = n1 + n2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(10,20));
            //Console.WriteLine(Sum(75,75));
            //Console.WriteLine(Sum(8,9));

            #endregion

            #region örnek Uygulama

            //String ExamResult(String student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return "Öğrenci Sınavı Geçti";
            //    }
            //    else
            //    {
            //        return "Öğrenci başarısız";
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 50, 40, 20));
            //Console.WriteLine(ExamResult("Ayşe", 100, 40, 70));


            #endregion



        }
    }
}
