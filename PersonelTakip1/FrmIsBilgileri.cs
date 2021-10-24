using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using System.Linq;
using DAL;

namespace PersonelTakip
{
    public partial class FrmIsBilgileri : Form
    {
        public FrmIsBilgileri()
        {
            InitializeComponent();
        }
        IsDTO dto = new IsDTO();
        bool combofull = false;
        public bool isUpdate = false;
        public IsDetayDTO detay = new IsDetayDTO();
        private void FrmIsBilgileri_Load(object sender, EventArgs e)
        {
            cmbIsDurum.Visible = false;
            label9.Visible = false;
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false; ;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAD";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAD";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;

            if (isUpdate)
            {
                cmbIsDurum.Visible = false;
                label9.Visible = false;
                txtAd.Text = detay.Ad;
                txtSoyad.Text = detay.Soyad;
                txtUserNo.Text = detay.UserNo.ToString();
                txtIcerik.Text = detay.Icerik;
                txtBaslik.Text = detay.Baslik;
                cmbIsDurum.DataSource = dto.Durumlar;
                cmbIsDurum.DisplayMember = "İsDurumAd";
                cmbIsDurum.ValueMember = "ID";
                cmbIsDurum.SelectedValue = detay.IsDurumID;

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        IS iss = new IS();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            iss = new IS();
            iss.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (iss.PersonelID == 0)
                MessageBox.Show("Personel Seçin");
            else if (txtBaslik.Text.Trim() == "")
                MessageBox.Show("Başlık Boş");
            else if (txtIcerik.Text.Trim() == "")
                MessageBox.Show("İçerik Boş");
            else
            {
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                    if (result==DialogResult.Yes)
                    {
                        IsDetayDTO dtoo = new IsDetayDTO();
                        if (Convert.ToInt32(txtUserNo.Text) != detay.UserNo)
                            dtoo.PersonelID = iss.PersonelID;
                        else
                            dtoo.PersonelID = detay.PersonelID;
                        dtoo.Baslik = txtBaslik.Text;
                        dtoo.Icerik = txtIcerik.Text;
                        dtoo.IsDurumID = Convert.ToInt32(cmbIsDurum.SelectedValue);
                        dtoo.IsID = detay.IsID;
                        IsBLL.isGuncelle(dtoo);
                        MessageBox.Show("Güncellendi");
                        this.Close();
                    }
                }
                else
                {
                    iss.Baslik = txtBaslik.Text;
                    iss.Icerik = txtIcerik.Text;
                    iss.IsDurumID = 1;
                    iss.IsBaslamaTarih = DateTime.Today;
                    IsBLL.IsEkle(iss);
                    MessageBox.Show("İş Eklendi");
                    txtBaslik.Clear();
                    txtIcerik.Clear();
                }


            }

        }
    }
}
