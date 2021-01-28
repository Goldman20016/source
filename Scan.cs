using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goldman_internet_security_pro
{
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            MessageBox.Show("Scan Completed!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = (filename);
            richTextBox1.Text = readfile;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
