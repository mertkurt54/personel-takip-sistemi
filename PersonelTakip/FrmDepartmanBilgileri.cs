using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;


namespace PersonelTakip
{
    public partial class FrmDepartmanBilgileri : Form
    {
        public FrmDepartmanBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text.Trim() == "")
                MessageBox.Show("Lütfen Departman Adı Girin");
            else
            {
                DEPARTMAN dpt = new DEPARTMAN();
                dpt.DepartmanAd = txtDepartmanAd.Text;
                DepartmanBLL.DepartmanEkle(dpt);
                MessageBox.Show("Departman Eklendi");
                txtDepartmanAd.Clear();
            }

        }

        private void FrmDepartmanBilgileri_Load(object sender, EventArgs e)
        {

        }
    }
}
