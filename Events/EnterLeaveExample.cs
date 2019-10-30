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
    public partial class EnterLeaveExample : Form
    {
        public EnterLeaveExample()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            textBox1.BackColor = randomColor;
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = default;
        }

        private void TextBox2_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            textBox2.BackColor = randomColor;
        }

        private void TextBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = default;
        }
    }
}
