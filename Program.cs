using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** C# Veri tabanlıürün- Kategori Bilgi Sistemi *******");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.WriteLine("Lütfen Girmek İstediğiniz numarayı seçiniz");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F0VL6BP\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory" , connection);
            SqlDataAdapter adapter = new SqlDataAdapter( command );

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach ( var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
