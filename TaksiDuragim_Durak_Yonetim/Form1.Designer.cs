namespace TaksiDuragim_Durak_Yonetim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımKlavuzuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 845);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1385, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son 10 Kayıt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtYönetimiToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1385, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtYönetimiToolStripMenuItem
            // 
            this.kayıtYönetimiToolStripMenuItem.Name = "kayıtYönetimiToolStripMenuItem";
            this.kayıtYönetimiToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.kayıtYönetimiToolStripMenuItem.Text = "Tüm Kayıtlar";
            this.kayıtYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kayıtYönetimiToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımKlavuzuToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kullanımKlavuzuToolStripMenuItem
            // 
            this.kullanımKlavuzuToolStripMenuItem.Name = "kullanımKlavuzuToolStripMenuItem";
            this.kullanımKlavuzuToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.kullanımKlavuzuToolStripMenuItem.Text = "Kullanım Klavuzu";
            this.kullanımKlavuzuToolStripMenuItem.Click += new System.EventHandler(this.kullanımKlavuzuToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1385, 365);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sıradan Ayrılanlar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(18, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 321);
            this.panel1.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(37, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(599, 38);
            this.button7.TabIndex = 28;
            this.button7.Text = "Müşteri ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1273, 186);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(711, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(599, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Müşteri İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1343, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Günlük Kazanç: 200TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 450);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Seçilen Plaka:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown2.Location = new System.Drawing.Point(287, 48);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(254, 27);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Durak No";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Enabled = false;
            this.dataGridView3.Location = new System.Drawing.Point(21, 47);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(254, 183);
            this.dataGridView3.TabIndex = 24;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(287, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 35);
            this.button5.TabIndex = 22;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Kaydet Ve Yola Çıkar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(287, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(257, 27);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(564, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 142);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Anlaşılan Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Müşteri Varış Noktası (Adres)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Araçlar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Taksi Durağım - Durak Yönetim Paneli";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem kullanımKlavuzuToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer timer1;
    }
}

