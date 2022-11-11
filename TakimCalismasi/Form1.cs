using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakimCalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bismillah her hayrın başıdır");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Benim ilk takım çalışmam.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selimin takım çalışması");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enesin kendi yaptığı ilk takım çalışması");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anıl'ın takım çalışmasi.");
        }
    }
}
