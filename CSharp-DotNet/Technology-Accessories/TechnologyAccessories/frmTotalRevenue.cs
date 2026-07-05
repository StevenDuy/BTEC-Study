using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologyAccessories
{
    public partial class frmTotalRevenue : Form
    {
        public frmTotalRevenue(string productDetails)
        {
            InitializeComponent();
            richTextBox1.Text = productDetails;
            richTextBox1.ReadOnly = true;
        }
    }
}
