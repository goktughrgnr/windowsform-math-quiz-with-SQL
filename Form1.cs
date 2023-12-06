using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace c_uygulama
{
    public partial class Form1 : Form
    {
        Random rastgele = new Random();
        int skor = 0;
        int sayi1, sayi2, yanlishakki = 2, pashakki = 3, sayac = 15, yskor;
        bool oyunBasladi=false;

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;





        void listele()
        {
            baglanti = new SqlConnection("Data Source=goktug;Initial Catalog=kullanıcıSkorları;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Tbl_skorlar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public Form1()
        {
            InitializeComponent();
            AcceptButton = btnGonder;
            txtCevap.Enabled = false;
            btnGonder.Enabled = false;
            BtnPas.Enabled = false;
            btnYukle.Enabled = false; 
            listele();

            btnYukle.Enabled = false; 
            txtAD.TextChanged += YukleButtonDurumunuKontrolEt;
            txtBolum.TextChanged += YukleButtonDurumunuKontrolEt;
            txtogrencino.TextChanged += YukleButtonDurumunuKontrolEt;

        }

        private void YukleButtonDurumunuKontrolEt(object sender, EventArgs e)
        {
            if (oyunBasladi)
            {
                btnYukle.Enabled = !string.IsNullOrWhiteSpace(txtAD.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBolum.Text) &&
                                   !string.IsNullOrWhiteSpace(txtogrencino.Text);
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO Tbl_skorlar(adı_soyadı,öğrenci_no,bölümü,skor) VALUES (@p1,@p2,@p3,@p4)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAD.Text);
                komut.Parameters.AddWithValue("@p2", txtogrencino.Text);
                komut.Parameters.AddWithValue("@p3", txtBolum.Text);
                komut.Parameters.AddWithValue("@p4", yskor);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                btnYukle.Enabled = false;

                
                MessageBox.Show("Yükleme işlemi başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Yükleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text = sayac.ToString();
            progressBar1.Maximum = 15;
            if (progressBar1.Value != 0) progressBar1.Value--;

            if (sayac == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz doldu! Quiz bitti! Skorunuz: " + skor.ToString());
                yskor = skor;
                btnBaslat.Enabled = true;
                txtCevap.Enabled = false;
                btnGonder.Enabled = false;
                BtnPas.Enabled = false;
                txtAD.Enabled = true;
                txtBolum.Enabled = true;
                txtogrencino.Enabled = true;
                btnYukle.Enabled = !string.IsNullOrWhiteSpace(txtAD.Text) &&
                          !string.IsNullOrWhiteSpace(txtBolum.Text) &&
                          !string.IsNullOrWhiteSpace(txtogrencino.Text);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void btnSırala_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir sütun seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string secilenSutun = comboBox1.SelectedItem.ToString();
            string sorgu = $"SELECT * FROM Tbl_skorlar ORDER BY {secilenSutun} DESC"; 

            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void BtnPas_Click(object sender, EventArgs e)
        {
            txtCevap.Clear();
            pashakki--;
            SoruUret();
            lblPas.Text = pashakki.ToString();
            if (pashakki <= 0) BtnPas.Enabled = false;

        }

        private void SoruUret()
        {
            timer1.Start();
            progressBar1.Value = 15;
            sayac = 15;
            sayi1 = rastgele.Next(1, 100);
            sayi2 = rastgele.Next(1, 100);
            lblSoru.Text = sayi1.ToString() + " + " + sayi2.ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            oyunBasladi = true;
            txtAD.Enabled = false;
            txtBolum.Enabled = false;
            txtogrencino.Enabled = false;
            skor = 0;
            lblSkor.Text = skor.ToString();
            yanlishakki = 2;
            pashakki = 3;
            lblPas.Text = pashakki.ToString();
            lblyanlishak.Text = yanlishakki.ToString();
            
            BtnPas.Enabled = true;
            txtCevap.Clear();
            SoruUret();
            btnBaslat.Enabled = false;
            timer1.Start();
            txtCevap.Enabled = true;
            btnGonder.Enabled = true;
            
        }

        private void btnGonder_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtCevap.Text, out int kullaniciCevabi))
            {
                if (kullaniciCevabi == sayi1 + sayi2)
                {
                    skor++;
                    lblSkor.Text = skor.ToString();
                    SoruUret();
                }
                else if (yanlishakki != 0)
                {
                    yanlishakki--;
                    lblyanlishak.Text = yanlishakki.ToString();
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Quiz bitti! Skorunuz: " + skor.ToString());
                    yskor = skor;
                    
                    btnBaslat.Enabled = true;
                    txtCevap.Enabled = false;
                    btnGonder.Enabled = false;
                    BtnPas.Enabled = false;
                    btnYukle.Enabled = true;
                    txtAD.Enabled = true;
                    txtBolum.Enabled = true;
                    txtogrencino.Enabled = true;
                    btnYukle.Enabled = !string.IsNullOrWhiteSpace(txtAD.Text) &&
                          !string.IsNullOrWhiteSpace(txtBolum.Text) &&
                          !string.IsNullOrWhiteSpace(txtogrencino.Text);
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Geçersiz giriş! Lütfen bir sayı giriniz.");
                timer1.Start();
            }
            txtCevap.Clear();
        }

        
    }
}
