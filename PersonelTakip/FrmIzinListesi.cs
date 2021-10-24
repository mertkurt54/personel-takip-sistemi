using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class FrmIzinListesi : Form
    {
        public FrmIzinListesi()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIzinSure_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIzinSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmIzinBilgileri frm = new FrmIzinBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmIzinBilgileri frm = new FrmIzinBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
