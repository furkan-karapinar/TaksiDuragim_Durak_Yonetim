using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static TaksiDuragim_Durak_Yonetim.INI_Module;

namespace TaksiDuragim_Durak_Yonetim
{
    public partial class Form1 : Form
    {
        Database_Control dc = new Database_Control();
        INIKaydet ini = new INIKaydet(Application.StartupPath + @"\lang.ini");
        String plaka = null;
        String status_car ;
        int plaka_no = 0;
        string daily, selected_car , lang_code;
        string cn_id , cn_vlp , cn_ts , cn_as , cn_pr , cn_st, cn_dt;
        public Form1()
        {
            InitializeComponent();
        }


        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Frm settings_Frm = new Settings_Frm();
            settings_Frm.ShowDialog();
        }

        private void kayıtYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datalist_frm datalist_Frm = new datalist_frm();
            datalist_Frm.ShowDialog();
        }

        private void Create_Database()
        {
            dc.Create_Database("durak1", "arac VARCHAR");
            dc.Create_Database("durak2", "arac VARCHAR");
            dc.Create_Database("durak3", "arac VARCHAR");
            dc.Create_Database("run_car", "id INTEGER PRIMARY KEY , arac VARCHAR , durak VARCHAR , adress VARCHAR , price INTEGER , status VARCHAR , date VARCHAR");
            dc.Create_Database("database", "id INTEGER PRIMARY KEY , arac VARCHAR , durak VARCHAR , adress VARCHAR , price INTEGER , status VARCHAR , date VARCHAR");
        }

        private void Save_Config()
        {
            this.Hide();
            // Main
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\lang.ini");
            ini.Yaz("EN", "Main_Form_Title", "Taxi Rank - Rank Management Panel");
            ini.Yaz("EN", "Main_Form_All_Data", "All Data");
            ini.Yaz("EN", "Main_Form_Settings", "Settings");
            ini.Yaz("EN", "Main_Form_Help", "Help");
            ini.Yaz("EN", "Main_Form_User_Manual", "User Manual");
            ini.Yaz("EN", "Main_Form_Taxi_Rank_Number", "Taxi Rank Number");
            ini.Yaz("EN", "Main_Form_Customer_Destination_Address", "Customer Destination Address");
            ini.Yaz("EN", "Main_Form_Cars", "Cars");
            ini.Yaz("EN", "Main_Form_Estimated_Price", "Price");
            ini.Yaz("EN", "Main_Form_Save_And_Go", "Save And Go");
            ini.Yaz("EN", "Main_Form_Clear", "Clear");
            ini.Yaz("EN", "Main_Form_Selected_Car", "Selected Car");
            ini.Yaz("EN", "Main_Form_Taxis_Leaving_Station", "Taxis Leaving Station");
            ini.Yaz("EN", "Main_Form_Customer_Arrived", "Customer Arrived");
            ini.Yaz("EN", "Main_Form_Taxi_Rank_Returned", "Taxi Rank Returned");
            ini.Yaz("EN", "Main_Form_Customer_Abandoned", "Customer Abandoned");
            ini.Yaz("EN", "Main_Form_Processed_Last_10_Data", "Processed Last 10 Data");
            ini.Yaz("EN", "Main_Form_Daily_Earnings", "Daily Earnings");
            ini.Yaz("EN", "Main_Form_Status_Car", "On The Road");
            ini.Yaz("EN", "Main_Form_Status_Arrived", "Arrived");
            ini.Yaz("EN", "Main_Form_Payment_Received", "Payment Received");
            ini.Yaz("EN", "Main_Form_Car_Returned", "Car Returned");



            // All Data
            ini.Yaz("EN", "All_Data_Form_Title", "All Data");
            ini.Yaz("EN", "All_Data_Form_Daily_Earnings", "Daily Earnings");
            ini.Yaz("EN", "All_Data_Form_Monthly_Earnings", "Monthly Earnings");
            ini.Yaz("EN", "All_Data_Form_Yearly_Earnings", "Yearly Earnings");
            ini.Yaz("EN", "All_Data_Form_Earnings", "Earnings");

            ini.Yaz("EN", "Settings_Form_Title", "Settings");
            ini.Yaz("EN", "Settings_Form_Add_Remove_Vehicle", "Add Remove Vehicle");
            ini.Yaz("EN", "Settings_Form_Taxi_Rank_List", "Taxi Rank 1 - Taxi Rank 2 - Taxi Rank 3 List");
            ini.Yaz("EN", "Settings_Form_Vehicle_License_Plate", "Vehicle License Plate");
            ini.Yaz("EN", "Settings_Form_Taxi_Rank_Number", "Taxi Rank Number");
            ini.Yaz("EN", "Settings_Form_Add", "Add");
            ini.Yaz("EN", "Settings_Form_Remove", "Remove");
            ini.Yaz("EN", "Settings_Form_Auto_Start_Program", "Auto Start Program");
            ini.Yaz("EN", "Settings_Form_Start_Program_With_Windows", "Start Program With Windows");
            ini.Yaz("EN", "Settings_Form_Do_Not_Start_Program_With_Windows", "Do Not Start Program With Windows");
            ini.Yaz("EN", "Settings_Form_Language", "Language (When You Change The Interface Language, Only The Records In The Current Language Are Taken Into Account During Profit Calculation)");
            ini.Yaz("EN", "Settings_Form_Language_Wrong", "The Interface Language Cannot Be Changed When There Are Vehicles Other Than Taxi Rank");
            ini.Yaz("EN", "Settings_Form_Language_Apply", "Apply");
            ini.Yaz("EN", "Currency", "£");

            ini.Yaz("EN", "Column_Name_ID", "ID");
            ini.Yaz("EN", "Column_Name_Vehicle_License_Plate", "Vehicle License Plate");
            ini.Yaz("EN", "Column_Name_Rank", "Taxi Rank");
            ini.Yaz("EN", "Column_Name_Address", "Address");
            ini.Yaz("EN", "Column_Name_Price", "Price");
            ini.Yaz("EN", "Column_Name_Status", "Status");
            ini.Yaz("EN", "Column_Name_Date", "Date");



            ini.Yaz("TR", "Main_Form_Title", "Taksi Durağı - DuraK Yönetim Paneli");
            ini.Yaz("TR", "Main_Form_All_Data", "Tüm Veriler");
            ini.Yaz("TR", "Main_Form_Settings", "Ayarlar");
            ini.Yaz("TR", "Main_Form_Help", "Yardım");
            ini.Yaz("TR", "Main_Form_User_Manual", "Kullanım Kılavuzu");
            ini.Yaz("TR", "Main_Form_Taxi_Rank_Number", "Taksi Durağı Numarası");
            ini.Yaz("TR", "Main_Form_Customer_Destination_Address", "Müşteri Gidilecek Adresi");
            ini.Yaz("TR", "Main_Form_Cars", "Araçlar");
            ini.Yaz("TR", "Main_Form_Estimated_Price", "Fiyat");
            ini.Yaz("TR", "Main_Form_Save_And_Go", "Kaydet ve Yola Çıkar");
            ini.Yaz("TR", "Main_Form_Clear", "Temizle");
            ini.Yaz("TR", "Main_Form_Selected_Car", "Seçilen Araç");
            ini.Yaz("TR", "Main_Form_Taxis_Leaving_Station", "Durağı Terk Eden Taksi Sayısı");
            ini.Yaz("TR", "Main_Form_Customer_Arrived", "Müşteri Hedefe Vardı");
            ini.Yaz("TR", "Main_Form_Taxi_Rank_Returned", "Taksi Durağa Geri Döndü");
            ini.Yaz("TR", "Main_Form_Customer_Abandoned", "Müşteri Vazgeçti");
            ini.Yaz("TR", "Main_Form_Processed_Last_10_Data", "Son 10 İşlenen Veri");
            ini.Yaz("TR", "Main_Form_Daily_Earnings", "Günlük Kazanç");
            ini.Yaz("TR", "Main_Form_Status_Car", "Yolda");
            ini.Yaz("TR", "Main_Form_Status_Arrived", "Hedefe Vardı");
            ini.Yaz("TR", "Main_Form_Payment_Received", "Ödeme Alındı");
            ini.Yaz("TR", "Main_Form_Car_Returned", "Araç Durağa Geri Döndü");

            // Tüm Veriler
            ini.Yaz("TR", "All_Data_Form_Title", "Tüm Veriler");
            ini.Yaz("TR", "All_Data_Form_Daily_Earnings", "Günlük Kazanç");
            ini.Yaz("TR", "All_Data_Form_Monthly_Earnings", "Aylık Kazanç");
            ini.Yaz("TR", "All_Data_Form_Yearly_Earnings", "Yıllık Kazanç");
            ini.Yaz("TR", "All_Data_Form_Earnings", "Kazanç");

            ini.Yaz("TR", "Settings_Form_Title", "Ayarlar");
            ini.Yaz("TR", "Settings_Form_Add_Remove_Vehicle", "Araç Ekle Veya Kaldır");
            ini.Yaz("TR", "Settings_Form_Taxi_Rank_List", "Taksi Durağı 1 - Taksi Durağı 2  - Taksi Durağı 3 Listesi");
            ini.Yaz("TR", "Settings_Form_Vehicle_License_Plate", "Araç Plakası");
            ini.Yaz("TR", "Settings_Form_Taxi_Rank_Number", "Taksi Durağı Numarası");
            ini.Yaz("TR", "Settings_Form_Add", "Ekle");
            ini.Yaz("TR", "Settings_Form_Remove", "Kaldır");
            ini.Yaz("TR", "Settings_Form_Auto_Start_Program", "Programı Otomatik Başlat");
            ini.Yaz("TR", "Settings_Form_Start_Program_With_Windows", "Programı Windows İle Otomatik Başlat");
            ini.Yaz("TR", "Settings_Form_Do_Not_Start_Program_With_Windows", "Programı Windows İle Otomatik Başlatma");
            ini.Yaz("TR", "Settings_Form_Language", "Arayüz Dili (Arayüz Dilini Değiştirdiğinizde Kar Hesaplamasında Sadece O Anki Dildeki Kayıtlar Dikkate Alınır)");
            ini.Yaz("TR", "Settings_Form_Language_Wrong", "Arayüz Dili Durak Dışında Araç Var İken Değiştirilemez");
            ini.Yaz("TR", "Settings_Form_Language_Apply", "Uygula");
            ini.Yaz("TR", "Currency", "TL");

            ini.Yaz("TR", "Column_Name_ID", "ID");
            ini.Yaz("TR", "Column_Name_Vehicle_License_Plate", "Plaka");
            ini.Yaz("TR", "Column_Name_Rank", "Durak");
            ini.Yaz("TR", "Column_Name_Address", "Adres");
            ini.Yaz("TR", "Column_Name_Price", "Fiyat");
            ini.Yaz("TR", "Column_Name_Status", "Durum");
            ini.Yaz("TR", "Column_Name_Date", "Tarih");



            ini.Yaz("Selected_Language", "Language", "EN");
            ini.Yaz("All_Language", "Language_List", "TR,EN");


            MessageBox.Show("It Was Again Created By The Program As There Is No Language File. Run the Program Again." , "Taxi Rank Management");
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Create_Database();
            Update_DataGridView(((int)numericUpDown2.Value));

           

        }
        private void Update_DataGridView(int durak_no)
        {
            dataGridView3.ColumnHeadersVisible = false;
            switch (durak_no)
            {
                case 1:
                    dataGridView3.DataSource = dc.Connect_Data("durak1", dataGridView3);
                    break;
                case 2:
                    dataGridView3.DataSource = dc.Connect_Data("durak2", dataGridView3);
                    break;
                case 3:
                    dataGridView3.DataSource = dc.Connect_Data("durak3", dataGridView3);
                    break;
            }
            dataGridView2.DataSource = dc.Connect_Data("run_car",dataGridView2);
            dataGridView2.Columns["id"].HeaderText = cn_id;
            dataGridView2.Columns["arac"].HeaderText = cn_vlp;
            dataGridView2.Columns["durak"].HeaderText = cn_ts;
            dataGridView2.Columns["adress"].HeaderText = cn_as;
            dataGridView2.Columns["price"].HeaderText = cn_pr;
            dataGridView2.Columns["status"].HeaderText = cn_st;
            dataGridView2.Columns["date"].HeaderText = cn_dt;

            dataGridView1.DataSource = dc.Connect_Data_For_Bottom("database", dataGridView1);
            dataGridView1.Columns["id"].HeaderText = cn_id;
            dataGridView1.Columns["arac"].HeaderText = cn_vlp;
            dataGridView1.Columns["durak"].HeaderText = cn_ts;
            dataGridView1.Columns["adress"].HeaderText = cn_as;
            dataGridView1.Columns["price"].HeaderText = cn_pr;
            dataGridView1.Columns["status"].HeaderText = cn_st;
            dataGridView1.Columns["date"].HeaderText = cn_dt;


            


            label1.Text = daily + ": " + dc.Returnable_Cash_Data(DateTime.Now.Date.ToString().TrimEnd('0', ':'),"status",ini.Oku(lang_code, "Main_Form_Payment_Received")).ToString() +" " + ini.Oku(lang_code, "Currency");


        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            update_btn();
        }

        private void update_btn()
        {
            
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string status_Value = Convert.ToString(selectedRow.Cells["status"].Value);

                if (status_Value == ini.Oku(lang_code, "Main_Form_Status_Arrived")) // Hedefe Vardı yazıyor ise
                {
                    button7.Text = ini.Oku(lang_code, "Main_Form_Payment_Received"); // Button 7 Ödeme Alındı yazdır
                }
                else if (status_Value == ini.Oku(lang_code, "Main_Form_Payment_Received"))
                {
                    button7.Text = ini.Oku(lang_code, "Main_Form_Main_Form_Car_Returned");
                } else if (status_Value == ini.Oku(lang_code, "Main_Form_Status_Car"))
                {
                    button7.Text = ini.Oku(lang_code, "Main_Form_Customer_Arrived");
                }

            }
            if (button7.Text == "")
            {
                button7.Text = (ini.Oku(lang_code, "Main_Form_Car_Returned").ToString());
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            update_btn();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update_btn();
        }

        private void kullanımKlavuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", Application.StartupPath + @"\user_manual\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User_Manual Error! Error Code: " + ex.Message);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
