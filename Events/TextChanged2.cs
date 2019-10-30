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
    public partial class TextChanged2 : Form
    {
        public TextChanged2()
        {
            InitializeComponent();
        }

        int maxLength = 0;
        private void TxtMetinAlani_TextChanged(object sender, EventArgs e)
        {
            //int kalanKarakter = 500 - txtMetinAlani.TextLength;

            //lblKalanKarakter.Text = kalanKarakter.ToString();
            //if (kalanKarakter <= 0)
            //{
            //    MessageBox.Show("Karakter Hakkınız Bitti");
            //}

            lblKalanKarakter.Text = (maxLength - txtMetinAlani.TextLength).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxLength = Convert.ToInt32(lblKalanKarakter.Text);
        }
    }
}
