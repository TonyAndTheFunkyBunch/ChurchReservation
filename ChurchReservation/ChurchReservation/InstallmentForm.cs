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
    public partial class InstallmentForm : Form
    {
        public InstallmentForm()
        {
            InitializeComponent();
        }

        public string installmentform;

        private void button2_Click(object sender, EventArgs e)
        {
            FuneralInstallment fi = new FuneralInstallment();
            fi.funeralinstallment = textBox1.Text;
            fi.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WeddingInstallment wi = new WeddingInstallment();
            wi.weddinginstallment = textBox1.Text;
            wi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaptismInstallment bi = new BaptismInstallment();
            bi.baptistinstallment = textBox1.Text;
            bi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoreForm mff = new MoreForm();
            mff.setting = textBox1.Text;
            mff.Show();
            this.Hide();
        }

        private void InstallmentForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = installmentform;
        }
    }
}