label5.Text = selected_car + ":";
            plaka = null;
            plaka_no = 0;
            Update_DataGridView(((int)numericUpDown2.Value));
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

        }

     /*   private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    string durak_Value = Convert.ToString(selectedRow.Cells["durak"].Value);
                    string id_Value = Convert.ToString(selectedRow.Cells["id"].Value);
                    string arac_Value = Convert.ToString(selectedRow.Cells["arac"].Value);

                    dc.Update_Data_From_ID("database", id_Value, "status", "OK");
                    switch (durak_Value)
                    {
                        case "1":
                            dc.Insert_Data("durak1", "arac", "'" + arac_Value + "'");
                            dc.Delete_Data("run_car", "arac", arac_Value);
                            break;
                        case "2":
                            dc.Insert_Data("durak2", "arac", "'" + arac_Value + "'");
                            dc.Delete_Data("run_car", "arac", arac_Value);
                            break;
                        case "3":
                            dc.Insert_Data("durak3", "arac", "'" + arac_Value + "'");
                            dc.Delete_Data("run_car", "arac", arac_Value);
                            break;
                    }
                }
                Update_DataGridView(((int)numericUpDown2.Value));
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

        }
*/
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = (ini.Oku(lang_code, "Main_Form_Car_Returned").ToString());
            }
            if (button7.Text == (ini.Oku(lang_code, "Main_Form_Car_Returned").ToString()))
            {
                try
                    {
                        if (dataGridView2.SelectedCells.Count > 0)
                        {
                            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                            string id_Value = Convert.ToString(selectedRow.Cells["id"].Value);
                            string arac_Value = Convert.ToString(selectedRow.Cells["arac"].Value);
                            string durak_Value = Convert.ToString(selectedRow.Cells["durak"].Value);
                            string adres_Value = Convert.ToString(selectedRow.Cells["adress"].Value);
                            string fiyat_Value = Convert.ToString(selectedRow.Cells["price"].Value);
                            string durum_Value = Convert.ToString(selectedRow.Cells["status"].Value);
                            string tarih_Value = Convert.ToString(selectedRow.Cells["date"].Value);

                            String data = "'" + arac_Value + "' , '" + durak_Value + "' , '" + adres_Value + "' , '" + fiyat_Value + "' , '" + button7.Text + "' , '" + DateTime.Now + "'";
                            int id = dc.Returnable_Insert_Data("database", "arac,durak,adress,price,status,date", data);

                            switch (durak_Value)
                            {
                                case "1":
                                    dc.Insert_Data("durak1", "arac", "'" + arac_Value + "'");
                                    dc.Delete_Data("run_car", "arac", arac_Value);
                                    break;
                                case "2":
                                    dc.Insert_Data("durak2", "arac", "'" + arac_Value + "'");
                                    dc.Delete_Data("run_car", "arac", arac_Value);
                                    break;
                                case "3":
                                    dc.Insert_Data("durak3", "arac", "'" + arac_Value + "'");
                                    dc.Delete_Data("run_car", "arac", arac_Value);
                                    break;
                            }
                            
                            Update_DataGridView(((int)numericUpDown2.Value));
                        }
                    }
                    catch (Exception hata) { MessageBox.Show(hata.Message); }
                    button7.Text = ini.Oku(lang_code, "Main_Form_Customer_Arrived").ToString();
               
            } 
            else if (button7.Text == (ini.Oku(lang_code, "Main_Form_Payment_Received").ToString()))
            {
                try
                {
                    if (dataGridView2.SelectedCells.Count > 0)
                    {
                        int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                        string id_Value = Convert.ToString(selectedRow.Cells["id"].Value);
                        string arac_Value = Convert.ToString(selectedRow.Cells["arac"].Value);
                        string durak_Value = Convert.ToString(selectedRow.Cells["durak"].Value);
                        string adres_Value = Convert.ToString(selectedRow.Cells["adress"].Value);
                        string fiyat_Value = Convert.ToString(selectedRow.Cells["price"].Value);
                        string durum_Value = Convert.ToString(selectedRow.Cells["status"].Value);
                        string tarih_Value = Convert.ToString(selectedRow.Cells["date"].Value);
                        dc.Update_Data("run_car", arac_Value, "status", ini.Oku(lang_code, "Main_Form_Payment_Received").ToString());

                        String data = "'" + arac_Value + "' , '" + durak_Value + "' , '" + adres_Value + "' , '" + fiyat_Value + "' , '" + button7.Text + "' , '" + DateTime.Now + "'";
                        int id = dc.Returnable_Insert_Data("database", "arac,durak,adress,price,status,date", data);

                    }
                    Update_DataGridView(((int)numericUpDown2.Value));
                }
                catch (Exception hata) { MessageBox.Show(hata.Message); }
                button7.Text = ini.Oku(lang_code, "Main_Form_Car_Returned");
                
               
            } 
            else if (button7.Text == (ini.Oku(lang_code, "Main_Form_Customer_Arrived").ToString()))
            {
                try
                {
                    if (dataGridView2.SelectedCells.Count > 0)
                    {
                        int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                        string id_Value = Convert.ToString(selectedRow.Cells["id"].Value);
                        string arac_Value = Convert.ToString(selectedRow.Cells["arac"].Value);
                        string durak_Value = Convert.ToString(selectedRow.Cells["durak"].Value);
                        string adres_Value = Convert.ToString(selectedRow.Cells["adress"].Value);
                        string fiyat_Value = Convert.ToString(selectedRow.Cells["price"].Value);
                        string durum_Value = Convert.ToString(selectedRow.Cells["status"].Value);
                        string tarih_Value = Convert.ToString(selectedRow.Cells["date"].Value);
                        dc.Update_Data("run_car", arac_Value, "status", ini.Oku(lang_code, "Main_Form_Status_Arrived"));
                        String data = "'" + arac_Value + "' , '" + durak_Value + "' , '" + adres_Value + "' , '" + fiyat_Value + "' , '" + button7.Text + "' , '" + DateTime.Now + "'";
                        int id = dc.Returnable_Insert_Data("database", "arac,durak,adress,price,status,date", data);

                        Update_DataGridView(((int)numericUpDown2.Value));
                    }
                }
                catch (Exception hata) { MessageBox.Show(hata.Message); }
                button7.Text = ini.Oku(lang_code, "Main_Form_Payment_Received");
                
            
            }
            
        }


       

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
if (dataGridView3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["arac"].Value);
                label5.Text = selected_car + ": " + cellValue;
                plaka = cellValue;
                plaka_no = selectedrowindex;
            }
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
richTextBox1.Clear();
            numericUpDown1.Value = 0;
            Update_DataGridView(((int)numericUpDown2.Value));
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

        }

        private void car_remove_item(String car_plaka, int data)
        {
            switch (data)
            {
                case 1:
                    dc.Delete_Data("durak1" ,"arac",car_plaka);
                    break;
                case 2:
                    dc.Delete_Data("durak2", "arac", car_plaka);
                    break;
                case 3:
                    dc.Delete_Data("durak3", "arac", car_plaka);
                    break;
            }
            Update_DataGridView(((int)numericUpDown2.Value));
        }

        private void button4_Click(object sender, EventArgs e)
        {
           try
           {
                if (richTextBox1.Text != string.Empty || plaka != null)
            {
             status_car = ini.Oku(lang_code, "Main_Form_Status_Car");
            String data = "'" + plaka + "' , '" + numericUpDown2.Value + "' , '" + richTextBox1.Text + "' , '" + numericUpDown1.Value + "' , '" + status_car + "' , '" + DateTime.Now + "'";
            int id = dc.Returnable_Insert_Data("database", "arac,durak,adress,price,status,date", data);
                    dc.Insert_Data("run_car", "arac,durak,adress,price,status,date", data);
                    car_remove_item(plaka , ((int)numericUpDown2.Value));
            richTextBox1.Clear();
            numericUpDown1.Value = 0;
            }
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }




        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["arac"].Value);
                dc.Update_Data("run_car", cellValue, "durum", ini.Oku(lang_code, "Main_Form_Status_Arrived"));
                Update_DataGridView(((int)numericUpDown2.Value));
            }
            } catch (Exception hata){ MessageBox.Show(hata.Message); }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["arac"].Value);
                    dc.Update_Data("run_car", cellValue, "durum", "Araç Geri Geldi");
                    Update_DataGridView(((int)numericUpDown2.Value));
                }
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }


        }
