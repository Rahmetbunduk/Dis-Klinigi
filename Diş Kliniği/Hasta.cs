using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Kliniği
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTbl values('" + HAdSoyadTb.Text + "','" + HTelefonTb.Text + "','" + AdresTb.Text + "','" + HDogumTarih.Text + "','" + HCinsiyetCb.SelectedItem.ToString() + "','" + AlerjiTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklenmiştir");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];

        }

        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select * from HastaTbl where HAd like '%"+AraTb.Text+"%'";
            DataSet ds = Hs.ShowHasta(query);
            HastaDGV.DataSource = ds.Tables[0];

        }
        void Reset()
        {
            HAdSoyadTb.Text = "";
            HTelefonTb.Text = "";
            AdresTb.Text = "";
            HDogumTarih.Text = "";
            HCinsiyetCb.SelectedItem = "";
            AdresTb.Text = "";
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();

        }

        int key = 0;
        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < HastaDGV.Rows.Count)
            {
                HAdSoyadTb.Text = HastaDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                HTelefonTb.Text = HastaDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                AdresTb.Text = HastaDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                HDogumTarih.Text = HastaDGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
                HCinsiyetCb.SelectedItem = HastaDGV.Rows[e.RowIndex].Cells[5].Value?.ToString();
                AlerjiTb.Text = HastaDGV.Rows[e.RowIndex].Cells[6].Value?.ToString();

                if (string.IsNullOrEmpty(HAdSoyadTb.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(HastaDGV.Rows[e.RowIndex].Cells[0].Value);
                }
            }
        }

        /* private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             HAdSoyadTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
             HTelefonTb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
             AdresTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
             HDogumTarih.Text = HastaDGV.SelectedRows[0].Cells[4].Value.ToString();
             HCinsiyetCb.SelectedItem= HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
             AlerjiTb.Text= HastaDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (HAdSoyadTb.Text =="")
             {
                 key = 0;
             }
             else
             {
                 key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());        
             }
         }*/


        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Delete from HastaTbl where HId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek Hastayı Seçiniz");
            }
            else
            {
                try
                {
                    string query = "Update HastaTbl set HAd='"+HAdSoyadTb.Text+"',HTelefon='"+HTelefonTb.Text+ "',HAdres='" + AdresTb.Text + "',HDTarih='" + HDogumTarih.Text + "',HCinsiyet='" + HCinsiyetCb.SelectedItem.ToString() + "',HAlerji='" + AlerjiTb.Text +"'where HId=" + key + ";";
                    Hs.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi");
                    uyeler();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }

            }
        }

        private void HAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AraTb_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void HastaDGV_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
