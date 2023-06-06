using System;

namespace GameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode mode = new Mode();
            mode.Show();
            this.Hide();
        }
    }
}