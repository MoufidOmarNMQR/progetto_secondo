using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_secondo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            progressBar1.Value++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 10;
            progressBar1.Minimum = 0;

            lblCIAO.Text = "CIAONE";
        }
    }
}
