using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları


            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDeğişkenler

            //string
            //Degisken_türü degişken_adı

            //string name;
            //name = "Ali";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Baş";
            //customerPhone = "+90 542 080 12 11";
            //customerEmail = "alibas611@gmail.com";
            //district = "Akçaabat";
            //city = "Trabzon";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 546 236 23 64";
            //customerEmail = "aysegulkaya@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");




            #endregion

            #region IntDeğişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice+ " TL");
            Console.WriteLine("----Kola: " + cokePrice + " TL");
            Console.WriteLine("----Su: " + waterPrice + " TL");
            Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            totalHamburgerPrice = hamburgerCount + hamburgerPrice;
            totalCokePrice = cokeCount + cokeCount;
            totalWaterPrice = waterCount + waterCount;
            totalFriesPrice = friesCount + friesPrice;
            totalPizzaPrice = pizzaCount + pizzaPrice;
            totalLemonadePrice = lemonadePrice + lemonadePrice;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Cola tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata tutarı: " + totalLemonadePrice + " TL");
            

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalHamburgerPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine(totalPrice);

            #endregion


            Console.Read();
        }
    }
}
