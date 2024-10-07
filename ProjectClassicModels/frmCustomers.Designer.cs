namespace ProjectClassicModels
{
    partial class frmCustomers
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
            this.customerTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtaddressline2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.frstBtn = new System.Windows.Forms.Button();
            this.lstBtn = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.txtaddressline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cnlBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.edtBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.cmbpostalcode = new System.Windows.Forms.ComboBox();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.cmbcountry = new System.Windows.Forms.ComboBox();
            this.txtcontactNumber = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.salesNo = new System.Windows.Forms.NumericUpDown();
            this.cnfrmBtn = new System.Windows.Forms.Button();
            this.customerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesNo)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTab
            // 
            this.customerTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerTab.Controls.Add(this.tabPage1);
            this.customerTab.Controls.Add(this.tabPage2);
            this.customerTab.Location = new System.Drawing.Point(13, 13);
            this.customerTab.Name = "customerTab";
            this.customerTab.SelectedIndex = 0;
            this.customerTab.Size = new System.Drawing.Size(1096, 400);
            this.customerTab.TabIndex = 0;
            this.customerTab.SelectedIndexChanged += new System.EventHandler(this.customerTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cnfrmBtn);
            this.tabPage1.Controls.Add(this.txtaddressline2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.credit);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.salesNo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.frstBtn);
            this.tabPage1.Controls.Add(this.lstBtn);
            this.tabPage1.Controls.Add(this.nxtBtn);
            this.tabPage1.Controls.Add(this.prevBtn);
            this.tabPage1.Controls.Add(this.txtaddressline);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cnlBtn);
            this.tabPage1.Controls.Add(this.dltBtn);
            this.tabPage1.Controls.Add(this.edtBtn);
            this.tabPage1.Controls.Add(this.newBtn);
            this.tabPage1.Controls.Add(this.cmbpostalcode);
            this.tabPage1.Controls.Add(this.cmbcity);
            this.tabPage1.Controls.Add(this.cmbstate);
            this.tabPage1.Controls.Add(this.cmbcountry);
            this.tabPage1.Controls.Add(this.txtcontactNumber);
            this.tabPage1.Controls.Add(this.txtfirstName);
            this.tabPage1.Controls.Add(this.txtlastName);
            this.tabPage1.Controls.Add(this.txtCustomerNumber);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtaddressline2
            // 
            this.txtaddressline2.Enabled = false;
            this.txtaddressline2.Location = new System.Drawing.Point(589, 48);
            this.txtaddressline2.Name = "txtaddressline2";
            this.txtaddressline2.Size = new System.Drawing.Size(493, 29);
            this.txtaddressline2.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 24);
            this.label12.TabIndex = 47;
            this.label12.Text = "AddressLine 2 ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // credit
            // 
            this.credit.Enabled = false;
            this.credit.Location = new System.Drawing.Point(752, 82);
            this.credit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(164, 29);
            this.credit.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(687, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 45;
            this.label11.Text = "Credit";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "SalesRep";
            // 
            // frstBtn
            // 
            this.frstBtn.Location = new System.Drawing.Point(292, 311);
            this.frstBtn.Name = "frstBtn";
            this.frstBtn.Size = new System.Drawing.Size(77, 31);
            this.frstBtn.TabIndex = 42;
            this.frstBtn.Text = "First";
            this.frstBtn.UseVisualStyleBackColor = true;
            // 
            // lstBtn
            // 
            this.lstBtn.Location = new System.Drawing.Point(375, 311);
            this.lstBtn.Name = "lstBtn";
            this.lstBtn.Size = new System.Drawing.Size(77, 31);
            this.lstBtn.TabIndex = 41;
            this.lstBtn.Text = "Last";
            this.lstBtn.UseVisualStyleBackColor = true;
            // 
            // nxtBtn
            // 
            this.nxtBtn.Location = new System.Drawing.Point(209, 310);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(77, 31);
            this.nxtBtn.TabIndex = 40;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(126, 310);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(77, 31);
            this.prevBtn.TabIndex = 39;
            this.prevBtn.Text = "Prev";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // txtaddressline
            // 
            this.txtaddressline.Enabled = false;
            this.txtaddressline.Location = new System.Drawing.Point(589, 12);
            this.txtaddressline.Name = "txtaddressline";
            this.txtaddressline.Size = new System.Drawing.Size(493, 29);
            this.txtaddressline.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "AddressLine 1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cnlBtn
            // 
            this.cnlBtn.Location = new System.Drawing.Point(1005, 83);
            this.cnlBtn.Name = "cnlBtn";
            this.cnlBtn.Size = new System.Drawing.Size(77, 31);
            this.cnlBtn.TabIndex = 36;
            this.cnlBtn.Text = "Cancel";
            this.cnlBtn.UseVisualStyleBackColor = true;
            this.cnlBtn.Click += new System.EventHandler(this.cnlBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(1005, 121);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(77, 31);
            this.dltBtn.TabIndex = 35;
            this.dltBtn.Text = "Delete";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // edtBtn
            // 
            this.edtBtn.Location = new System.Drawing.Point(922, 120);
            this.edtBtn.Name = "edtBtn";
            this.edtBtn.Size = new System.Drawing.Size(77, 31);
            this.edtBtn.TabIndex = 34;
            this.edtBtn.Text = "Edit";
            this.edtBtn.UseVisualStyleBackColor = true;
            this.edtBtn.Click += new System.EventHandler(this.edtBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(922, 84);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(77, 31);
            this.newBtn.TabIndex = 33;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // cmbpostalcode
            // 
            this.cmbpostalcode.Enabled = false;
            this.cmbpostalcode.FormattingEnabled = true;
            this.cmbpostalcode.Location = new System.Drawing.Point(184, 269);
            this.cmbpostalcode.Name = "cmbpostalcode";
            this.cmbpostalcode.Size = new System.Drawing.Size(238, 32);
            this.cmbpostalcode.TabIndex = 32;
            // 
            // cmbcity
            // 
            this.cmbcity.Enabled = false;
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Location = new System.Drawing.Point(186, 231);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(236, 32);
            this.cmbcity.TabIndex = 31;
            // 
            // cmbstate
            // 
            this.cmbstate.Enabled = false;
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Location = new System.Drawing.Point(186, 193);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(236, 32);
            this.cmbstate.TabIndex = 30;
            this.cmbstate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbcountry
            // 
            this.cmbcountry.Enabled = false;
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.Location = new System.Drawing.Point(186, 155);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(236, 32);
            this.cmbcountry.TabIndex = 29;
            this.cmbcountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtcontactNumber
            // 
            this.txtcontactNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtcontactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontactNumber.Enabled = false;
            this.txtcontactNumber.Location = new System.Drawing.Point(186, 120);
            this.txtcontactNumber.Name = "txtcontactNumber";
            this.txtcontactNumber.Size = new System.Drawing.Size(236, 29);
            this.txtcontactNumber.TabIndex = 28;
            // 
            // txtfirstName
            // 
            this.txtfirstName.BackColor = System.Drawing.SystemColors.Info;
            this.txtfirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Location = new System.Drawing.Point(186, 85);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(236, 29);
            this.txtfirstName.TabIndex = 27;
            // 
            // txtlastName
            // 
            this.txtlastName.BackColor = System.Drawing.SystemColors.Info;
            this.txtlastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlastName.Enabled = false;
            this.txtlastName.Location = new System.Drawing.Point(186, 46);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(236, 29);
            this.txtlastName.TabIndex = 26;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerNumber.Enabled = false;
            this.txtCustomerNumber.Location = new System.Drawing.Point(186, 10);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(236, 29);
            this.txtCustomerNumber.TabIndex = 25;
            this.txtCustomerNumber.TextChanged += new System.EventHandler(this.customerID_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(96, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label10.Size = new System.Drawing.Size(75, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "Country";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label9.Size = new System.Drawing.Size(51, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "State";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(111, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "Postal Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(40, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "City";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(147, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contact Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(169, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contact First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contact Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1088, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgCustomers
            // 
            this.dgCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(7, 7);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.Size = new System.Drawing.Size(1081, 356);
            this.dgCustomers.TabIndex = 1;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick);
            this.dgCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentDoubleClick);
            // 
            // salesNo
            // 
            this.salesNo.Enabled = false;
            this.salesNo.Location = new System.Drawing.Point(589, 82);
            this.salesNo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.salesNo.Name = "salesNo";
            this.salesNo.Size = new System.Drawing.Size(92, 29);
            this.salesNo.TabIndex = 44;
            // 
            // cnfrmBtn
            // 
            this.cnfrmBtn.Enabled = false;
            this.cnfrmBtn.Location = new System.Drawing.Point(922, 157);
            this.cnfrmBtn.Name = "cnfrmBtn";
            this.cnfrmBtn.Size = new System.Drawing.Size(160, 31);
            this.cnfrmBtn.TabIndex = 49;
            this.cnfrmBtn.Text = "Confirm";
            this.cnfrmBtn.UseVisualStyleBackColor = true;
            this.cnfrmBtn.Click += new System.EventHandler(this.cnfrmBtn_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 425);
            this.Controls.Add(this.customerTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.customers_Load);
            this.customerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl customerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtcontactNumber;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.ComboBox cmbcountry;
        private System.Windows.Forms.ComboBox cmbstate;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cnlBtn;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button edtBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.ComboBox cmbpostalcode;
        private System.Windows.Forms.TextBox txtaddressline;
        private System.Windows.Forms.Button frstBtn;
        private System.Windows.Forms.Button lstBtn;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.NumericUpDown credit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddressline2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown salesNo;
        private System.Windows.Forms.Button cnfrmBtn;
    }
}