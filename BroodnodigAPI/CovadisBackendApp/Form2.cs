using DTO.DailySnack;
using DTO.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovadisBackendApp
{
    public partial class Form2 : Form
    {
        private InfoOrderInfoResponse orderinfo;
        public Form2(InfoOrderInfoResponse orderinfo)
        {
            this.orderinfo = orderinfo;
            InitializeComponent();

            label1.Text = orderinfo.Opmerkingen;
            label4.Text = orderinfo.Alergien;
            label6.Text = orderinfo.Date.Date.ToString();
            label8.Text = orderinfo.Email;
            checkBox1.Checked = orderinfo.HasDailySnack;
            checkBox1.Enabled = false;




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
