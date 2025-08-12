using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-> Creat - Read - Update - Delete 
            Console.WriteLine("***** Menu Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;initial Catalog =CsharpEgitimDb;integrated Security =true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("kategori başarıyla Eklendi");

            #endregion

            #region Ürürn Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;initial Catalog =CsharpEgitimDb;integrated Security =true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("ürürn Eklemesi Başarılı ");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;initial Catalog =CsharpEgitimDb;integrated Security =true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);


            //foreach (DataRow row in dt.Rows) 
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();




            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;initial Catalog =CsharpEgitimDb;integrated Security =true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete  From TblProduct Where ProductId =@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme İşlemi Başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek  Ürün Fiyatı: ");
            //decimal productPrice =decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;initial Catalog =CsharpEgitimDb;integrated Security =true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName =@productName,Productprice =@productPrice where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!!");

            #endregion

            Console.Read();

        }
    }
}
