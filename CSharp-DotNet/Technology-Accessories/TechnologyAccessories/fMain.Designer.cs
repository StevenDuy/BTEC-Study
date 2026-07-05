namespace TechnologyAccessories
{
    partial class fMain
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
            tpMain = new TabControl();
            tpPro = new TabPage();
            tbPup = new TextBox();
            lbPup = new Label();
            btProEx = new Button();
            btBro = new Button();
            tbProSearch = new TextBox();
            lbSearch = new Label();
            pbPro = new PictureBox();
            tbProQua = new TextBox();
            lbProQua = new Label();
            tbProPrice = new TextBox();
            lbProPrice = new Label();
            tbProNa = new TextBox();
            lbProNa = new Label();
            btProUp = new Button();
            btProDel = new Button();
            btProAdd = new Button();
            lvPro = new ListView();
            tpCus = new TabPage();
            btCusEx = new Button();
            tbCusSearch = new TextBox();
            lbCusSearch = new Label();
            tbCusPh = new TextBox();
            lbCusPh = new Label();
            tbCusAdd = new TextBox();
            lbCusAdd = new Label();
            tbCusNa = new TextBox();
            lbCusNa = new Label();
            btCusUp = new Button();
            btCusDel = new Button();
            btCusAdd = new Button();
            lvCus = new ListView();
            tpEm = new TabPage();
            lbEmSearch = new Label();
            tbEmSearch = new TextBox();
            lbEmPass = new Label();
            tbEmPass = new TextBox();
            cbbEmRo = new ComboBox();
            lbEmUser = new Label();
            tbEmUser = new TextBox();
            tbEmPh = new TextBox();
            lbEmPh = new Label();
            tbEmAdd = new TextBox();
            lbEmAdd = new Label();
            lbEmRo = new Label();
            tbEmNa = new TextBox();
            lbEmNa = new Label();
            btEmUp = new Button();
            btEmDel = new Button();
            btEmAdd = new Button();
            lvEm = new ListView();
            tpOr = new TabPage();
            lbTotalBill = new Label();
            tbTotalBill = new TextBox();
            lbOrP = new Label();
            tbOrP = new TextBox();
            lbOrA = new Label();
            tbOrA = new TextBox();
            lbOrDa = new Label();
            cbbOrEmNa = new ComboBox();
            cbbOrCusNa = new ComboBox();
            cbbOrProNa = new ComboBox();
            lbOrEmNa = new Label();
            lbOrCusNa = new Label();
            lbOrCusID = new Label();
            tbOrCusID = new TextBox();
            lbOrProNa = new Label();
            lbOrProID = new Label();
            tbOrProID = new TextBox();
            dtpkDate = new DateTimePicker();
            tbOrSearch = new TextBox();
            lbOrSearch = new Label();
            btOrUp = new Button();
            btOrDel = new Button();
            btOrAdd = new Button();
            lvOr = new ListView();
            tpMain.SuspendLayout();
            tpPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPro).BeginInit();
            tpCus.SuspendLayout();
            tpEm.SuspendLayout();
            tpOr.SuspendLayout();
            SuspendLayout();
            // 
            // tpMain
            // 
            tpMain.Controls.Add(tpPro);
            tpMain.Controls.Add(tpCus);
            tpMain.Controls.Add(tpEm);
            tpMain.Controls.Add(tpOr);
            tpMain.Dock = DockStyle.Fill;
            tpMain.Location = new Point(0, 0);
            tpMain.Name = "tpMain";
            tpMain.SelectedIndex = 0;
            tpMain.Size = new Size(1262, 673);
            tpMain.TabIndex = 0;
            tpMain.Selecting += tpMain_Selecting;
            // 
            // tpPro
            // 
            tpPro.BackColor = Color.Gainsboro;
            tpPro.Controls.Add(tbPup);
            tpPro.Controls.Add(lbPup);
            tpPro.Controls.Add(btProEx);
            tpPro.Controls.Add(btBro);
            tpPro.Controls.Add(tbProSearch);
            tpPro.Controls.Add(lbSearch);
            tpPro.Controls.Add(pbPro);
            tpPro.Controls.Add(tbProQua);
            tpPro.Controls.Add(lbProQua);
            tpPro.Controls.Add(tbProPrice);
            tpPro.Controls.Add(lbProPrice);
            tpPro.Controls.Add(tbProNa);
            tpPro.Controls.Add(lbProNa);
            tpPro.Controls.Add(btProUp);
            tpPro.Controls.Add(btProDel);
            tpPro.Controls.Add(btProAdd);
            tpPro.Controls.Add(lvPro);
            tpPro.Location = new Point(4, 29);
            tpPro.Name = "tpPro";
            tpPro.Padding = new Padding(3);
            tpPro.Size = new Size(1254, 640);
            tpPro.TabIndex = 0;
            tpPro.Text = "Product Management";
            // 
            // tbPup
            // 
            tbPup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPup.Location = new Point(940, 270);
            tbPup.Name = "tbPup";
            tbPup.PlaceholderText = "Enter purchase price to add";
            tbPup.Size = new Size(306, 27);
            tbPup.TabIndex = 19;
            tbPup.KeyPress += tbPup_KeyPress;
            // 
            // lbPup
            // 
            lbPup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbPup.AutoSize = true;
            lbPup.Location = new Point(940, 245);
            lbPup.Name = "lbPup";
            lbPup.Size = new Size(103, 20);
            lbPup.TabIndex = 18;
            lbPup.Text = "Purchase Price";
            // 
            // btProEx
            // 
            btProEx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btProEx.Location = new Point(940, 385);
            btProEx.Name = "btProEx";
            btProEx.Size = new Size(70, 30);
            btProEx.TabIndex = 17;
            btProEx.Text = "Export";
            btProEx.UseVisualStyleBackColor = true;
            btProEx.Click += Export_Click;
            // 
            // btBro
            // 
            btBro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btBro.Location = new Point(1174, 385);
            btBro.Name = "btBro";
            btBro.Size = new Size(70, 30);
            btBro.TabIndex = 16;
            btBro.Text = "Browse";
            btBro.UseVisualStyleBackColor = true;
            btBro.Click += btBro_Click;
            // 
            // tbProSearch
            // 
            tbProSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbProSearch.Location = new Point(940, 350);
            tbProSearch.Name = "tbProSearch";
            tbProSearch.PlaceholderText = "Type keyword to search";
            tbProSearch.Size = new Size(306, 27);
            tbProSearch.TabIndex = 14;
            tbProSearch.TextChanged += tbProSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(940, 325);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 13;
            lbSearch.Text = "Search";
            // 
            // pbPro
            // 
            pbPro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbPro.Location = new Point(940, 385);
            pbPro.Name = "pbPro";
            pbPro.Size = new Size(304, 191);
            pbPro.SizeMode = PictureBoxSizeMode.Zoom;
            pbPro.TabIndex = 10;
            pbPro.TabStop = false;
            // 
            // tbProQua
            // 
            tbProQua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbProQua.Location = new Point(940, 110);
            tbProQua.Name = "tbProQua";
            tbProQua.PlaceholderText = "Enter quantity to add";
            tbProQua.Size = new Size(306, 27);
            tbProQua.TabIndex = 9;
            tbProQua.KeyPress += tbProQua_KeyPress;
            // 
            // lbProQua
            // 
            lbProQua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbProQua.AutoSize = true;
            lbProQua.Location = new Point(940, 85);
            lbProQua.Name = "lbProQua";
            lbProQua.Size = new Size(65, 20);
            lbProQua.TabIndex = 8;
            lbProQua.Text = "Quantity";
            // 
            // tbProPrice
            // 
            tbProPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbProPrice.Location = new Point(940, 190);
            tbProPrice.Name = "tbProPrice";
            tbProPrice.PlaceholderText = "Enter price to add";
            tbProPrice.Size = new Size(306, 27);
            tbProPrice.TabIndex = 7;
            tbProPrice.KeyPress += tbProPrice_KeyPress;
            // 
            // lbProPrice
            // 
            lbProPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbProPrice.AutoSize = true;
            lbProPrice.Location = new Point(940, 165);
            lbProPrice.Name = "lbProPrice";
            lbProPrice.Size = new Size(41, 20);
            lbProPrice.TabIndex = 6;
            lbProPrice.Text = "Price";
            // 
            // tbProNa
            // 
            tbProNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbProNa.Location = new Point(940, 30);
            tbProNa.Name = "tbProNa";
            tbProNa.PlaceholderText = "Enter product name to add";
            tbProNa.Size = new Size(306, 27);
            tbProNa.TabIndex = 5;
            // 
            // lbProNa
            // 
            lbProNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbProNa.AutoSize = true;
            lbProNa.Location = new Point(940, 5);
            lbProNa.Name = "lbProNa";
            lbProNa.Size = new Size(104, 20);
            lbProNa.TabIndex = 4;
            lbProNa.Text = "Product Name";
            // 
            // btProUp
            // 
            btProUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btProUp.Image = Properties.Resources.Pictogrammers_Material_Light_Arrow_up_circle_32;
            btProUp.ImageAlign = ContentAlignment.MiddleLeft;
            btProUp.Location = new Point(940, 580);
            btProUp.Name = "btProUp";
            btProUp.Size = new Size(100, 50);
            btProUp.TabIndex = 3;
            btProUp.Text = "UPDATE";
            btProUp.TextAlign = ContentAlignment.MiddleRight;
            btProUp.UseVisualStyleBackColor = true;
            btProUp.Click += btProUp_Click;
            // 
            // btProDel
            // 
            btProDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btProDel.Image = Properties.Resources.Iconsmind_Outline_Close_32;
            btProDel.ImageAlign = ContentAlignment.MiddleLeft;
            btProDel.Location = new Point(1045, 580);
            btProDel.Name = "btProDel";
            btProDel.Size = new Size(100, 50);
            btProDel.TabIndex = 2;
            btProDel.Text = "DELETE";
            btProDel.TextAlign = ContentAlignment.MiddleRight;
            btProDel.UseVisualStyleBackColor = true;
            btProDel.Click += btProDel_Click;
            // 
            // btProAdd
            // 
            btProAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btProAdd.Image = Properties.Resources.Ionic_Ionicons_Add_32;
            btProAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btProAdd.Location = new Point(1150, 580);
            btProAdd.Name = "btProAdd";
            btProAdd.Size = new Size(100, 50);
            btProAdd.TabIndex = 1;
            btProAdd.Text = "ADD";
            btProAdd.TextAlign = ContentAlignment.MiddleRight;
            btProAdd.UseVisualStyleBackColor = true;
            btProAdd.Click += btProAdd_Click;
            // 
            // lvPro
            // 
            lvPro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvPro.FullRowSelect = true;
            lvPro.Location = new Point(6, 6);
            lvPro.Name = "lvPro";
            lvPro.Size = new Size(926, 626);
            lvPro.TabIndex = 0;
            lvPro.UseCompatibleStateImageBehavior = false;
            lvPro.View = View.Details;
            lvPro.ColumnClick += lvPro_ColumnClick;
            lvPro.SelectedIndexChanged += lvPro_SelectedIndexChanged;
            // 
            // tpCus
            // 
            tpCus.BackColor = Color.Gainsboro;
            tpCus.Controls.Add(btCusEx);
            tpCus.Controls.Add(tbCusSearch);
            tpCus.Controls.Add(lbCusSearch);
            tpCus.Controls.Add(tbCusPh);
            tpCus.Controls.Add(lbCusPh);
            tpCus.Controls.Add(tbCusAdd);
            tpCus.Controls.Add(lbCusAdd);
            tpCus.Controls.Add(tbCusNa);
            tpCus.Controls.Add(lbCusNa);
            tpCus.Controls.Add(btCusUp);
            tpCus.Controls.Add(btCusDel);
            tpCus.Controls.Add(btCusAdd);
            tpCus.Controls.Add(lvCus);
            tpCus.Location = new Point(4, 29);
            tpCus.Name = "tpCus";
            tpCus.Padding = new Padding(3);
            tpCus.Size = new Size(1254, 640);
            tpCus.TabIndex = 1;
            tpCus.Text = "Customer Management";
            // 
            // btCusEx
            // 
            btCusEx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCusEx.Location = new Point(940, 300);
            btCusEx.Name = "btCusEx";
            btCusEx.Size = new Size(70, 30);
            btCusEx.TabIndex = 13;
            btCusEx.Text = "Export";
            btCusEx.UseVisualStyleBackColor = true;
            btCusEx.Click += btCusEx_Click;
            // 
            // tbCusSearch
            // 
            tbCusSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCusSearch.Location = new Point(940, 270);
            tbCusSearch.Name = "tbCusSearch";
            tbCusSearch.Size = new Size(306, 27);
            tbCusSearch.TabIndex = 12;
            tbCusSearch.TextChanged += tbCusSearch_TextChanged;
            // 
            // lbCusSearch
            // 
            lbCusSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCusSearch.AutoSize = true;
            lbCusSearch.Location = new Point(940, 245);
            lbCusSearch.Name = "lbCusSearch";
            lbCusSearch.Size = new Size(53, 20);
            lbCusSearch.TabIndex = 11;
            lbCusSearch.Text = "Search";
            // 
            // tbCusPh
            // 
            tbCusPh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCusPh.Location = new Point(938, 190);
            tbCusPh.Name = "tbCusPh";
            tbCusPh.Size = new Size(306, 27);
            tbCusPh.TabIndex = 9;
            tbCusPh.KeyPress += tbCusPh_KeyPress;
            // 
            // lbCusPh
            // 
            lbCusPh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCusPh.AutoSize = true;
            lbCusPh.Location = new Point(940, 165);
            lbCusPh.Name = "lbCusPh";
            lbCusPh.Size = new Size(117, 20);
            lbCusPh.TabIndex = 8;
            lbCusPh.Text = "Customer Phone";
            // 
            // tbCusAdd
            // 
            tbCusAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCusAdd.Location = new Point(938, 110);
            tbCusAdd.Name = "tbCusAdd";
            tbCusAdd.Size = new Size(306, 27);
            tbCusAdd.TabIndex = 7;
            // 
            // lbCusAdd
            // 
            lbCusAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCusAdd.AutoSize = true;
            lbCusAdd.Location = new Point(940, 85);
            lbCusAdd.Name = "lbCusAdd";
            lbCusAdd.Size = new Size(129, 20);
            lbCusAdd.TabIndex = 6;
            lbCusAdd.Text = "Customer Address";
            // 
            // tbCusNa
            // 
            tbCusNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbCusNa.Location = new Point(940, 30);
            tbCusNa.Name = "tbCusNa";
            tbCusNa.Size = new Size(306, 27);
            tbCusNa.TabIndex = 5;
            // 
            // lbCusNa
            // 
            lbCusNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbCusNa.AutoSize = true;
            lbCusNa.Location = new Point(940, 5);
            lbCusNa.Name = "lbCusNa";
            lbCusNa.Size = new Size(116, 20);
            lbCusNa.TabIndex = 4;
            lbCusNa.Text = "Customer Name";
            // 
            // btCusUp
            // 
            btCusUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCusUp.Image = Properties.Resources.Pictogrammers_Material_Light_Arrow_up_circle_32;
            btCusUp.ImageAlign = ContentAlignment.MiddleLeft;
            btCusUp.Location = new Point(940, 580);
            btCusUp.Name = "btCusUp";
            btCusUp.Size = new Size(100, 50);
            btCusUp.TabIndex = 3;
            btCusUp.Text = "UPDATE";
            btCusUp.TextAlign = ContentAlignment.MiddleRight;
            btCusUp.UseVisualStyleBackColor = true;
            btCusUp.Click += btCusUp_Click;
            // 
            // btCusDel
            // 
            btCusDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCusDel.Image = Properties.Resources.Iconsmind_Outline_Close_32;
            btCusDel.ImageAlign = ContentAlignment.MiddleLeft;
            btCusDel.Location = new Point(1045, 580);
            btCusDel.Name = "btCusDel";
            btCusDel.Size = new Size(100, 50);
            btCusDel.TabIndex = 2;
            btCusDel.Text = "DELETE";
            btCusDel.TextAlign = ContentAlignment.MiddleRight;
            btCusDel.UseVisualStyleBackColor = true;
            btCusDel.Click += btCusDel_Click;
            // 
            // btCusAdd
            // 
            btCusAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btCusAdd.Image = Properties.Resources.Ionic_Ionicons_Add_32;
            btCusAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btCusAdd.Location = new Point(1150, 580);
            btCusAdd.Name = "btCusAdd";
            btCusAdd.Size = new Size(100, 50);
            btCusAdd.TabIndex = 1;
            btCusAdd.Text = "ADD";
            btCusAdd.TextAlign = ContentAlignment.MiddleRight;
            btCusAdd.UseVisualStyleBackColor = true;
            btCusAdd.Click += btCusAdd_Click;
            // 
            // lvCus
            // 
            lvCus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvCus.FullRowSelect = true;
            lvCus.Location = new Point(6, 6);
            lvCus.Name = "lvCus";
            lvCus.Size = new Size(926, 626);
            lvCus.TabIndex = 0;
            lvCus.UseCompatibleStateImageBehavior = false;
            lvCus.View = View.Details;
            lvCus.ColumnClick += lvCus_ColumnClick;
            lvCus.SelectedIndexChanged += lvCus_SelectedIndexChanged;
            // 
            // tpEm
            // 
            tpEm.BackColor = Color.Gainsboro;
            tpEm.Controls.Add(lbEmSearch);
            tpEm.Controls.Add(tbEmSearch);
            tpEm.Controls.Add(lbEmPass);
            tpEm.Controls.Add(tbEmPass);
            tpEm.Controls.Add(cbbEmRo);
            tpEm.Controls.Add(lbEmUser);
            tpEm.Controls.Add(tbEmUser);
            tpEm.Controls.Add(tbEmPh);
            tpEm.Controls.Add(lbEmPh);
            tpEm.Controls.Add(tbEmAdd);
            tpEm.Controls.Add(lbEmAdd);
            tpEm.Controls.Add(lbEmRo);
            tpEm.Controls.Add(tbEmNa);
            tpEm.Controls.Add(lbEmNa);
            tpEm.Controls.Add(btEmUp);
            tpEm.Controls.Add(btEmDel);
            tpEm.Controls.Add(btEmAdd);
            tpEm.Controls.Add(lvEm);
            tpEm.Location = new Point(4, 29);
            tpEm.Name = "tpEm";
            tpEm.Size = new Size(1254, 640);
            tpEm.TabIndex = 2;
            tpEm.Text = "Employee Management";
            // 
            // lbEmSearch
            // 
            lbEmSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmSearch.AutoSize = true;
            lbEmSearch.Location = new Point(940, 475);
            lbEmSearch.Name = "lbEmSearch";
            lbEmSearch.Size = new Size(53, 20);
            lbEmSearch.TabIndex = 19;
            lbEmSearch.Text = "Search";
            // 
            // tbEmSearch
            // 
            tbEmSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmSearch.Location = new Point(940, 500);
            tbEmSearch.Name = "tbEmSearch";
            tbEmSearch.Size = new Size(306, 27);
            tbEmSearch.TabIndex = 18;
            tbEmSearch.TextChanged += tbEmSearch_TextChanged;
            // 
            // lbEmPass
            // 
            lbEmPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmPass.AutoSize = true;
            lbEmPass.Location = new Point(940, 405);
            lbEmPass.Name = "lbEmPass";
            lbEmPass.Size = new Size(70, 20);
            lbEmPass.TabIndex = 17;
            lbEmPass.Text = "Password";
            // 
            // tbEmPass
            // 
            tbEmPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmPass.Location = new Point(938, 430);
            tbEmPass.Name = "tbEmPass";
            tbEmPass.Size = new Size(306, 27);
            tbEmPass.TabIndex = 16;
            // 
            // cbbEmRo
            // 
            cbbEmRo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbEmRo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbEmRo.FormattingEnabled = true;
            cbbEmRo.Items.AddRange(new object[] { "Admin", "Warehouse", "Sale" });
            cbbEmRo.Location = new Point(940, 110);
            cbbEmRo.Name = "cbbEmRo";
            cbbEmRo.Size = new Size(304, 28);
            cbbEmRo.TabIndex = 15;
            // 
            // lbEmUser
            // 
            lbEmUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmUser.AutoSize = true;
            lbEmUser.Location = new Point(940, 325);
            lbEmUser.Name = "lbEmUser";
            lbEmUser.Size = new Size(75, 20);
            lbEmUser.TabIndex = 14;
            lbEmUser.Text = "Username";
            // 
            // tbEmUser
            // 
            tbEmUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmUser.Location = new Point(938, 350);
            tbEmUser.Name = "tbEmUser";
            tbEmUser.Size = new Size(306, 27);
            tbEmUser.TabIndex = 13;
            // 
            // tbEmPh
            // 
            tbEmPh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmPh.Location = new Point(940, 270);
            tbEmPh.Name = "tbEmPh";
            tbEmPh.Size = new Size(306, 27);
            tbEmPh.TabIndex = 12;
            tbEmPh.KeyPress += tbEmPh_KeyPress;
            // 
            // lbEmPh
            // 
            lbEmPh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmPh.AutoSize = true;
            lbEmPh.Location = new Point(940, 245);
            lbEmPh.Name = "lbEmPh";
            lbEmPh.Size = new Size(120, 20);
            lbEmPh.TabIndex = 11;
            lbEmPh.Text = "Employee Phone";
            // 
            // tbEmAdd
            // 
            tbEmAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmAdd.Location = new Point(940, 190);
            tbEmAdd.Name = "tbEmAdd";
            tbEmAdd.Size = new Size(306, 27);
            tbEmAdd.TabIndex = 10;
            // 
            // lbEmAdd
            // 
            lbEmAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmAdd.AutoSize = true;
            lbEmAdd.Location = new Point(940, 165);
            lbEmAdd.Name = "lbEmAdd";
            lbEmAdd.Size = new Size(132, 20);
            lbEmAdd.TabIndex = 9;
            lbEmAdd.Text = "Employee Address";
            // 
            // lbEmRo
            // 
            lbEmRo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmRo.AutoSize = true;
            lbEmRo.Location = new Point(940, 85);
            lbEmRo.Name = "lbEmRo";
            lbEmRo.Size = new Size(109, 20);
            lbEmRo.TabIndex = 7;
            lbEmRo.Text = "Employee Role";
            // 
            // tbEmNa
            // 
            tbEmNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbEmNa.Location = new Point(940, 30);
            tbEmNa.Name = "tbEmNa";
            tbEmNa.Size = new Size(306, 27);
            tbEmNa.TabIndex = 6;
            // 
            // lbEmNa
            // 
            lbEmNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbEmNa.AutoSize = true;
            lbEmNa.Location = new Point(940, 5);
            lbEmNa.Name = "lbEmNa";
            lbEmNa.Size = new Size(119, 20);
            lbEmNa.TabIndex = 5;
            lbEmNa.Text = "Employee Name";
            // 
            // btEmUp
            // 
            btEmUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEmUp.Image = Properties.Resources.Pictogrammers_Material_Light_Arrow_up_circle_32;
            btEmUp.ImageAlign = ContentAlignment.MiddleLeft;
            btEmUp.Location = new Point(940, 580);
            btEmUp.Name = "btEmUp";
            btEmUp.Size = new Size(100, 50);
            btEmUp.TabIndex = 4;
            btEmUp.Text = "UPDATE";
            btEmUp.TextAlign = ContentAlignment.MiddleRight;
            btEmUp.UseVisualStyleBackColor = true;
            btEmUp.Click += btEmUp_Click;
            // 
            // btEmDel
            // 
            btEmDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEmDel.Image = Properties.Resources.Iconsmind_Outline_Close_32;
            btEmDel.ImageAlign = ContentAlignment.MiddleLeft;
            btEmDel.Location = new Point(1045, 580);
            btEmDel.Name = "btEmDel";
            btEmDel.Size = new Size(100, 50);
            btEmDel.TabIndex = 3;
            btEmDel.Text = "DELETE";
            btEmDel.TextAlign = ContentAlignment.MiddleRight;
            btEmDel.UseVisualStyleBackColor = true;
            btEmDel.Click += btEmDel_Click;
            // 
            // btEmAdd
            // 
            btEmAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btEmAdd.Image = Properties.Resources.Ionic_Ionicons_Add_32;
            btEmAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btEmAdd.Location = new Point(1150, 580);
            btEmAdd.Name = "btEmAdd";
            btEmAdd.Size = new Size(100, 50);
            btEmAdd.TabIndex = 2;
            btEmAdd.Text = "ADD";
            btEmAdd.TextAlign = ContentAlignment.MiddleRight;
            btEmAdd.UseVisualStyleBackColor = true;
            btEmAdd.Click += btEmAdd_Click;
            // 
            // lvEm
            // 
            lvEm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvEm.FullRowSelect = true;
            lvEm.Location = new Point(6, 6);
            lvEm.Name = "lvEm";
            lvEm.Size = new Size(926, 626);
            lvEm.TabIndex = 1;
            lvEm.UseCompatibleStateImageBehavior = false;
            lvEm.View = View.Details;
            lvEm.ColumnClick += lvEm_ColumnClick;
            lvEm.SelectedIndexChanged += lvEm_SelectedIndexChanged;
            // 
            // tpOr
            // 
            tpOr.BackColor = Color.Gainsboro;
            tpOr.Controls.Add(lbTotalBill);
            tpOr.Controls.Add(tbTotalBill);
            tpOr.Controls.Add(lbOrP);
            tpOr.Controls.Add(tbOrP);
            tpOr.Controls.Add(lbOrA);
            tpOr.Controls.Add(tbOrA);
            tpOr.Controls.Add(lbOrDa);
            tpOr.Controls.Add(cbbOrEmNa);
            tpOr.Controls.Add(cbbOrCusNa);
            tpOr.Controls.Add(cbbOrProNa);
            tpOr.Controls.Add(lbOrEmNa);
            tpOr.Controls.Add(lbOrCusNa);
            tpOr.Controls.Add(lbOrCusID);
            tpOr.Controls.Add(tbOrCusID);
            tpOr.Controls.Add(lbOrProNa);
            tpOr.Controls.Add(lbOrProID);
            tpOr.Controls.Add(tbOrProID);
            tpOr.Controls.Add(dtpkDate);
            tpOr.Controls.Add(tbOrSearch);
            tpOr.Controls.Add(lbOrSearch);
            tpOr.Controls.Add(btOrUp);
            tpOr.Controls.Add(btOrDel);
            tpOr.Controls.Add(btOrAdd);
            tpOr.Controls.Add(lvOr);
            tpOr.Location = new Point(4, 29);
            tpOr.Name = "tpOr";
            tpOr.Size = new Size(1254, 640);
            tpOr.TabIndex = 3;
            tpOr.Text = "Order Management";
            // 
            // lbTotalBill
            // 
            lbTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTotalBill.AutoSize = true;
            lbTotalBill.Location = new Point(938, 307);
            lbTotalBill.Name = "lbTotalBill";
            lbTotalBill.Size = new Size(67, 20);
            lbTotalBill.TabIndex = 37;
            lbTotalBill.Text = "Total Bill";
            // 
            // tbTotalBill
            // 
            tbTotalBill.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTotalBill.Enabled = false;
            tbTotalBill.Location = new Point(940, 330);
            tbTotalBill.Name = "tbTotalBill";
            tbTotalBill.Size = new Size(300, 27);
            tbTotalBill.TabIndex = 36;
            // 
            // lbOrP
            // 
            lbOrP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrP.AutoSize = true;
            lbOrP.Location = new Point(1090, 245);
            lbOrP.Name = "lbOrP";
            lbOrP.Size = new Size(41, 20);
            lbOrP.TabIndex = 35;
            lbOrP.Text = "Price";
            // 
            // tbOrP
            // 
            tbOrP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbOrP.Enabled = false;
            tbOrP.Location = new Point(1090, 270);
            tbOrP.Name = "tbOrP";
            tbOrP.Size = new Size(150, 27);
            tbOrP.TabIndex = 34;
            // 
            // lbOrA
            // 
            lbOrA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrA.AutoSize = true;
            lbOrA.Location = new Point(940, 245);
            lbOrA.Name = "lbOrA";
            lbOrA.Size = new Size(62, 20);
            lbOrA.TabIndex = 33;
            lbOrA.Text = "Amount";
            // 
            // tbOrA
            // 
            tbOrA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbOrA.Location = new Point(940, 270);
            tbOrA.Name = "tbOrA";
            tbOrA.Size = new Size(150, 27);
            tbOrA.TabIndex = 32;
            tbOrA.TextChanged += tbOrA_TextChanged;
            tbOrA.KeyPress += tbOrA_KeyPress;
            // 
            // lbOrDa
            // 
            lbOrDa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrDa.AutoSize = true;
            lbOrDa.Location = new Point(940, 185);
            lbOrDa.Name = "lbOrDa";
            lbOrDa.Size = new Size(41, 20);
            lbOrDa.TabIndex = 31;
            lbOrDa.Text = "Date";
            // 
            // cbbOrEmNa
            // 
            cbbOrEmNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbOrEmNa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbOrEmNa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbOrEmNa.FormattingEnabled = true;
            cbbOrEmNa.Location = new Point(940, 150);
            cbbOrEmNa.Name = "cbbOrEmNa";
            cbbOrEmNa.Size = new Size(301, 28);
            cbbOrEmNa.TabIndex = 30;
            // 
            // cbbOrCusNa
            // 
            cbbOrCusNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbOrCusNa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbOrCusNa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbOrCusNa.FormattingEnabled = true;
            cbbOrCusNa.Location = new Point(1045, 90);
            cbbOrCusNa.Name = "cbbOrCusNa";
            cbbOrCusNa.Size = new Size(199, 28);
            cbbOrCusNa.TabIndex = 29;
            cbbOrCusNa.SelectedIndexChanged += cbbOrCusNa_SelectedIndexChanged;
            // 
            // cbbOrProNa
            // 
            cbbOrProNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbOrProNa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbOrProNa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbOrProNa.FormattingEnabled = true;
            cbbOrProNa.Location = new Point(1045, 30);
            cbbOrProNa.Name = "cbbOrProNa";
            cbbOrProNa.Size = new Size(199, 28);
            cbbOrProNa.TabIndex = 28;
            cbbOrProNa.SelectedIndexChanged += cbbOrProNa_SelectedIndexChanged;
            // 
            // lbOrEmNa
            // 
            lbOrEmNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrEmNa.AutoSize = true;
            lbOrEmNa.Location = new Point(940, 127);
            lbOrEmNa.Name = "lbOrEmNa";
            lbOrEmNa.Size = new Size(119, 20);
            lbOrEmNa.TabIndex = 27;
            lbOrEmNa.Text = "Employee Name";
            // 
            // lbOrCusNa
            // 
            lbOrCusNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrCusNa.AutoSize = true;
            lbOrCusNa.Location = new Point(1045, 65);
            lbOrCusNa.Name = "lbOrCusNa";
            lbOrCusNa.Size = new Size(116, 20);
            lbOrCusNa.TabIndex = 25;
            lbOrCusNa.Text = "Customer Name";
            // 
            // lbOrCusID
            // 
            lbOrCusID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrCusID.AutoSize = true;
            lbOrCusID.Location = new Point(940, 65);
            lbOrCusID.Name = "lbOrCusID";
            lbOrCusID.Size = new Size(91, 20);
            lbOrCusID.TabIndex = 23;
            lbOrCusID.Text = "Customer ID";
            // 
            // tbOrCusID
            // 
            tbOrCusID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbOrCusID.Enabled = false;
            tbOrCusID.Location = new Point(940, 90);
            tbOrCusID.Name = "tbOrCusID";
            tbOrCusID.Size = new Size(80, 27);
            tbOrCusID.TabIndex = 22;
            // 
            // lbOrProNa
            // 
            lbOrProNa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrProNa.AutoSize = true;
            lbOrProNa.Location = new Point(1045, 5);
            lbOrProNa.Name = "lbOrProNa";
            lbOrProNa.Size = new Size(104, 20);
            lbOrProNa.TabIndex = 21;
            lbOrProNa.Text = "Product Name";
            // 
            // lbOrProID
            // 
            lbOrProID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrProID.AutoSize = true;
            lbOrProID.Location = new Point(940, 5);
            lbOrProID.Name = "lbOrProID";
            lbOrProID.Size = new Size(79, 20);
            lbOrProID.TabIndex = 19;
            lbOrProID.Text = "Product ID";
            // 
            // tbOrProID
            // 
            tbOrProID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbOrProID.Enabled = false;
            tbOrProID.Location = new Point(940, 30);
            tbOrProID.Name = "tbOrProID";
            tbOrProID.Size = new Size(80, 27);
            tbOrProID.TabIndex = 18;
            // 
            // dtpkDate
            // 
            dtpkDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpkDate.Format = DateTimePickerFormat.Custom;
            dtpkDate.Location = new Point(940, 210);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(301, 27);
            dtpkDate.TabIndex = 17;
            // 
            // tbOrSearch
            // 
            tbOrSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbOrSearch.Location = new Point(938, 390);
            tbOrSearch.Name = "tbOrSearch";
            tbOrSearch.Size = new Size(306, 27);
            tbOrSearch.TabIndex = 15;
            tbOrSearch.TextChanged += tbOrSearch_TextChanged;
            // 
            // lbOrSearch
            // 
            lbOrSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbOrSearch.AutoSize = true;
            lbOrSearch.Location = new Point(940, 365);
            lbOrSearch.Name = "lbOrSearch";
            lbOrSearch.Size = new Size(53, 20);
            lbOrSearch.TabIndex = 14;
            lbOrSearch.Text = "Search";
            // 
            // btOrUp
            // 
            btOrUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOrUp.Image = Properties.Resources.Pictogrammers_Material_Light_Arrow_up_circle_32;
            btOrUp.ImageAlign = ContentAlignment.MiddleLeft;
            btOrUp.Location = new Point(940, 580);
            btOrUp.Name = "btOrUp";
            btOrUp.Size = new Size(100, 50);
            btOrUp.TabIndex = 3;
            btOrUp.Text = "UPDATE";
            btOrUp.TextAlign = ContentAlignment.MiddleRight;
            btOrUp.UseVisualStyleBackColor = true;
            btOrUp.Click += btOrUp_Click;
            // 
            // btOrDel
            // 
            btOrDel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOrDel.Image = Properties.Resources.Iconsmind_Outline_Close_32;
            btOrDel.ImageAlign = ContentAlignment.MiddleLeft;
            btOrDel.Location = new Point(1045, 580);
            btOrDel.Name = "btOrDel";
            btOrDel.Size = new Size(100, 50);
            btOrDel.TabIndex = 2;
            btOrDel.Text = "DELETE";
            btOrDel.TextAlign = ContentAlignment.MiddleRight;
            btOrDel.UseVisualStyleBackColor = true;
            btOrDel.Click += btOrDel_Click;
            // 
            // btOrAdd
            // 
            btOrAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btOrAdd.Image = Properties.Resources.Ionic_Ionicons_Add_32;
            btOrAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btOrAdd.Location = new Point(1150, 580);
            btOrAdd.Name = "btOrAdd";
            btOrAdd.Size = new Size(100, 50);
            btOrAdd.TabIndex = 1;
            btOrAdd.Text = "ADD";
            btOrAdd.TextAlign = ContentAlignment.MiddleRight;
            btOrAdd.UseVisualStyleBackColor = true;
            btOrAdd.Click += btOrAdd_Click;
            // 
            // lvOr
            // 
            lvOr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvOr.FullRowSelect = true;
            lvOr.Location = new Point(6, 6);
            lvOr.Name = "lvOr";
            lvOr.Size = new Size(926, 626);
            lvOr.TabIndex = 0;
            lvOr.UseCompatibleStateImageBehavior = false;
            lvOr.View = View.Details;
            lvOr.ColumnClick += lvOr_ColumnClick;
            lvOr.ItemSelectionChanged += lvOr_ItemSelectionChanged;
            lvOr.SelectedIndexChanged += lvOr_SelectedIndexChanged;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(tpMain);
            MinimumSize = new Size(1280, 720);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Technology Accessories";
            WindowState = FormWindowState.Maximized;
            tpMain.ResumeLayout(false);
            tpPro.ResumeLayout(false);
            tpPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPro).EndInit();
            tpCus.ResumeLayout(false);
            tpCus.PerformLayout();
            tpEm.ResumeLayout(false);
            tpEm.PerformLayout();
            tpOr.ResumeLayout(false);
            tpOr.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpMain;
        private TabPage tpPro;
        private TabPage tpCus;
        private ListView lvPro;
        private TabPage tpEm;
        private Button btProAdd;
        private TextBox tbProPrice;
        private Label lbProPrice;
        private TextBox tbProNa;
        private Label lbProNa;
        private Button btProUp;
        private Button btProDel;
        private TextBox tbProSearch;
        private Label lbSearch;
        private PictureBox pbPro;
        private TextBox tbProQua;
        private Label lbProQua;
        private Button btCusAdd;
        private ListView lvCus;
        private TextBox tbCusNa;
        private Label lbCusNa;
        private Button btCusUp;
        private Button btCusDel;
        private TextBox tbCusPh;
        private Label lbCusPh;
        private TextBox tbCusAdd;
        private Label lbCusAdd;
        private Label lbEmNa;
        private Button btEmUp;
        private Button btEmDel;
        private Button btEmAdd;
        private ListView lvEm;
        private Label lbEmRo;
        private TextBox tbEmNa;
        private TextBox tbEmPh;
        private Label lbEmPh;
        private TextBox tbEmAdd;
        private Label lbEmAdd;
        private Button btBro;
        private Button btProEx;
        private TextBox tbCusSearch;
        private Label lbCusSearch;
        private Button btCusEx;
        private Label lbEmUser;
        private TextBox tbEmUser;
        private ComboBox cbbEmRo;
        private Label lbEmSearch;
        private TextBox tbEmSearch;
        private Label lbEmPass;
        private TextBox tbEmPass;
        private TabPage tpOr;
        private Label lbOrProID;
        private TextBox tbOrProID;
        private DateTimePicker dtpkDate;
        private TextBox tbOrSearch;
        private Label lbOrSearch;
        private Button btOrUp;
        private Button btOrDel;
        private Button btOrAdd;
        private ListView lvOr;
        private Label lbOrProNa;
        private ComboBox cbbOrProNa;
        private Label lbOrEmNa;
        private Label lbOrCusNa;
        private Label lbOrCusID;
        private TextBox tbOrCusID;
        private ComboBox cbbOrCusNa;
        private Label lbOrDa;
        private ComboBox cbbOrEmNa;
        private Label lbOrP;
        private TextBox tbOrP;
        private Label lbOrA;
        private TextBox tbOrA;
        private Label lbTotalBill;
        private TextBox tbTotalBill;
        private TextBox tbPup;
        private Label lbPup;
    }
}
