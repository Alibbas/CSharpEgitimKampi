using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net(C# programlama dilinde sql dilini kullanmamızı sağlayan bir çerçeve)

            Console.WriteLine("******* C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *******");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------");
            Console.WriteLine("1-Kagetoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen numara seçiniz: ");
            Console.WriteLine("----------------------------");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KQKH4A0;initial Catalog=EgitimKampiDb;integrated security=true");
            //1) bağlantı kaynağı adı 2) veri tabanı adı 3) bağlantının güvenli olduğunu belirtmek için yazılıyor
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //burada sql sorgusu yazıyoruz
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //C# tarafında oluşturduğumuz sorguyu sql veri tabanı arasında bir köprü görevi görecek sınıf
            DataTable table = new DataTable();
            //Verileri geçici belleğe almamızı sağlayacak
            adapter.Fill(table);
            connection.Close();
            //bağlantı kapatma

            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }






            Console.Read();
        }
    }
}
