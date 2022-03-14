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
    public partial class FuneralFinish : Form
    {
        public FuneralFinish()
        {
            InitializeComponent();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Show();
            MessageBox.Show("Congratulations! To Confirm Your Work. Just go to MORE > Inquiries");
        }
    }
}
