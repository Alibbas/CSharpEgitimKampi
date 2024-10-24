using Microsoft.Win32;
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

            #region Metotlar
            //()Mor renk küp metot olduğunu belirtir
            //Geriye değer döndüren ve değer döndürmeyen


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Baş");
            //    Console.WriteLine("Osman Baş");
            //    Console.WriteLine("Salih Baş");
            //    Console.WriteLine("Selman Baş");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 1;
            //    Console.WriteLine(x + y);
            //}

            //Sum();

            #endregion

            #region GeriyeDeğerDöndürmeyenStringParametreliMetotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Ali");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name+" "+surName);
            //}

            //CustomerCard("ali", "baş");

            #endregion

            #region GeriyeDeğerDöndürmeyenİntParametreliMetotlar

            //void Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine("Toplam: " + result);
            //}

            //Sum(1, 2);


            #endregion

            #region GeriyeDeğerDöndürenMetotlar

            //string CustomerName()
            //{
            //    return "Ali BAŞ";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Baş";

            //    return name + " " + surName;
            //}

            //StudentCard();

            #endregion

            #region GeriyeDeğerDöndürenStringParametreliMetotlar

            //string CountryCard(string countryName, string capital, string flagColour)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColour;

            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.WriteLine("Ülke adı giriniz: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Başkent adı giriniz: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Bayrak rengi giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region GeriyeDeğerDöndürenİntParametreliMetotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1+number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(2313, 525));


            #endregion

            #region Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " adlı Öğrenci " + result + " ortalama notuyla sınavı geçti";
                }
                else
                {
                    return "Öğrenci başarısız oldu";
                }
            }

            Console.WriteLine(ExamResult("Ali", 50, 24, 89));
            
            #endregion


            Console.Read();
        }
    }
}
