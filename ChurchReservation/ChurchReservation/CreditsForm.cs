using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchReservation
{
    public partial class CreditsForm : Form
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        public string credits;



        private void CreditsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = credits;
            
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;


            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoreForm m = new MoreForm();
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoreForm mn = new MoreForm();
            mn.setting = textBox1.Text;
            this.Close();
            mn.Show();
        }
    }
}
