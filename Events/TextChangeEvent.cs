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
    public partial class TextChangeEvent : Form
    {
        public TextChangeEvent()
        {
            InitializeComponent();
        }

        private void TxtYaziAlani_TextChanged(object sender, EventArgs e)
        {
            lblYaziAlani.Text = txtYaziAlani.Text;
        }
    }
}
