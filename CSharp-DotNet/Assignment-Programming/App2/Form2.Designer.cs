namespace App2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            buttonPay = new Button();
            labelWaterMoneyBill = new Label();
            labelInformation = new Label();
            labelCustomerName = new Label();
            labelTypeOfCustomer = new Label();
            labelNumberOfMembers = new Label();
            labelLastMonthWater = new Label();
            labelThismonthwater = new Label();
            labelTotalWater = new Label();
            labelTotalBill = new Label();
            labelAmount = new Label();
            labelValueOfCustomerName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.Location = new Point(554, 0);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(33, 31);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonPay
            // 
            buttonPay.Location = new Point(12, 603);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(562, 93);
            buttonPay.TabIndex = 1;
            buttonPay.Text = "Pay";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // labelWaterMoneyBill
            // 
            labelWaterMoneyBill.AutoSize = true;
            labelWaterMoneyBill.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWaterMoneyBill.Location = new Point(129, 9);
            labelWaterMoneyBill.Name = "labelWaterMoneyBill";
            labelWaterMoneyBill.Size = new Size(307, 46);
            labelWaterMoneyBill.TabIndex = 3;
            labelWaterMoneyBill.Text = "Water money bill";
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInformation.Location = new Point(13, 55);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(144, 31);
            labelInformation.TabIndex = 4;
            labelInformation.Text = "Information";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(256, 100);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(17, 23);
            labelCustomerName.TabIndex = 5;
            labelCustomerName.Text = "-";
            labelCustomerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTypeOfCustomer
            // 
            labelTypeOfCustomer.AutoSize = true;
            labelTypeOfCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTypeOfCustomer.Location = new Point(256, 175);
            labelTypeOfCustomer.Name = "labelTypeOfCustomer";
            labelTypeOfCustomer.Size = new Size(17, 23);
            labelTypeOfCustomer.TabIndex = 6;
            labelTypeOfCustomer.Text = "-";
            labelTypeOfCustomer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelNumberOfMembers
            // 
            labelNumberOfMembers.AutoSize = true;
            labelNumberOfMembers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNumberOfMembers.Location = new Point(256, 250);
            labelNumberOfMembers.Name = "labelNumberOfMembers";
            labelNumberOfMembers.Size = new Size(17, 23);
            labelNumberOfMembers.TabIndex = 7;
            labelNumberOfMembers.Text = "-";
            labelNumberOfMembers.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelLastMonthWater
            // 
            labelLastMonthWater.AutoSize = true;
            labelLastMonthWater.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastMonthWater.Location = new Point(256, 325);
            labelLastMonthWater.Name = "labelLastMonthWater";
            labelLastMonthWater.Size = new Size(17, 23);
            labelLastMonthWater.TabIndex = 8;
            labelLastMonthWater.Text = "-";
            labelLastMonthWater.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelThismonthwater
            // 
            labelThismonthwater.AutoSize = true;
            labelThismonthwater.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThismonthwater.Location = new Point(256, 400);
            labelThismonthwater.Name = "labelThismonthwater";
            labelThismonthwater.Size = new Size(17, 23);
            labelThismonthwater.TabIndex = 9;
            labelThismonthwater.Text = "-";
            labelThismonthwater.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalWater
            // 
            labelTotalWater.AutoSize = true;
            labelTotalWater.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalWater.Location = new Point(256, 475);
            labelTotalWater.Name = "labelTotalWater";
            labelTotalWater.Size = new Size(17, 23);
            labelTotalWater.TabIndex = 10;
            labelTotalWater.Text = "-";
            labelTotalWater.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalBill
            // 
            labelTotalBill.AutoSize = true;
            labelTotalBill.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalBill.Location = new Point(256, 550);
            labelTotalBill.Name = "labelTotalBill";
            labelTotalBill.Size = new Size(17, 23);
            labelTotalBill.TabIndex = 11;
            labelTotalBill.Text = "-";
            labelTotalBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAmount.Location = new Point(364, 55);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(102, 31);
            labelAmount.TabIndex = 12;
            labelAmount.Text = "Amount";
            // 
            // labelValueOfCustomerName
            // 
            labelValueOfCustomerName.AutoSize = true;
            labelValueOfCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelValueOfCustomerName.Location = new Point(18, 100);
            labelValueOfCustomerName.Name = "labelValueOfCustomerName";
            labelValueOfCustomerName.Size = new Size(139, 23);
            labelValueOfCustomerName.TabIndex = 13;
            labelValueOfCustomerName.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 175);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 14;
            label2.Text = "Type of customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 250);
            label3.Name = "label3";
            label3.Size = new Size(223, 23);
            label3.TabIndex = 15;
            label3.Text = "Number of family members:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 325);
            label4.Name = "label4";
            label4.Size = new Size(208, 23);
            label4.TabIndex = 16;
            label4.Text = "Last month's water meter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 400);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 17;
            label5.Text = "This month's water meter:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 475);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 18;
            label6.Text = "Total water used:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 550);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 19;
            label7.Text = "Total bill:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(586, 708);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelValueOfCustomerName);
            Controls.Add(labelAmount);
            Controls.Add(labelTotalBill);
            Controls.Add(labelTotalWater);
            Controls.Add(labelThismonthwater);
            Controls.Add(labelLastMonthWater);
            Controls.Add(labelNumberOfMembers);
            Controls.Add(labelTypeOfCustomer);
            Controls.Add(labelCustomerName);
            Controls.Add(labelInformation);
            Controls.Add(labelWaterMoneyBill);
            Controls.Add(buttonPay);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Button buttonPay;
        private Label labelWaterMoneyBill;
        private Label labelInformation;
        private Label labelCustomerName;
        private Label labelTypeOfCustomer;
        private Label labelNumberOfMembers;
        private Label labelLastMonthWater;
        private Label labelThismonthwater;
        private Label labelTotalWater;
        private Label labelTotalBill;
        private Label labelAmount;
        private Label labelValueOfCustomerName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}