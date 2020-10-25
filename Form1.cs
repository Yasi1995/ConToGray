using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01
{

    public partial class Form1 : Form
    {
        Preprocessing p = new Preprocessing();
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            p.LoadOriginalImage();
            pictureBox1.ImageLocation = "1.jpg";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.GrayScalelImage();
            pictureBox2.ImageLocation = "2.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.ExtractImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            p.ExtractImage();

        }
    }
}
