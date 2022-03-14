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
    public partial class Viewing : Form
    {
        public Viewing()
        {
            InitializeComponent();
        }


        public string viewing;

        private void button3_Click(object sender, EventArgs e)
        {
            ViewingForm vf = new ViewingForm();
            vf.viewingform = textBox1.Text;
            this.Hide();
            vf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaptistViewingForm bvf = new BaptistViewingForm();
            bvf.baptistviewing = textBox1.Text;
            this.Hide();
            bvf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuneralViewingForm fvf = new FuneralViewingForm();
            fvf.funeralviewing = textBox1.Text;
            this.Hide();
            fvf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoreForm mf = new MoreForm();
            mf.setting = textBox1.Text;
            this.Hide();
            mf.Show();

        }

        private void Viewing_Load(object sender, EventArgs e)
        {
            textBox1.Text = viewing;
        }
    }
}
