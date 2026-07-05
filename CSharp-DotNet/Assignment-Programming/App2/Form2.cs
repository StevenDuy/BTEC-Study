using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form2 : Form
    {
        public Form2(Invoice invoice)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            labelCustomerName.Text = invoice.CustomerName;
            labelTypeOfCustomer.Text = invoice.TypeOFCustomer;
            labelNumberOfMembers.Text = invoice.NumberOffFamily.ToString() + " People";
            labelLastMonthWater.Text = invoice.LastMonthWater.ToString() + " m³";
            labelThismonthwater.Text = invoice.ThisMonthWater.ToString() + " m³";
            labelTotalWater.Text = invoice.TotalWater.ToString() + " m³";
            labelTotalBill.Text = invoice.Bill.ToString() + " VND";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var Warning = MessageBox.Show("You haven't paid your bill. You want to leave?", "Haven't paid!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Warning == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            buttonPay.BackColor = Color.Green;
            buttonPay.ForeColor = Color.Lime;
            MessageBox.Show("Pay successfull", "The command has execute", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}