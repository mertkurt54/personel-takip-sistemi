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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            /*List<DEPARTMAN> liste = new List<DEPARTMAN>();
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
            */
        }
    }
}
