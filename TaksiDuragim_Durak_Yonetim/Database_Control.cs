using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace TaksiDuragim_Durak_Yonetim
{
    internal class Database_Control
    {
      
            // Veritabanı adı ve konumu
            string path = Application.StartupPath + "\\database.db", cs = @"URI=file:" + Application.StartupPath + "\\database.db";

            // Gerekli tanımlamalar
            SQLiteConnection data_connection;
            SQLiteCommand command;
            SQLiteDataReader reader;



            public void Create_Database(String datatable_name, String data_options)
            {
                // Veritablosu yoksa oluşturulur. Varsa oluşturmaz. Hata durumunda kullanıcıya belirtilir.
                try
                {
                
                    // Veritabanı var mı sorgulama
                    if (!System.IO.File.Exists(path))
                    {
                        // if sorgusunda '!' işareti mevcut olduğundan veritabanı yoktur. Bu yüzden veritabanı dosyası oluşturulur.
                        SQLiteConnection.CreateFile(path);
                    }

                    // İstenilen veritablosu yoksa oluşturulur.
                    using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                    {
                        sqlite.Open();
                        string sql = "CREATE TABLE IF NOT EXISTS " + datatable_name + " (" + data_options + ")";
                        SQLiteCommand cmd = new SQLiteCommand(sql, sqlite);
                        cmd.ExecuteNonQuery();
                        cmd.Cancel();
                    }
                }
                catch { MessageBox.Show("Veritabanı Oluşturma Hatası"); }

            }

        public int control_run_car()
        {
            

            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = ("SELECT COUNT(*) FROM run_car");
                int rtn = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Cancel();
                return rtn;
            }
            catch { return 0; }


        }


        public void Get_Data_From_Database(String datatable_name, DataGridView dataGrid)
            {
                // Verilerin girileceği yer (datagrid) temizlenir ve veritablosundan veriler alınıp verilerin girileceği tabloya (datagrid) işlenir.
                // Hata durumunda kullanıcıya belirtilir.
                try
                {
                    dataGrid.Rows.Clear();
                    var data_connection = new SQLiteConnection(cs);
                    data_connection.Open();
                    String stm = "SELECT * FROM " + datatable_name;
                    var command = new SQLiteCommand(stm, data_connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGrid.Rows.Insert(0, reader.GetString(1));
                    }
                }
                catch { MessageBox.Show("Veri Alımı Hatası"); }

            }

           


    

        public DataTable Connect_Data_For_Bottom(String datatable_name, DataGridView dataGrid)
        {
            var conn = new SQLiteConnection(cs);
            var adapter = new SQLiteDataAdapter("SELECT * FROM " + datatable_name + " ORDER BY id DESC LIMIT 10", conn);
            var tablo = new DataTable();
            conn.Open();
            adapter.Fill(tablo);
            dataGrid.DataSource = tablo;
            conn.Close();
            return tablo;
        }

        public DataTable Connect_Data(String datatable_name, DataGridView dataGrid)
        {
            var conn = new SQLiteConnection(cs);
            var adapter = new SQLiteDataAdapter("SELECT * FROM " + datatable_name, conn);
            var tablo = new DataTable();
            conn.Open();
            adapter.Fill(tablo);
            dataGrid.DataSource = tablo;
            conn.Close();
            return tablo;
        }

       

        public int Returnable_Cash_Data(String date,String where , String status_text)
        {
            // Burası veritablosuna birden fazla veri işlemek içindir.
            // Hata durumunda ayrıca belirtilir.

        

            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText =  ("SELECT SUM(IFNULL(price, 0)) FROM database WHERE " + where +  " = '" + status_text + "' AND date LIKE '%" + date + "%'");
                int rtn = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Cancel();
                return rtn;
            }
            catch { return 0; }


        }

        public int Returnable_Cash_Data_For_Cars(String date, String where , String plaka , String payment_text)
        {
            // Burası veritablosuna birden fazla veri işlemek içindir.
            // Hata durumunda ayrıca belirtilir.



            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
       /**/         cmd.CommandText = ("SELECT SUM(IFNULL(price, 0)) FROM database WHERE " + where + " = '" + payment_text + "' AND (date LIKE '%" + date + "%' AND arac = '" + plaka + "')");
                int rtn = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Cancel();
                return rtn;
            }
            catch { return 0; }


        }

        public void Delete_Data(String datatable_name, String database_item_name, String item_name)
            {
                // Burası (Genel) veritablosundan veri silme yeridir. Hata durumunda kullanıcıya belirtilir.
                try
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);
                    cmd.CommandText = "DELETE FROM " + datatable_name + " WHERE " + database_item_name + "=@name";
                    cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", item_name);
                cmd.ExecuteNonQuery();
                    cmd.Cancel();
                }
                catch { MessageBox.Show("Veri Silme Hatası"); }
            }





        public void Insert_Data(String datatable_name, String item_names, String item_values)
            {
                // Burası veritablosuna birden fazla veri işlemek içindir.
                // Hata durumunda ayrıca belirtilir.

                try
                {
                    var con = new SQLiteConnection(cs);
                    con.Open();
                    var cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO " + datatable_name + "(" + item_names + ") VALUES(" + item_values + ")";
                    cmd.ExecuteNonQuery();
                    cmd.Cancel();
                }
                catch { MessageBox.Show("Veri Giriş Hatası"); }


            }


        public int Returnable_Insert_Data(String datatable_name, String item_names, String item_values)
        {
            // Burası veritablosuna birden fazla veri işlemek içindir.
            // Hata durumunda ayrıca belirtilir.

            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO " + datatable_name + "(" + item_names + ") VALUES(" + item_values + "); SELECT last_insert_rowid();";
                int rtn = int.Parse(cmd.ExecuteScalar().ToString());
                cmd.Cancel();
                return rtn;
            }
            catch { MessageBox.Show("Veri Giriş Hatası"); return 0; }


        }


        public void Update_Data(String datatable_name, String arac_name, String item_name, String item_value)
        {
            // Burası ayarların verilerini güncellemek içindir. Hata durumunda belirtilir.
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "UPDATE " + datatable_name + " SET " + item_name + "=@value WHERE arac=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", arac_name);
                cmd.Parameters.AddWithValue("@value", item_value);
                cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Veri Değiştirme Hatası"); }


        }

        public void Update_Data_From_ID(String datatable_name, String id_value, String item_name, String item_value)
        {
            // Burası ayarların verilerini güncellemek içindir. Hata durumunda belirtilir.
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "UPDATE " + datatable_name + " SET " + item_name + "=@value WHERE id=@name";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@name", id_value);
                cmd.Parameters.AddWithValue("@value", item_value);
                cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Veri Değiştirme Hatası"); }


        }

       

        public int Control_Item(String datatable_name, String database_item_name, String item_name)
        {
            // Kontrol edilmesi istenen veriler veritablosunda mevcut mu değil mi kontrol edilir.
            // Varsa var olduğu bilgisi geri döndürülür. Yoksa olmadığı geri döndürülür.
            // Hata durumunda ayrıca belirtilir ve varsayılan olarak olmadığı bilgisi geri döndürülür.
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                cmd.CommandText = "SELECT COUNT(*) FROM " + datatable_name + " WHERE " + database_item_name + " ='" + item_name + "'";

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    Console.WriteLine("Belirtilen öğe var.");
                }
                else
                {
                    Console.WriteLine("Belirtilen öğe yok.");
                }
                cmd.Cancel();
                return count;
            }
            catch { MessageBox.Show("Veri Alımı Hatası"); return 0; }



        }

    }
}
    

