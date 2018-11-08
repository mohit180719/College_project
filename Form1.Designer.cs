namespace XML_TEST
{
    partial class Form1
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
            this.ISA_Button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Vendor_txtbox_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.VendorName = new System.Windows.Forms.ComboBox();
            this.VendorInfo_GroupBox = new System.Windows.Forms.GroupBox();
            this.Vendor_txtbox_Address = new System.Windows.Forms.TextBox();
            this.Vendor_txtbox_Fax = new System.Windows.Forms.TextBox();
            this.Vendor_txtbox_Phone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ShipTocName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ShipTo_txtbox_Phone = new System.Windows.Forms.TextBox();
            this.ShipTo_txtbox_Address = new System.Windows.Forms.TextBox();
            this.ShipToAddress_GroupBox = new System.Windows.Forms.GroupBox();
            this.ShipFromAddress_GroupBox = new System.Windows.Forms.GroupBox();
            this.ShipFrom_txtbox_Address = new System.Windows.Forms.TextBox();
            this.ShipFrom_txtbox_Phone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ShipFrom_txtbox_CName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.Term_GroupBox = new System.Windows.Forms.GroupBox();
            this.Term_ShipDate = new System.Windows.Forms.DateTimePicker();
            this.Term_Combox_Payment = new System.Windows.Forms.ComboBox();
            this.Term_Combox_Currency = new System.Windows.Forms.ComboBox();
            this.Term_radio_Production = new System.Windows.Forms.RadioButton();
            this.Term_radio_Test = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Items_DataGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.PO = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.POno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VendorInfo_GroupBox.SuspendLayout();
            this.ShipToAddress_GroupBox.SuspendLayout();
            this.ShipFromAddress_GroupBox.SuspendLayout();
            this.Term_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_DataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ISA_Button
            // 
            this.ISA_Button.Location = new System.Drawing.Point(630, 707);
            this.ISA_Button.Name = "ISA_Button";
            this.ISA_Button.Size = new System.Drawing.Size(134, 23);
            this.ISA_Button.TabIndex = 12;
            this.ISA_Button.Text = "Generate XML";
            this.ISA_Button.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Vendor Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vendor ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Address";
            // 
            // Vendor_txtbox_ID
            // 
            this.Vendor_txtbox_ID.Location = new System.Drawing.Point(344, 29);
            this.Vendor_txtbox_ID.Name = "Vendor_txtbox_ID";
            this.Vendor_txtbox_ID.Size = new System.Drawing.Size(202, 20);
            this.Vendor_txtbox_ID.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Phone No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fax";
            // 
            // VendorName
            // 
            this.VendorName.FormattingEnabled = true;
            this.VendorName.Items.AddRange(new object[] {
            "Vendor 1",
            "Vendor 2",
            "Vendor 3"});
            this.VendorName.Location = new System.Drawing.Point(108, 28);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(121, 21);
            this.VendorName.TabIndex = 15;
            // 
            // VendorInfo_GroupBox
            // 
            this.VendorInfo_GroupBox.Controls.Add(this.Vendor_txtbox_Address);
            this.VendorInfo_GroupBox.Controls.Add(this.Vendor_txtbox_Fax);
            this.VendorInfo_GroupBox.Controls.Add(this.Vendor_txtbox_Phone);
            this.VendorInfo_GroupBox.Controls.Add(this.VendorName);
            this.VendorInfo_GroupBox.Controls.Add(this.label8);
            this.VendorInfo_GroupBox.Controls.Add(this.label9);
            this.VendorInfo_GroupBox.Controls.Add(this.Vendor_txtbox_ID);
            this.VendorInfo_GroupBox.Controls.Add(this.label10);
            this.VendorInfo_GroupBox.Controls.Add(this.label11);
            this.VendorInfo_GroupBox.Controls.Add(this.label12);
            this.VendorInfo_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorInfo_GroupBox.Location = new System.Drawing.Point(37, 108);
            this.VendorInfo_GroupBox.Name = "VendorInfo_GroupBox";
            this.VendorInfo_GroupBox.Size = new System.Drawing.Size(886, 119);
            this.VendorInfo_GroupBox.TabIndex = 14;
            this.VendorInfo_GroupBox.TabStop = false;
            this.VendorInfo_GroupBox.Text = "Vendor Information";
            // 
            // Vendor_txtbox_Address
            // 
            this.Vendor_txtbox_Address.Location = new System.Drawing.Point(624, 32);
            this.Vendor_txtbox_Address.Multiline = true;
            this.Vendor_txtbox_Address.Name = "Vendor_txtbox_Address";
            this.Vendor_txtbox_Address.Size = new System.Drawing.Size(246, 72);
            this.Vendor_txtbox_Address.TabIndex = 19;
            // 
            // Vendor_txtbox_Fax
            // 
            this.Vendor_txtbox_Fax.Location = new System.Drawing.Point(344, 58);
            this.Vendor_txtbox_Fax.Name = "Vendor_txtbox_Fax";
            this.Vendor_txtbox_Fax.Size = new System.Drawing.Size(202, 20);
            this.Vendor_txtbox_Fax.TabIndex = 18;
            // 
            // Vendor_txtbox_Phone
            // 
            this.Vendor_txtbox_Phone.Location = new System.Drawing.Point(112, 55);
            this.Vendor_txtbox_Phone.Name = "Vendor_txtbox_Phone";
            this.Vendor_txtbox_Phone.Size = new System.Drawing.Size(117, 20);
            this.Vendor_txtbox_Phone.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Company Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Address";
            // 
            // ShipTocName
            // 
            this.ShipTocName.Location = new System.Drawing.Point(110, 30);
            this.ShipTocName.Name = "ShipTocName";
            this.ShipTocName.Size = new System.Drawing.Size(153, 20);
            this.ShipTocName.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Phone No";
            // 
            // ShipTo_txtbox_Phone
            // 
            this.ShipTo_txtbox_Phone.Location = new System.Drawing.Point(112, 56);
            this.ShipTo_txtbox_Phone.Name = "ShipTo_txtbox_Phone";
            this.ShipTo_txtbox_Phone.Size = new System.Drawing.Size(151, 20);
            this.ShipTo_txtbox_Phone.TabIndex = 17;
            // 
            // ShipTo_txtbox_Address
            // 
            this.ShipTo_txtbox_Address.Location = new System.Drawing.Point(112, 82);
            this.ShipTo_txtbox_Address.Multiline = true;
            this.ShipTo_txtbox_Address.Name = "ShipTo_txtbox_Address";
            this.ShipTo_txtbox_Address.Size = new System.Drawing.Size(246, 72);
            this.ShipTo_txtbox_Address.TabIndex = 19;
            // 
            // ShipToAddress_GroupBox
            // 
            this.ShipToAddress_GroupBox.Controls.Add(this.ShipTo_txtbox_Address);
            this.ShipToAddress_GroupBox.Controls.Add(this.ShipTo_txtbox_Phone);
            this.ShipToAddress_GroupBox.Controls.Add(this.label14);
            this.ShipToAddress_GroupBox.Controls.Add(this.ShipTocName);
            this.ShipToAddress_GroupBox.Controls.Add(this.label15);
            this.ShipToAddress_GroupBox.Controls.Add(this.label16);
            this.ShipToAddress_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipToAddress_GroupBox.Location = new System.Drawing.Point(37, 233);
            this.ShipToAddress_GroupBox.Name = "ShipToAddress_GroupBox";
            this.ShipToAddress_GroupBox.Size = new System.Drawing.Size(432, 166);
            this.ShipToAddress_GroupBox.TabIndex = 20;
            this.ShipToAddress_GroupBox.TabStop = false;
            this.ShipToAddress_GroupBox.Text = "Ship To Address";
            // 
            // ShipFromAddress_GroupBox
            // 
            this.ShipFromAddress_GroupBox.Controls.Add(this.ShipFrom_txtbox_Address);
            this.ShipFromAddress_GroupBox.Controls.Add(this.ShipFrom_txtbox_Phone);
            this.ShipFromAddress_GroupBox.Controls.Add(this.label13);
            this.ShipFromAddress_GroupBox.Controls.Add(this.ShipFrom_txtbox_CName);
            this.ShipFromAddress_GroupBox.Controls.Add(this.label17);
            this.ShipFromAddress_GroupBox.Controls.Add(this.label18);
            this.ShipFromAddress_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipFromAddress_GroupBox.Location = new System.Drawing.Point(504, 233);
            this.ShipFromAddress_GroupBox.Name = "ShipFromAddress_GroupBox";
            this.ShipFromAddress_GroupBox.Size = new System.Drawing.Size(428, 166);
            this.ShipFromAddress_GroupBox.TabIndex = 21;
            this.ShipFromAddress_GroupBox.TabStop = false;
            this.ShipFromAddress_GroupBox.Text = "Ship From Address";
            // 
            // ShipFrom_txtbox_Address
            // 
            this.ShipFrom_txtbox_Address.Location = new System.Drawing.Point(126, 84);
            this.ShipFrom_txtbox_Address.Multiline = true;
            this.ShipFrom_txtbox_Address.Name = "ShipFrom_txtbox_Address";
            this.ShipFrom_txtbox_Address.Size = new System.Drawing.Size(246, 72);
            this.ShipFrom_txtbox_Address.TabIndex = 19;
            // 
            // ShipFrom_txtbox_Phone
            // 
            this.ShipFrom_txtbox_Phone.Location = new System.Drawing.Point(126, 58);
            this.ShipFrom_txtbox_Phone.Name = "ShipFrom_txtbox_Phone";
            this.ShipFrom_txtbox_Phone.Size = new System.Drawing.Size(151, 20);
            this.ShipFrom_txtbox_Phone.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Phone No";
            // 
            // ShipFrom_txtbox_CName
            // 
            this.ShipFrom_txtbox_CName.Location = new System.Drawing.Point(126, 32);
            this.ShipFrom_txtbox_CName.Name = "ShipFrom_txtbox_CName";
            this.ShipFrom_txtbox_CName.Size = new System.Drawing.Size(149, 20);
            this.ShipFrom_txtbox_CName.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Company Name";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(116, 81);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(100, 20);
            this.description.TabIndex = 27;
            // 
            // Term_GroupBox
            // 
            this.Term_GroupBox.Controls.Add(this.Term_ShipDate);
            this.Term_GroupBox.Controls.Add(this.Term_Combox_Payment);
            this.Term_GroupBox.Controls.Add(this.Term_Combox_Currency);
            this.Term_GroupBox.Controls.Add(this.Term_radio_Production);
            this.Term_GroupBox.Controls.Add(this.Term_radio_Test);
            this.Term_GroupBox.Controls.Add(this.label22);
            this.Term_GroupBox.Controls.Add(this.label21);
            this.Term_GroupBox.Controls.Add(this.label20);
            this.Term_GroupBox.Controls.Add(this.label19);
            this.Term_GroupBox.Location = new System.Drawing.Point(37, 414);
            this.Term_GroupBox.Name = "Term_GroupBox";
            this.Term_GroupBox.Size = new System.Drawing.Size(466, 123);
            this.Term_GroupBox.TabIndex = 22;
            this.Term_GroupBox.TabStop = false;
            this.Term_GroupBox.Text = "Terms";
            // 
            // Term_ShipDate
            // 
            this.Term_ShipDate.Location = new System.Drawing.Point(334, 31);
            this.Term_ShipDate.Name = "Term_ShipDate";
            this.Term_ShipDate.Size = new System.Drawing.Size(98, 20);
            this.Term_ShipDate.TabIndex = 15;
            // 
            // Term_Combox_Payment
            // 
            this.Term_Combox_Payment.FormattingEnabled = true;
            this.Term_Combox_Payment.Items.AddRange(new object[] {
            "Card",
            "Cheque",
            "Electronic Payment"});
            this.Term_Combox_Payment.Location = new System.Drawing.Point(334, 70);
            this.Term_Combox_Payment.Name = "Term_Combox_Payment";
            this.Term_Combox_Payment.Size = new System.Drawing.Size(98, 21);
            this.Term_Combox_Payment.TabIndex = 14;
            // 
            // Term_Combox_Currency
            // 
            this.Term_Combox_Currency.FormattingEnabled = true;
            this.Term_Combox_Currency.Items.AddRange(new object[] {
            "IndianRupee",
            "Dollar",
            "Euro"});
            this.Term_Combox_Currency.Location = new System.Drawing.Point(108, 79);
            this.Term_Combox_Currency.Name = "Term_Combox_Currency";
            this.Term_Combox_Currency.Size = new System.Drawing.Size(103, 21);
            this.Term_Combox_Currency.TabIndex = 13;
            // 
            // Term_radio_Production
            // 
            this.Term_radio_Production.AutoSize = true;
            this.Term_radio_Production.Location = new System.Drawing.Point(108, 52);
            this.Term_radio_Production.Name = "Term_radio_Production";
            this.Term_radio_Production.Size = new System.Drawing.Size(76, 17);
            this.Term_radio_Production.TabIndex = 12;
            this.Term_radio_Production.TabStop = true;
            this.Term_radio_Production.Text = "Production";
            this.Term_radio_Production.UseVisualStyleBackColor = true;
            // 
            // Term_radio_Test
            // 
            this.Term_radio_Test.AutoSize = true;
            this.Term_radio_Test.Location = new System.Drawing.Point(108, 29);
            this.Term_radio_Test.Name = "Term_radio_Test";
            this.Term_radio_Test.Size = new System.Drawing.Size(46, 17);
            this.Term_radio_Test.TabIndex = 11;
            this.Term_radio_Test.TabStop = true;
            this.Term_radio_Test.Text = "Test";
            this.Term_radio_Test.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Mode of Payment";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(228, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Ship Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Currency";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Flag Type";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 707);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Items_DataGrid
            // 
            this.Items_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_DataGrid.Location = new System.Drawing.Point(39, 553);
            this.Items_DataGrid.Name = "Items_DataGrid";
            this.Items_DataGrid.Size = new System.Drawing.Size(475, 150);
            this.Items_DataGrid.TabIndex = 23;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(240, 33);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(107, 57);
            this.Add.TabIndex = 24;
            this.Add.Text = "Add In List";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PO
            // 
            this.PO.Location = new System.Drawing.Point(116, 24);
            this.PO.Name = "PO";
            this.PO.Size = new System.Drawing.Size(100, 20);
            this.PO.TabIndex = 25;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(116, 52);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.POno);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.PO);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Location = new System.Drawing.Point(520, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 123);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantity";
            // 
            // POno
            // 
            this.POno.AutoSize = true;
            this.POno.Location = new System.Drawing.Point(27, 29);
            this.POno.Name = "POno";
            this.POno.Size = new System.Drawing.Size(29, 13);
            this.POno.TabIndex = 28;
            this.POno.Text = "PO#";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(815, 597);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Set default";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 47);
            this.label1.TabIndex = 28;
            this.label1.Text = "Requirement Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Items_DataGrid);
            this.Controls.Add(this.Term_GroupBox);
            this.Controls.Add(this.ShipFromAddress_GroupBox);
            this.Controls.Add(this.ShipToAddress_GroupBox);
            this.Controls.Add(this.ISA_Button);
            this.Controls.Add(this.VendorInfo_GroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.VendorInfo_GroupBox.ResumeLayout(false);
            this.VendorInfo_GroupBox.PerformLayout();
            this.ShipToAddress_GroupBox.ResumeLayout(false);
            this.ShipToAddress_GroupBox.PerformLayout();
            this.ShipFromAddress_GroupBox.ResumeLayout(false);
            this.ShipFromAddress_GroupBox.PerformLayout();
            this.Term_GroupBox.ResumeLayout(false);
            this.Term_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Items_DataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ISA_Button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Vendor_txtbox_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox VendorName;
        private System.Windows.Forms.GroupBox VendorInfo_GroupBox;
        private System.Windows.Forms.TextBox Vendor_txtbox_Address;
        private System.Windows.Forms.TextBox Vendor_txtbox_Fax;
        private System.Windows.Forms.TextBox Vendor_txtbox_Phone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ShipTocName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ShipTo_txtbox_Phone;
        private System.Windows.Forms.TextBox ShipTo_txtbox_Address;
        private System.Windows.Forms.GroupBox ShipToAddress_GroupBox;
        private System.Windows.Forms.GroupBox ShipFromAddress_GroupBox;
        private System.Windows.Forms.TextBox ShipFrom_txtbox_Address;
        private System.Windows.Forms.TextBox ShipFrom_txtbox_Phone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ShipFrom_txtbox_CName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox Term_GroupBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker Term_ShipDate;
        private System.Windows.Forms.ComboBox Term_Combox_Payment;
        private System.Windows.Forms.ComboBox Term_Combox_Currency;
        private System.Windows.Forms.RadioButton Term_radio_Production;
        private System.Windows.Forms.RadioButton Term_radio_Test;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Items_DataGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox PO;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label POno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

