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
    public partial class EditForms : Form
    {
        public EditForms()
        {
            InitializeComponent();
        }

        public string editform;



        private void button1_Click(object sender, EventArgs e)
        {
            BaptismEdit ew = new BaptismEdit();
            ew.baptismEdit = textBox1.Text;
            this.Hide();
            ew.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoreForm ee = new MoreForm();
            ee.setting = textBox1.Text;
            this.Hide();
            ee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WeddingEdit m = new WeddingEdit();
            m.weddingedit = textBox1.Text;
            this.Hide();
            m.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuneralEdit Fe = new FuneralEdit();
            Fe.funeraledit = textBox1.Text;
            this.Close();
            Fe.Show();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm();
            pf.paymentform = textBox1.Text;
            this.Close();
            pf.Show();
        }

        private void EditForms_Load(object sender, EventArgs e)
        {
            textBox1.Text = editform;
        }
    }
}
