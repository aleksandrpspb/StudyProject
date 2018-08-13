using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public new enum Location
        {
            TopLeftCorner,
            TopCenter,
            TopRightCorner,
            Left,
            Center,
            Right,
            ButtomCenterCorner,
            ButtomRightCorner
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            var random = new Random();
            button1.Location = new Point(random.Next(0, panel1.Width - button1.Width), random.Next(0, panel1.Height - button1.Height));

            //var locationY = button1.Location.Y;
            //var locationX = button1.Location.X;

            //var location = (new Random()).Next(0, 7);

            //switch (location)
            //{
            //    case 0:
            //        button1.Location = button1.Location == new Point(20, 50) ? new Point(110, 50) : new Point(20, 50);
            //        break;
            //    case 1:
            //        button1.Location = button1.Location == new Point(110, 50) ? new Point(200, 50) : new Point(110, 50);
            //        break;
            //    case 2:
            //        button1.Location = button1.Location == new Point(200, 50) ? new Point(20, 110) : new Point(200, 50);
            //        break;
            //    case 3:
            //        button1.Location = button1.Location == new Point(20, 110) ? new Point(110, 110) : new Point(20, 110);
            //        break;
            //    case 4:
            //        button1.Location = button1.Location == new Point(110, 110) ? new Point(200, 110) : new Point(110, 110);
            //        break;
            //    case 5:
            //        button1.Location = button1.Location == new Point(200, 110) ? new Point(110, 170) : new Point(200, 110);
            //        break;
            //    case 6:
            //        button1.Location = button1.Location == new Point(110, 170) ? new Point(200, 170) : new Point(110, 170);
            //        break;
            //    case 7:
            //        button1.Location = button1.Location == new Point(200, 170) ? new Point(20, 50) : new Point(200, 170);
            //        break;

            //}

            ////if (locationY != 50)
            ////{
            ////    button1.Location = new Point(200, 50);

            ////}
            ////else
            ////{
            ////    button1.Location = new Point(200, 170);
            ////}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
