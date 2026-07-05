using Microsoft.VisualBasic.Devices;
using System.DirectoryServices;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using static App2.Form1;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace App2
{
    public partial class Form1 : Form
    {
        public List<Invoice> Invoices = new List<Invoice>();
        public const decimal VAT = 0.1m;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        // clear all text box

        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }
        }

        //Calculator

        private (decimal, decimal) Calculator(string TypeOfCustomer, int NumberOfFamily, decimal LastMonthWater, decimal ThisMonthWater)
        {
            decimal Consumption = ThisMonthWater - LastMonthWater;
            decimal WaterMoney;
            if (TypeOfCustomer.Equals("Household customer"))
            {
                decimal AverageWaterUsed = Consumption / NumberOfFamily;
                WaterMoney = BillWaterForHouseHold(AverageWaterUsed, Consumption);
            }
            else if (TypeOfCustomer.Equals("Adminstration agency, public services"))
            {
                WaterMoney = (Consumption * 9955);
                WaterMoney += (WaterMoney * VAT);
            }
            else if (TypeOfCustomer.Equals("Production units"))
            {
                WaterMoney = (Consumption * 11615);
                WaterMoney += (WaterMoney * VAT);
            }
            else
            {
                WaterMoney = (Consumption * 22068);
                WaterMoney += (WaterMoney * VAT);
            }
            return (Consumption, WaterMoney);
        }
        private decimal BillWaterForHouseHold(decimal Average, decimal Consumption)
        {
            decimal WaterMoney = 0;
            if (Average >= 0 && Average < 10)
            {
                WaterMoney = Consumption * 5973;
            }
            else if (Average >= 10 && Average < 20)
            {
                WaterMoney = Consumption * 7052;
            }
            else if (Average >= 20 && Average < 30)
            {
                WaterMoney = Consumption * 8699;
            }
            else
            {
                WaterMoney = Consumption * 15929;
            }
            return WaterMoney + WaterMoney * VAT;
        }

        //check type char

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOfFamily_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLastMonthWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtThisMonthWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //Calculator click

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            string CustomerName = txtCustomerName.Text.Trim();
            CustomerName = Regex.Replace(CustomerName, @"\s+", " ");
            string TypeOfCustomer = cbbTypeOfCustomer.Text;
            string NumberOfFamily = txtNumberOFamily.Text;
            string LastMonthWater = txtLastMonthWater.Text;
            string ThisMonthWater = txtThisMonthWater.Text;

            //error when click calculator

            if (true)
            {
                if (string.IsNullOrWhiteSpace(CustomerName)) // check null name
                {
                    txtCustomerName.BackColor = Color.Red;
                    MessageBox.Show("Please enter customer name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.BackColor = Color.Gainsboro;
                    return;
                }
                if (TypeOfCustomer.Equals("Household customer")) // check null type
                {
                    txtNumberOFamily.Enabled = true;
                    if (string.IsNullOrEmpty(NumberOfFamily))
                    {
                        txtNumberOFamily.BackColor = Color.Red;
                        MessageBox.Show("Please enter number of family", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumberOFamily.BackColor = Color.Gainsboro;
                        return;
                    }
                }
                if (string.IsNullOrEmpty(LastMonthWater)) // check null last month
                {
                    txtLastMonthWater.BackColor = Color.Red;
                    MessageBox.Show("Please enter last month's water meter", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastMonthWater.BackColor = Color.Gainsboro;
                    return;
                }
                if (string.IsNullOrEmpty(ThisMonthWater)) // check null this month
                {
                    txtThisMonthWater.BackColor = Color.Red;
                    MessageBox.Show("Please enter this month's water meter", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtThisMonthWater.BackColor = Color.Gainsboro;
                    return;
                }
            }

            // transform to number

            Decimal ValueLastMonthWater;
            decimal ValueThisMonthWater;
            if (!decimal.TryParse(txtLastMonthWater.Text, out ValueLastMonthWater))
            {
                txtLastMonthWater.BackColor = Color.Red;
                MessageBox.Show("Wrong syntax when type value. Please enter interger or decimal", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastMonthWater.BackColor = Color.Gainsboro;
                return;
            }
            if (!decimal.TryParse(txtThisMonthWater.Text, out ValueThisMonthWater))
            {
                txtThisMonthWater.BackColor = Color.Red;
                MessageBox.Show("Wrong syntax when type value. Please enter interger or decimal", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThisMonthWater.BackColor = Color.Gainsboro;
                return;
            }
            int ValueNumberOfMembers;
            int.TryParse(NumberOfFamily, out ValueNumberOfMembers);

            // check last month this month if this month smaller than

            if (ValueThisMonthWater < ValueLastMonthWater)
            {
                txtThisMonthWater.BackColor = Color.Red;
                txtLastMonthWater.BackColor = Color.Red;
                MessageBox.Show("No way! How this month's water meter smaller than last month's water meter. Let's try again!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThisMonthWater.BackColor = Color.Gainsboro;
                txtLastMonthWater.BackColor = Color.Gainsboro;
                return;
            }

            // show list view

            var ShowBill = Calculator(TypeOfCustomer, ValueNumberOfMembers, ValueLastMonthWater, ValueThisMonthWater);
            ListViewItem item = new ListViewItem(CustomerName);
            item.SubItems.Add(TypeOfCustomer);
            item.SubItems.Add(NumberOfFamily);
            item.SubItems.Add(LastMonthWater);
            item.SubItems.Add(ThisMonthWater);
            item.SubItems.Add(ShowBill.Item1.ToString());
            item.SubItems.Add(ShowBill.Item2.ToString());
            ListViewBill.Items.Add(item);

            // save list view to form 2

            Invoice invoice = new Invoice
            {
                CustomerName = CustomerName,
                TypeOFCustomer = TypeOfCustomer,
                NumberOffFamily = ValueNumberOfMembers,
                LastMonthWater = ValueLastMonthWater,
                ThisMonthWater = ValueThisMonthWater,
                TotalWater = ShowBill.Item1,
                Bill = ShowBill.Item2,
            };
            Invoices.Add(invoice);
            txtCustomerName.Text = null;
            txtLastMonthWater.Text = null;
            txtThisMonthWater.Text = null;
            txtNumberOFamily.Text = "1";
        }

        //form1

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbTypeOfCustomer.Items.Add("Household customer");
            cbbTypeOfCustomer.Items.Add("Administrative agency, public services");
            cbbTypeOfCustomer.Items.Add("Production units");
            cbbTypeOfCustomer.Items.Add("Business services");
            cbbTypeOfCustomer.SelectedIndex = 0;
            ListViewBill.View = View.Details;
        }

        // on off numberoffamily

        private void cbbTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TypeOfCustomer = cbbTypeOfCustomer.Text;
            string NumberOffamily = txtNumberOFamily.Text;
            if (TypeOfCustomer.Equals("Household customer"))
            {
                txtNumberOFamily.Enabled = true;
                txtNumberOFamily.Text = null;
                txtNumberOFamily.PlaceholderText = "Please enter number of family members";
            }
            else
            {
                txtNumberOFamily.Enabled = false;
                txtNumberOFamily.Text = "1";
            }
        }

        // search bar

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string Search = TxtSearch.Text.Trim();
            ListViewBill.Items.Clear();
            bool FoundResult = false;
            if (Search == "")
            {
                foreach (Invoice invoice in Invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.TypeOFCustomer.ToString());
                    item.SubItems.Add(invoice.NumberOffFamily.ToString());
                    item.SubItems.Add(invoice.LastMonthWater.ToString());
                    item.SubItems.Add(invoice.ThisMonthWater.ToString());
                    item.SubItems.Add(invoice.TotalWater.ToString());
                    item.SubItems.Add(invoice.Bill.ToString());
                    ListViewBill.Items.Add(item);
                }
                FoundResult = true;
            }
            else
            {
                foreach (Invoice invoice in Invoices)
                {
                    if (invoice.CustomerName.IndexOf(Search, StringComparison.OrdinalIgnoreCase) >= 0 && !string.IsNullOrEmpty(invoice.CustomerName))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.TypeOFCustomer.ToString());
                        item.SubItems.Add(invoice.NumberOffFamily.ToString());
                        item.SubItems.Add(invoice.LastMonthWater.ToString());
                        item.SubItems.Add(invoice.ThisMonthWater.ToString());
                        item.SubItems.Add(invoice.TotalWater.ToString());
                        item.SubItems.Add(invoice.Bill.ToString());
                        ListViewBill.Items.Add(item);
                        FoundResult = true;
                    }
                }
            }
            if (!FoundResult)
            {
                ListViewItem item = new ListViewItem("No results found");
                ListViewBill.Items.Add(item);
            }
        }

        // softing collumn

        private void ListViewBill_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewBill.ListViewItemSorter = new ListComparer(e.Column);
        }

        // cast to form 2

        private void ListViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewBill.SelectedItems.Count > 0)
            {
                var ExportBill = ListViewBill.SelectedItems[0].SubItems;
                Invoice invoice = new Invoice
                {
                    CustomerName = ExportBill[0].Text,
                    TypeOFCustomer = ExportBill[1].Text,
                    NumberOffFamily = Convert.ToInt32(ExportBill[2].Text),
                    LastMonthWater = Convert.ToDecimal(ExportBill[3].Text),
                    ThisMonthWater = Convert.ToDecimal(ExportBill[4].Text),
                    TotalWater = Convert.ToDecimal(ExportBill[5].Text),
                    Bill = Convert.ToDecimal(ExportBill[6].Text),
                };
                Form2 form2 = new Form2(invoice);
                form2.ShowDialog();
            }
        }
    }

    // bill contains will be used to form 2

    public class Invoice
    {
        public string CustomerName { get; set; }
        public string TypeOFCustomer { get; set; }
        public decimal NumberOffFamily { get; set; }
        public decimal LastMonthWater { get; set; }
        public decimal ThisMonthWater { get; set; }
        public decimal TotalWater { get; set; }
        public decimal Bill { get; set; }
    }
}