using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class Mode : Form
    {
        string level = "0";
        public Mode()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level = "0";
            StartForm start = new StartForm( level);
            start.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level = "1";
            StartForm start = new StartForm(level);
            start.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level = "2";
            StartForm start = new StartForm(level);
            start.Show();
            this.Hide();
        }
    }
}
