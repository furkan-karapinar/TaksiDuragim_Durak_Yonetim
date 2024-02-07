using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static TaksiDuragim_Durak_Yonetim.INI_Module;

namespace TaksiDuragim_Durak_Yonetim
{
    public partial class datalist_frm : Form
    {
        SQLiteConnection data_connection;
        SQLiteCommand command;
        SQLiteDataReader reader;

        Database_Control dc = new Database_Control();
        string daily, monthly, yearly;
        string day, month, year;
        string cn_id, cn_vlp, cn_ts, cn_as, cn_pr, cn_st, cn_dt,txt;
        string cs = @"URI=file:" + Application.StartupPath + "\\database.db";

        INIKaydet ini = new INIKaydet(Application.StartupPath + @"\lang.ini");

        string lang_code;
        public datalist_frm()
        {
            InitializeComponent();
        }

        private void datalist_frm_Load(object sender, EventArgs e)
        {
          
         
          

            try
            {
                
                lang_code = (ini.Oku("Selected_Language", "Language"));
            dataGridView1.DataSource = dc.Connect_Data("database", dataGridView1);
            cn_id = ini.Oku(lang_code, "Column_Name_ID");
            cn_vlp = ini.Oku(lang_code, "Column_Name_Vehicle_License_Plate");
            cn_ts = ini.Oku(lang_code, "Column_Name_Rank");
            cn_as = ini.Oku(lang_code, "Column_Name_Address");
            cn_pr = ini.Oku(lang_code, "Column_Name_Price");
            cn_st = ini.Oku(lang_code, "Column_Name_Status");
            cn_dt = ini.Oku(lang_code, "Column_Name_Date");
                txt = ini.Oku(lang_code, "Main_Form_Payment_Received");

            dataGridView1.Columns["id"].HeaderText = cn_id;
            dataGridView1.Columns["arac"].HeaderText = cn_vlp;
            dataGridView1.Columns["durak"].HeaderText = cn_ts;
            dataGridView1.Columns["adress"].HeaderText = cn_as;
            dataGridView1.Columns["price"].HeaderText = cn_pr;
            dataGridView1.Columns["status"].HeaderText = cn_st;
            dataGridView1.Columns["date"].HeaderText = cn_dt;
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

            try
            {

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                for (int sayac = 0; sayac < 5; sayac++)
                {
                    try
                    {
                        var data_connection = new SQLiteConnection(cs);
                        data_connection.Open();
                        String stm = "SELECT arac FROM durak" + sayac;
                        var command = new SQLiteCommand(stm, data_connection);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {

                            
                            string arac = reader.GetString(0);
                            int dy = dc.Returnable_Cash_Data_For_Cars(DateTime.Now.Date.ToString().TrimEnd('0', ':'), "status", arac,txt);
                            int mnt = dc.Returnable_Cash_Data_For_Cars(DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString(), "status", arac, txt);
                            int yr = dc.Returnable_Cash_Data_For_Cars(DateTime.Now.Year.ToString(), "status", arac, txt);

                            dataGridView2.Rows.Add(arac, dy, mnt, yr);
                            
                        }
                    }
                    catch { }
                }

            }
            catch { }

        }

        private void datalist_frm_Activated(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\lang.ini"))
                {
                    lang_code = (ini.Oku("Selected_Language", "Language"));

                    this.Text = ini.Oku(lang_code, "All_Data_Form_Title");
                    daily = ini.Oku(lang_code, "All_Data_Form_Daily_Earnings");
                    monthly = ini.Oku(lang_code, "All_Data_Form_Monthly_Earnings");
                    yearly = ini.Oku(lang_code, "All_Data_Form_Yearly_Earnings");
                    groupBox1.Text = ini.Oku(lang_code, "All_Data_Form_Earnings");
                    cn_id = ini.Oku(lang_code, "Column_Name_ID");
                    cn_vlp = ini.Oku(lang_code, "Column_Name_Vehicle_License_Plate");
                    cn_ts = ini.Oku(lang_code, "Column_Name_Rank");
                    cn_as = ini.Oku(lang_code, "Column_Name_Address");
                    cn_pr = ini.Oku(lang_code, "Column_Name_Price");
                    cn_st = ini.Oku(lang_code, "Column_Name_Status");
                    cn_dt = ini.Oku(lang_code, "Column_Name_Date");
                    txt = ini.Oku(lang_code, "Main_Form_Payment_Received");

                    day = daily + ": " + dc.Returnable_Cash_Data(DateTime.Now.Date.ToString().TrimEnd('0', ':'),"status", ini.Oku(lang_code, "Main_Form_Payment_Received")).ToString() + " " + ini.Oku(lang_code, "Currency");
                    month = monthly + ": " + dc.Returnable_Cash_Data(DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString(),"status", ini.Oku(lang_code, "Main_Form_Payment_Received")).ToString() + " " + ini.Oku(lang_code, "Currency");
                    year = yearly + ": " + dc.Returnable_Cash_Data(DateTime.Now.Year.ToString(),"status", ini.Oku(lang_code, "Main_Form_Payment_Received")).ToString() + " " + ini.Oku(lang_code, "Currency");

                    label1.Text = day + "      " + month + "      " + year;
                    dataGridView2.Columns["gunluk"].HeaderText = daily;
                    dataGridView2.Columns["aylik"].HeaderText = monthly;
                    dataGridView2.Columns["yillik"].HeaderText = yearly;
                    dataGridView2.Columns["plaka"].HeaderText = cn_vlp;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Language File Is Corrupted " + hata.Message);
            }
        }
    }
}
