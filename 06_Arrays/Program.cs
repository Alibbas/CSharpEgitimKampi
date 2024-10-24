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
            #region TemelDiziÖrnekleri

            //string[] colors = new string[4];
            //colors[0] = "mavi";
            //colors[1] = "bordo";
            //colors[2] = "yeşil";
            //colors[3] = "siyah";


            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 12;
            //numbers[1] = 53;
            //numbers[2] = 44;
            //numbers[6] = 59;
            //numbers[5] = 2325;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "İstanbul", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region DizidekiTümElemanlarıListeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{ 
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 2, 123, 132, 53453, 45345, 213, 231, 19 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'd', '6', '*' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 42, 23, 754, 835, 8709, 5465, 3456, 12312, 123 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}    

            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Selman", "Salih", "Osman" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 23, 123, 125, 57, 867, 345, 987 };
            ////diziyi küçükten büyüğe doğru sıralama sort
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region DiziMetotlar

            //string[] customers = { "ali", "buse", "ayşegül", "tuğçe", "çınar", "kemal" };
            //int index = Array.IndexOf(customers, "tuğçe");
            //Console.WriteLine(index);

            //int[] numbers = { 42, 63, 75, 854, 934, 934, 0, 1, -1 };
            //Console.WriteLine("Dizinin en küçük elemanı:"+ numbers.Min()+"en büyük eleman: "+ numbers.Max());




            #endregion

            #region KullanıcıdanDeğerAlma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    //çift tırnak bütünlüğünü bozmamak için eleman kullanımı için $ kullaınlır.
            //    Console.WriteLine($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 50, 40 };
            //int sum = 0;
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //int[] numbers = { 13, 52,63, 84, 55, 436, 3457, 128, 569, 6786730 };
            
            //Console.WriteLine("Çift sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine();

            //Console.WriteLine("Tek sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
