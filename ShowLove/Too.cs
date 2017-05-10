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
    public partial class Too : Form
    {
        public Too()
        {
            InitializeComponent();
        }

        private void Too_Load(object sender, EventArgs e)
        {
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            double x, y, r;
            int w = e.ClipRectangle.Width;
            int h = e.ClipRectangle.Height;
            //g.DrawLine(p, 0, 0, 20, 20);
            //g.DrawArc(p, this.Bounds, 30, 50);
            for (int i = 0; i <= 90; i++)
            {
                for (int j = 0; j <= 90; j++)
                {
                    //转换为直角坐标系，设置偏移量，使图像居中
                    r = Math.PI / 45 * i * (1 - Math.Sin(Math.PI / 45 * j)) * 19;
                    x = r * Math.Cos(Math.PI / 45 * j) * Math.Sin(Math.PI / 45 * i) + w / 2;
                    y = -r * Math.Sin(Math.PI / 45 * j) + h / 4;
                    using (Brush brush = new SolidBrush(Color.Red))
                    {
                        e.Graphics.FillEllipse(brush, (float)x, (float)y, 2f, 2f);
                        e.Graphics.FillEllipse(brush, (float)x, (float)y, 1f, 1f);
                    }
                }
            }
            /*
            for (var q = 0; q < 500; q++)
            {
                start += Math.PI * 2 / 500;
                end = start + Math.PI * 2 / 500;
                r = a * (1 - Math.sin(start));  //心形极坐标表示法
                con.arc(0, 0, r, start, end, false);
            }*/
        }
    }
}
