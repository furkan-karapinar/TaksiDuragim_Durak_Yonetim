namespace TaksiDuragim_Durak_Yonetim
{
    partial class datalist_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datalist_frm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yillik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 539);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Günlük: 5000TL      Aylık:25000TL        Yıllık: 176000TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 566);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1170, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kazanç";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plaka,
            this.gunluk,
            this.aylik,
            this.yillik});
            this.dataGridView2.Location = new System.Drawing.Point(12, 647);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1167, 140);
            this.dataGridView2.TabIndex = 1;
            // 
            // plaka
            // 
            this.plaka.HeaderText = "Araç";
            this.plaka.MinimumWidth = 6;
            this.plaka.Name = "plaka";
            this.plaka.ReadOnly = true;
            this.plaka.Width = 125;
            // 
            // gunluk
            // 
            this.gunluk.HeaderText = "Günlük";
            this.gunluk.MinimumWidth = 6;
            this.gunluk.Name = "gunluk";
            this.gunluk.ReadOnly = true;
            this.gunluk.Width = 125;
            // 
            // aylik
            // 
            this.aylik.HeaderText = "Aylık";
            this.aylik.MinimumWidth = 6;
            this.aylik.Name = "aylik";
            this.aylik.ReadOnly = true;
            this.aylik.Width = 125;
            // 
            // yillik
            // 
            this.yillik.HeaderText = "Yıllık";
            this.yillik.MinimumWidth = 6;
            this.yillik.Name = "yillik";
            this.yillik.ReadOnly = true;
            this.yillik.Width = 125;
            // 
            // datalist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 804);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "datalist_frm";
            this.Text = "Tüm Kayıtlar";
            this.Activated += new System.EventHandler(this.datalist_frm_Activated);
            this.Load += new System.EventHandler(this.datalist_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn gunluk;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylik;
        private System.Windows.Forms.DataGridViewTextBoxColumn yillik;
    }
}