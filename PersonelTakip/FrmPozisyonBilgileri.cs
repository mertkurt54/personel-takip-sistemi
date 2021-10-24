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
    public partial class FrmPozisyonBilgileri : Form
    {
        public FrmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtPozisyonAd_TextChanged(object sender, EventArgs e)
        {

        }
        List<DEPARTMAN> departmanlar = new List<DEPARTMAN>();
        private void FrmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            /*departmanlar = DAL.DAO.DepartmanDAO.DepartmanGetir();*/
        }
    }
}
