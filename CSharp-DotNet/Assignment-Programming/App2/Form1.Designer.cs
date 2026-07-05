namespace App2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            txtNumberOFamily = new TextBox();
            txtLastMonthWater = new TextBox();
            btnCalculator = new Button();
            TxtSearch = new TextBox();
            cbbTypeOfCustomer = new ComboBox();
            txtThisMonthWater = new TextBox();
            txtCustomerName = new TextBox();
            ListViewBill = new ListView();
            CLCustomerName = new ColumnHeader();
            ClTypeOfCustomer = new ColumnHeader();
            ClNumberOfMembers = new ColumnHeader();
            CLLastMonthWater = new ColumnHeader();
            CLThisMonthWater = new ColumnHeader();
            ClTotalWater = new ColumnHeader();
            CLTotalBill = new ColumnHeader();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtNumberOFamily);
            panel1.Controls.Add(txtLastMonthWater);
            panel1.Controls.Add(btnCalculator);
            panel1.Controls.Add(TxtSearch);
            panel1.Controls.Add(cbbTypeOfCustomer);
            panel1.Controls.Add(txtThisMonthWater);
            panel1.Controls.Add(txtCustomerName);
            panel1.Location = new Point(13, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 102);
            panel1.TabIndex = 0;
            // 
            // txtNumberOFamily
            // 
            txtNumberOFamily.BackColor = Color.Gainsboro;
            txtNumberOFamily.Enabled = false;
            txtNumberOFamily.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOFamily.ForeColor = Color.Black;
            txtNumberOFamily.HideSelection = false;
            txtNumberOFamily.ImeMode = ImeMode.NoControl;
            txtNumberOFamily.Location = new Point(4, 67);
            txtNumberOFamily.Margin = new Padding(4, 3, 4, 3);
            txtNumberOFamily.Name = "txtNumberOFamily";
            txtNumberOFamily.PlaceholderText = "Please Number of members";
            txtNumberOFamily.Size = new Size(412, 27);
            txtNumberOFamily.TabIndex = 3;
            txtNumberOFamily.TextAlign = HorizontalAlignment.Center;
            txtNumberOFamily.KeyPress += txtNumberOfFamily_KeyPress;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.BackColor = Color.Gainsboro;
            txtLastMonthWater.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastMonthWater.ForeColor = Color.Black;
            txtLastMonthWater.HideSelection = false;
            txtLastMonthWater.ImeMode = ImeMode.NoControl;
            txtLastMonthWater.Location = new Point(424, 3);
            txtLastMonthWater.Margin = new Padding(4, 3, 4, 3);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.PlaceholderText = "Enter last month’s water meter";
            txtLastMonthWater.Size = new Size(283, 27);
            txtLastMonthWater.TabIndex = 4;
            txtLastMonthWater.TextAlign = HorizontalAlignment.Center;
            txtLastMonthWater.KeyPress += txtLastMonthWater_KeyPress;
            // 
            // btnCalculator
            // 
            btnCalculator.Anchor = AnchorStyles.None;
            btnCalculator.BackColor = Color.Gainsboro;
            btnCalculator.Location = new Point(714, 4);
            btnCalculator.Margin = new Padding(4, 3, 4, 3);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(110, 91);
            btnCalculator.TabIndex = 6;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = false;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.Gainsboro;
            TxtSearch.ForeColor = Color.Black;
            TxtSearch.Location = new Point(425, 69);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Search";
            TxtSearch.Size = new Size(282, 26);
            TxtSearch.TabIndex = 14;
            TxtSearch.TabStop = false;
            TxtSearch.TextAlign = HorizontalAlignment.Center;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // cbbTypeOfCustomer
            // 
            cbbTypeOfCustomer.BackColor = Color.Gainsboro;
            cbbTypeOfCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeOfCustomer.FlatStyle = FlatStyle.Flat;
            cbbTypeOfCustomer.ForeColor = Color.Black;
            cbbTypeOfCustomer.FormattingEnabled = true;
            cbbTypeOfCustomer.Location = new Point(4, 35);
            cbbTypeOfCustomer.Margin = new Padding(4, 3, 4, 3);
            cbbTypeOfCustomer.Name = "cbbTypeOfCustomer";
            cbbTypeOfCustomer.Size = new Size(412, 26);
            cbbTypeOfCustomer.TabIndex = 2;
            cbbTypeOfCustomer.Tag = "";
            cbbTypeOfCustomer.SelectedIndexChanged += cbbTypeOfCustomer_SelectedIndexChanged;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.BackColor = Color.Gainsboro;
            txtThisMonthWater.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThisMonthWater.ForeColor = Color.Black;
            txtThisMonthWater.HideSelection = false;
            txtThisMonthWater.ImeMode = ImeMode.NoControl;
            txtThisMonthWater.Location = new Point(424, 36);
            txtThisMonthWater.Margin = new Padding(4, 3, 4, 3);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.PlaceholderText = "Enter this month’s water meter";
            txtThisMonthWater.Size = new Size(282, 27);
            txtThisMonthWater.TabIndex = 5;
            txtThisMonthWater.TextAlign = HorizontalAlignment.Center;
            txtThisMonthWater.KeyPress += txtThisMonthWater_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.Gainsboro;
            txtCustomerName.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.ForeColor = Color.Black;
            txtCustomerName.HideSelection = false;
            txtCustomerName.ImeMode = ImeMode.NoControl;
            txtCustomerName.Location = new Point(4, 3);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Please enter customer name";
            txtCustomerName.Size = new Size(412, 26);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            txtCustomerName.KeyPress += txtCustomerName_KeyPress;
            // 
            // ListViewBill
            // 
            ListViewBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListViewBill.BackColor = Color.Silver;
            ListViewBill.Columns.AddRange(new ColumnHeader[] { CLCustomerName, ClTypeOfCustomer, ClNumberOfMembers, CLLastMonthWater, CLThisMonthWater, ClTotalWater, CLTotalBill });
            ListViewBill.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListViewBill.ForeColor = Color.Black;
            ListViewBill.FullRowSelect = true;
            ListViewBill.GridLines = true;
            ListViewBill.Location = new Point(12, 120);
            ListViewBill.Name = "ListViewBill";
            ListViewBill.Size = new Size(1723, 606);
            ListViewBill.TabIndex = 13;
            ListViewBill.TabStop = false;
            ListViewBill.UseCompatibleStateImageBehavior = false;
            ListViewBill.ColumnClick += ListViewBill_ColumnClick;
            ListViewBill.SelectedIndexChanged += ListViewBill_SelectedIndexChanged;
            // 
            // CLCustomerName
            // 
            CLCustomerName.Text = "Customer Name";
            CLCustomerName.Width = 280;
            // 
            // ClTypeOfCustomer
            // 
            ClTypeOfCustomer.Text = "Type of customer";
            ClTypeOfCustomer.Width = 280;
            // 
            // ClNumberOfMembers
            // 
            ClNumberOfMembers.Text = "Number of members";
            ClNumberOfMembers.Width = 280;
            // 
            // CLLastMonthWater
            // 
            CLLastMonthWater.Text = "Last month's water meter";
            CLLastMonthWater.Width = 280;
            // 
            // CLThisMonthWater
            // 
            CLThisMonthWater.Text = "This month's water meter";
            CLThisMonthWater.Width = 280;
            // 
            // ClTotalWater
            // 
            ClTotalWater.Text = "Total water used";
            ClTotalWater.Width = 280;
            // 
            // CLTotalBill
            // 
            CLTotalBill.Text = "Total Bill";
            CLTotalBill.Width = 210;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Picture1;
            pictureBox1.Location = new Point(1439, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 97);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1748, 738);
            Controls.Add(pictureBox1);
            Controls.Add(ListViewBill);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1280, 720);
            Name = "Form1";
            Text = "Caculator Water Meter";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtCustomerName;
        private TextBox txtLastMonthWater;
        private ComboBox cbbTypeOfCustomer;
        private TextBox txtThisMonthWater;
        private TextBox txtNumberOFamily;
        private Button btnCalculator;
        private ListView ListViewBill;
        private TextBox TxtSearch;
        private ColumnHeader CLCustomerName;
        private ColumnHeader ClTypeOfCustomer;
        private ColumnHeader ClNumberOfMembers;
        private ColumnHeader CLLastMonthWater;
        private ColumnHeader CLThisMonthWater;
        private ColumnHeader ClTotalWater;
        private ColumnHeader CLTotalBill;
        private PictureBox pictureBox1;
    }
}
