using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from3
{
    public partial class Form1 : Form
    {
        public int brojac = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[brojac];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojac++;

            if (brojac >= imageList1.Images.Count)
            {
                brojac = 0; 
            }

            pictureBox1.Image = imageList1.Images[brojac];
        }
    }
}
