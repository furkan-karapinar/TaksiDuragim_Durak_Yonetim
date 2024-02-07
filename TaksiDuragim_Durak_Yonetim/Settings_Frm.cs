using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static TaksiDuragim_Durak_Yonetim.INI_Module;

namespace TaksiDuragim_Durak_Yonetim
{
    public partial class Settings_Frm : Form
    {
        Database_Control dc = new Database_Control();
        INIKaydet ini = new INIKaydet(Application.StartupPath + @"\lang.ini");
        public Settings_Frm()
        {
            InitializeComponent();
        }

     
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != string.Empty)
            {

                switch (numericUpDown1.Value)
                {
                    case 1:
                        if (dc.Control_Item("durak1", "arac", textBox2.Text) != 1)
                        {
                            dc.Insert_Data("durak1", "arac", "'" + textBox2.Text + "'");
                        }
                        else
                        {
                         
                        }
                        break;
                    case 2:
                        if (dc.Control_Item("durak2", "arac", textBox2.Text) != 1)
                        {
                            dc.Insert_Data("durak2", "arac", "'" + textBox2.Text + "'");
                        }
                        else
                        {
                            
                        }
                        break;
                    case 3:
                        if (dc.Control_Item("durak3", "arac", textBox2.Text) != 1)
                        {
                            dc.Insert_Data("durak3", "arac", "'" + textBox2.Text + "'");
                        }
                        else
                        {
                            
                        }
                        break;
                }
                Update_DataGridView();
                textBox2.Clear();
            }
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != string.Empty)
            {

                switch (numericUpDown1.Value)
                {
                    case 1:
                        dc.Delete_Data("durak1", "arac", textBox2.Text);

                        break;
                    case 2:
                        dc.Delete_Data("durak2", "arac",textBox2.Text);
                        break;
                    case 3:
                        dc.Delete_Data("durak3", "arac", textBox2.Text);
                        break;
                }
                Update_DataGridView();
                textBox2.Clear();
            }
            }catch (Exception hata) { MessageBox.Show(hata.Message); }

        }

        private void Settings_Frm_Load(object sender, EventArgs e)
        {
            Update_DataGridView();
        }

        private void Update_DataGridView()
        {
            try
            {
                dataGridView1.DataSource = dc.Connect_Data("durak1", dataGridView1);
                dataGridView2.DataSource = dc.Connect_Data("durak2", dataGridView2);
                dataGridView3.DataSource = dc.Connect_Data("durak3", dataGridView3);
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                registryKey.SetValue("Taxi_Rank_App", Application.StartupPath + @"\TaksiDuragim_Durak_Yonetim.exe");

            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

        }

        private void Settings_Frm_Activated(object sender, EventArgs e)
        {
           Update_UI();
        }


        private void Update_UI()
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\lang.ini"))
                {


                    string lang_code = (ini.Oku("Selected_Language", "Language"));

                    this.Text = ini.Oku(lang_code, "Settings_Form_Title");
                    groupBox2.Text = ini.Oku(lang_code, "Settings_Form_Add_Remove_Vehicle");
                    label3.Text = ini.Oku(lang_code, "Settings_Form_Taxi_Rank_List");
                    label2.Text = ini.Oku(lang_code, "Settings_Form_Vehicle_License_Plate");
                    label1.Text = ini.Oku(lang_code, "Settings_Form_Taxi_Rank_Number");
                    button4.Text = ini.Oku(lang_code, "Settings_Form_Add");
                    button3.Text = ini.Oku(lang_code, "Settings_Form_Remove");
                    groupBox1.Text = ini.Oku(lang_code, "Settings_Form_Auto_Start_Program");
                    button1.Text = ini.Oku(lang_code, "Settings_Form_Start_Program_With_Windows");
                    button2.Text = ini.Oku(lang_code, "Settings_Form_Do_Not_Start_Program_With_Windows");
                    groupBox3.Text = ini.Oku(lang_code, "Settings_Form_Language");
                    button5.Text = ini.Oku(lang_code, "Settings_Form_Language_Apply");

                    comboBox1.Text = lang_code;

                    string metin = ini.Oku("All_Language", "Language_List");
                    string[] dilListesi = metin.Split(',');
                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(dilListesi);


                    if (dc.control_run_car() != 0)
                    {
                        comboBox1.Enabled = false;
                      /*/*/  groupBox3.Text = ini.Oku(lang_code, "Settings_Form_Language_Wrong").ToString(); 
                        button5.Enabled = false;
                    }

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Language File Is Corrupted " + hata.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ini.Yaz("Selected_Language", "Language", comboBox1.Text);
                Update_UI();
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                registryKey.DeleteValue("Taxi_Rank_App", false);
            }
            catch (Exception hata) { MessageBox.Show(hata.Message); }
            
        }
    }
}
