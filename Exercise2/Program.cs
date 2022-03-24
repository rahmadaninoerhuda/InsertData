using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Koneksi
{
    class Program//program
    {
        static void Main(string[] args)
        {
            new Program().InsertData2();
        }

        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=Peyewaan;User id=sa;Password=dedekgemes123")
                )
            {
                con.Open();
                Console.WriteLine("Berhasi Terhubung ke Database:");
            }
        }

        public void CreateTable()//Membuat Table
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=Peyewaan;Integrated security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Stan (Ukuran char(2) not null primary key," +
                    "HargaPerTahun int, HargaPerbulan int)", con);//Command memmbuat atribut tabel
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel suksses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void CreateTable2()//Membuat Table
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=Peyewaan;Integrated security = TRUE");
                con.Open();
                
                SqlCommand cm = new SqlCommand("create table Penyewa (ID char(10) not null primary key," +
                                    "Nama Varchar (50), Alamat varchar(255), Ukuran char (2), Jenis_Sewa char (10), Harga int)", con);
                
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel suksses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=Peyewaan;Integrated security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("Insert into Stan (Ukuran, HargaPertahun, HargaPerbulan) " +
                    "values ('7m', '12000000', '2000000')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData2()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-I5CF3Q9T;" +
                "database=Peyewaan;Integrated security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("Insert into Penyewa (ID, Nama, Alamat, Ukuran, Jenis_Sewa, Harga) " +
                    "values ('237591', 'Bagas', 'Seturan', '7m', 'Pertahun', '12000000' )," +
                    "       ('839921', 'Kiki', 'Wates', '7m', 'Perbulan', '2000000' )", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

    }
}


