using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int starPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starPoint += 1;
            progressBar1.Value = starPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                new Login().Show();
            }
        }
    }
}
