using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowLove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Too True = new Too();//调用窗口Too
            True.ShowDialog();
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            btnNo.Location = new Point(r.Next(this.Width - btnNo.Width), r.Next(this.Height - btnNo.Height));
        }
    }
}
