using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;
using System.Linq;
using System.IO;

namespace PersonelTakip
{
    public partial class FrmPersonelBilgileri : Form
    {
        public FrmPersonelBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User no boş");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                {
                MessageBox.Show("Lütfen UserNo Değiştirin");
                }
            else
            {
                MessageBox.Show("Bu UserNo kullanılabilir");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        PersonelDTO dto = new PersonelDTO();
        public PersonelDetayDTO detay = new PersonelDetayDTO();
        public bool isUpdate = false;
        string resim2 = "";
        
        private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
        {
            dto = PersonelBLL.GetAll();
            cmbDepartman.DataSource = dto.Departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAD";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;
            cmbPozisyon.DataSource = dto.Pozisyonlar;
            cmbPozisyon.DisplayMember = "PozisyonAD";
            cmbPozisyon.ValueMember = "ID";
            cmbPozisyon.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;
            if(isUpdate)
            {
                txtAd.Text = detay.Ad;
                txtAdres.Text = detay.Adres;
                txtMaas.Text = detay.Maas.ToString();
                txtPassword.Text = detay.password;
                txtSoyad.Text = detay.Soyad;
                txtUserNo.Text = detay.UserNo.ToString();
                chisAdmin.Checked = Convert.ToBoolean(detay.isAdmin);
                cmbDepartman.SelectedValue = detay.DepartmanID;
                cmbPozisyon.SelectedValue = detay.PozisyonID;
                resim2 = Application.StartupPath + "\\Resimler\\" + detay.Resim;
                txtResim.Text = resim2;
                pictureBox1.Load(resim2);

                if (!UserStatic.isAdmin)
                {
                    txtAd.Enabled = false;
                    txtMaas.Enabled = false;
                    txtSoyad.Enabled = false;
                    txtUserNo.Enabled = false;
                    chisAdmin.Enabled = false;
                    cmbDepartman.Enabled = false;
                    cmbPozisyon.Enabled = false;
                    

                }

            }
        }
        bool combofull = false;
        string resimad = "";
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtResim.Text = openFileDialog1.FileName;
                resimad = Guid.NewGuid().ToString();
                resimad += openFileDialog1.SafeFileName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User no boş");
            else if (!isUpdate && PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen UserNo Değiştirin");
            }
            else if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User No");
            else if (txtAd.Text.Trim() == "")
                MessageBox.Show("Ad");
            else if (txtMaas.Text.Trim() == "")
                MessageBox.Show("Maas");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Şifre");
            else if (txtResim.Text.Trim() == "")
                MessageBox.Show("Resim");
            else if (cmbDepartman.SelectedIndex==-1)
                MessageBox.Show("Departman");
            else if (cmbPozisyon.SelectedIndex==-1)
                MessageBox.Show("Pozisyon");
            else
            {

                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Emin misinz?", "Dikkat", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        PersonelDetayDTO pr = new PersonelDetayDTO();
                        pr.PersonelID = detay.PersonelID;
                        pr.UserNo = Convert.ToInt32(txtUserNo.Text);
                        pr.Ad = txtAd.Text;
                        pr.Soyad = txtSoyad.Text;
                        pr.Maas = Convert.ToInt32(txtMaas.Text);
                        pr.isAdmin = chisAdmin.Checked;
                        pr.password = txtPassword.Text;
                        pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
                        pr.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                        pr.DogumTarihi = dateTimePicker1.Value;
                        pr.Adres = txtAdres.Text;
                        pr.Resim = resimad;
                        if (resim2 != txtResim.Text)
                        {
                            pr.Resim = resimad;
                            if (File.Exists(resim2))
                                File.Delete(resim2);
                            File.Copy(txtResim.Text, @"Resimler\\" + resimad);



                        }
                        else
                            pr.Resim = detay.Resim;
                        PersonelBLL.PersonelGuncelle(pr);
                        MessageBox.Show("Güncellendi");
                        this.Close();
                        
                    }
                }

                else
                {
                    PERSONEL pr = new PERSONEL();
                    pr.UserNo = Convert.ToInt32(txtUserNo.Text);
                    pr.Ad = txtAd.Text;
                    pr.Soyad = txtSoyad.Text;
                    pr.Maas = Convert.ToInt32(txtMaas.Text);
                    pr.isAdmin = chisAdmin.Checked;
                    pr.Password = txtPassword.Text;
                    pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
                    pr.DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue);
                    pr.DogumGunu = dateTimePicker1.Value;
                    pr.Adres = txtAdres.Text;
                    pr.Resim = resimad;
                    PersonelBLL.PersonelEkle(pr);
                    File.Copy(txtResim.Text, @"Resimler\\" + resimad);
                    MessageBox.Show("Personel Eklendi");
                    txtUserNo.Clear();
                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtMaas.Clear();
                    chisAdmin.Checked = false;
                    txtPassword.Clear();
                    cmbPozisyon.SelectedIndex = -1;
                    cmbPozisyon.DataSource = dto.Pozisyonlar;
                    cmbDepartman.SelectedIndex = -1;
                    dateTimePicker1.Value = DateTime.Today;
                    txtAdres.Clear();
                    txtResim.Clear();
                    resimad = "";
                }



            }


        }
    }
}