*/
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    string id_Value = Convert.ToString(selectedRow.Cells["id"].Value);
                    string arac_Value = Convert.ToString(selectedRow.Cells["arac"].Value);
                    string durak_Value = Convert.ToString(selectedRow.Cells["durak"].Value);
                    string adres_Value = Convert.ToString(selectedRow.Cells["adress"].Value);
                    string fiyat_Value = Convert.ToString(selectedRow.Cells["price"].Value);
                    string durum_Value = Convert.ToString(selectedRow.Cells["status"].Value);
                    string tarih_Value = Convert.ToString(selectedRow.Cells["date"].Value);

                    String data = "'" + arac_Value + "' , '" + durak_Value + "' , '" + adres_Value + "' , '" + fiyat_Value + "' , '" + ini.Oku(lang_code, "Main_Form_Customer_Abandoned") + "' , '" + DateTime.Now + "'";
                    int id = dc.Returnable_Insert_Data("database", "arac,durak,adress,price,status,date", data);

                    switch (durak_Value)
                {
                    case "1":
                        dc.Insert_Data("durak1", "arac", "'" + arac_Value + "'");
                        dc.Delete_Data("run_car", "arac", arac_Value);
                        break;
                    case "2":
                        dc.Insert_Data("durak2", "arac", "'" + arac_Value + "'");
                        dc.Delete_Data("run_car", "arac", arac_Value);
                        break;
                    case "3":
                        dc.Insert_Data("durak3", "arac", "'" + arac_Value + "'");
                        dc.Delete_Data("run_car", "arac", arac_Value);
                        break;
                }
            }
            Update_DataGridView(((int)numericUpDown2.Value));
                button7.Text = ini.Oku(lang_code, "Main_Form_Customer_Arrived").ToString();
            } catch (Exception hata) { MessageBox.Show(hata.Message); }
            update_btn();


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\lang.ini"))
                {
                    

                    lang_code = (ini.Oku("Selected_Language", "Language"));

                   this.Text = ini.Oku(lang_code, "Main_Form_Title");
                   kayıtYönetimiToolStripMenuItem.Text = ini.Oku(lang_code, "Main_Form_All_Data");
                   ayarlarToolStripMenuItem.Text = ini.Oku(lang_code, "Main_Form_Settings");
                   yardımToolStripMenuItem.Text =  ini.Oku(lang_code, "Main_Form_Help");
                   kullanımKlavuzuToolStripMenuItem.Text = ini.Oku(lang_code, "Main_Form_User_Manual");
                   label2.Text = ini.Oku(lang_code, "Main_Form_Taxi_Rank_Number");
                   label3.Text = ini.Oku(lang_code, "Main_Form_Customer_Destination_Address");
                   label6.Text = ini.Oku(lang_code, "Main_Form_Cars");
                   label4.Text = ini.Oku(lang_code, "Main_Form_Estimated_Price");
                   button4.Text = ini.Oku(lang_code, "Main_Form_Save_And_Go");
                   button5.Text = ini.Oku(lang_code, "Main_Form_Clear");
                   label5.Text = ini.Oku(lang_code, "Main_Form_Selected_Car");
                   groupBox2.Text = ini.Oku(lang_code, "Main_Form_Taxis_Leaving_Station");
                   button7.Text = ini.Oku(lang_code, "Main_Form_Customer_Arrived");
                   button3.Text = ini.Oku(lang_code, "Main_Form_Customer_Abandoned");
                   groupBox1.Text = ini.Oku(lang_code, "Main_Form_Processed_Last_10_Data");
                   label1.Text = ini.Oku(lang_code, "Main_Form_Daily_Earnings");

                  cn_id =  ini.Oku(lang_code, "Column_Name_ID");
                    cn_vlp = ini.Oku(lang_code, "Column_Name_Vehicle_License_Plate");
                    cn_ts = ini.Oku(lang_code, "Column_Name_Rank");
                    cn_as = ini.Oku(lang_code, "Column_Name_Address");
                    cn_pr = ini.Oku(lang_code, "Column_Name_Price");
                    cn_st = ini.Oku(lang_code, "Column_Name_Status");
                    cn_dt = ini.Oku(lang_code, "Column_Name_Date");

                    selected_car = ini.Oku(lang_code, "Main_Form_Selected_Car");
                    daily = ini.Oku(lang_code, "Main_Form_Daily_Earnings");
                    Update_DataGridView(((int)numericUpDown2.Value));
                }
                else { Save_Config(); }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Language File Is Corrupted " + hata.Message);
                File.Delete(Application.StartupPath + @"\lang.ini");
                Save_Config();
            }
            if (button7.Text == "")
            {
                button7.Text = (ini.Oku(lang_code, "Main_Form_Car_Returned").ToString());
            }

        }
    }
}
