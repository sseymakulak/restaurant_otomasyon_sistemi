using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_os
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            PaketForm frm = new PaketForm();
            this.Close();
            frm.Show();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusterilerForm frm = new MusterilerForm();
            this.Close();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            KasaForm frm = new KasaForm();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            MutfakForm frm = new MutfakForm();
            this.Close();
            frm.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            this.Close();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm frm = new AyarlarForm();
            this.Close();
            frm.Show();
        }

        private void btnMasalar_Click_1(object sender, EventArgs e)
        {
            MasaForm frm = new MasaForm();
            this.Close();
            frm.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinizden Emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRezervasyon_Click_1(object sender, EventArgs e)
        {
            RezervasyonForm frm = new RezervasyonForm();
            this.Close();
            frm.Show();
        }
    }
}
