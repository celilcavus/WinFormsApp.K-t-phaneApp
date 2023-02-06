using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.KütüphaneApp.HomePage
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        private void sifreGoster_CheckStateChanged(object sender, EventArgs e)
        {
            if (sifreGoster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
                txtSifre.UseSystemPasswordChar = true;
        }
    }
}
