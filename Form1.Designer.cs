using System.Drawing;
using System;

namespace c_uygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.lblyanlishak = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnPas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtogrencino = new System.Windows.Forms.MaskedTextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSırala = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblSoru.Location = new System.Drawing.Point(60, 79);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(49, 26);
            this.lblSoru.TabIndex = 0;
            this.lblSoru.Text = "soru";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblSkor.Location = new System.Drawing.Point(321, 118);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(23, 26);
            this.lblSkor.TabIndex = 2;
            this.lblSkor.Text = "0";
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(362, 47);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(34, 26);
            this.lblSayac.TabIndex = 3;
            this.lblSayac.Text = "15";
            // 
            // lblyanlishak
            // 
            this.lblyanlishak.AutoSize = true;
            this.lblyanlishak.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblyanlishak.Location = new System.Drawing.Point(321, 159);
            this.lblyanlishak.Name = "lblyanlishak";
            this.lblyanlishak.Size = new System.Drawing.Size(23, 26);
            this.lblyanlishak.TabIndex = 4;
            this.lblyanlishak.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(219, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Skorunuz:";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(12, 115);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(156, 33);
            this.txtCevap.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(12, 50);
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Value = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Location = new System.Drawing.Point(173, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "yanlış hakkınız:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(12, 156);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(156, 32);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.Text = "Cevapla/ENTER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click_1);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(12, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(344, 32);
            this.btnBaslat.TabIndex = 10;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // BtnPas
            // 
            this.BtnPas.Location = new System.Drawing.Point(12, 199);
            this.BtnPas.Name = "BtnPas";
            this.BtnPas.Size = new System.Drawing.Size(156, 32);
            this.BtnPas.TabIndex = 11;
            this.BtnPas.Text = "Pas";
            this.BtnPas.UseVisualStyleBackColor = true;
            this.BtnPas.Click += new System.EventHandler(this.BtnPas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(191, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pas Hakkınız:";
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblPas.Location = new System.Drawing.Point(321, 202);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(23, 26);
            this.lblPas.TabIndex = 13;
            this.lblPas.Text = "3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(663, 224);
            this.dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ad-Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Öğrenci no:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(504, 98);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(161, 33);
            this.txtAD.TabIndex = 18;
            // 
            // txtogrencino
            // 
            this.txtogrencino.Location = new System.Drawing.Point(504, 210);
            this.txtogrencino.Mask = "000000000";
            this.txtogrencino.Name = "txtogrencino";
            this.txtogrencino.Size = new System.Drawing.Size(161, 33);
            this.txtogrencino.TabIndex = 21;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(504, 156);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(161, 33);
            this.txtBolum.TabIndex = 19;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(713, 340);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(119, 155);
            this.btnYukle.TabIndex = 22;
            this.btnYukle.Text = "Skorunu yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(252, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Skor Listesi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "adı_soyadı",
            "öğrenci_no",
            "bölümü",
            "skor",
            "id"});
            this.comboBox1.Location = new System.Drawing.Point(713, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 34);
            this.comboBox1.TabIndex = 25;
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(713, 111);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(119, 33);
            this.btnSırala.TabIndex = 26;
            this.btnSırala.Text = "Sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(694, 301);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(157, 33);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Listeyi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.IndianRed;
            this.btnCik.Location = new System.Drawing.Point(749, 12);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(146, 61);
            this.btnCik.TabIndex = 28;
            this.btnCik.Text = "Uygulamadan Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(907, 566);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.txtogrencino);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPas);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblyanlishak);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblSoru);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "MAT QUİZ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label lblyanlishak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnPas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.MaskedTextBox txtogrencino;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnCik;


    }
   

}

