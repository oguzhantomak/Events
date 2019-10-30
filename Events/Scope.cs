using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Scope : Form
    {
        public Scope()
        {
            InitializeComponent();
        }
        int sayi;
        private void BtnArtir_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();
        }

        private void BtnEksilt_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(label1.Text);
            sayi--;
            label1.Text = sayi.ToString();
        }
    }
}
