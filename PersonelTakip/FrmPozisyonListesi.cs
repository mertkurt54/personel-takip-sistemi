using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FrmPozisyonListesi : Form
    {
        public FrmPozisyonListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmPozisyonBilgileri frm = new FrmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmPozisyonBilgileri frm = new FrmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
