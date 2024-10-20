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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.customerTab = new ReaLTaiizor.Controls.AirTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cnfrmBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.edtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.cnlBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.newBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.dltBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.lstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.nxtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.prevBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.frstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.credit = new ReaLTaiizor.Controls.DungeonTextBox();
            this.salesRep = new ReaLTaiizor.Controls.DungeonComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtaddressline2 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtaddressline = new ReaLTaiizor.Controls.DungeonTextBox();
            this.cmbpostalcode = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbcity = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbstate = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbcountry = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtcontactNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtfirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtlastName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtcustName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtCustomerNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgCustomers = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.exitBtn = new ReaLTaiizor.Controls.FoxButton();
            this.customerTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // customerTab
            // 
            this.customerTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.customerTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerTab.BaseColor = System.Drawing.Color.AliceBlue;
            this.customerTab.Controls.Add(this.tabPage1);
            this.customerTab.Controls.Add(this.tabPage2);
            this.customerTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.customerTab.ItemSize = new System.Drawing.Size(30, 115);
            this.customerTab.Location = new System.Drawing.Point(12, 49);
            this.customerTab.Multiline = true;
            this.customerTab.Name = "customerTab";
            this.customerTab.NormalTextColor = System.Drawing.Color.Black;
            this.customerTab.SelectedIndex = 0;
            this.customerTab.SelectedTabBackColor = System.Drawing.Color.White;
            this.customerTab.SelectedTextColor = System.Drawing.Color.Black;
            this.customerTab.ShowOuterBorders = false;
            this.customerTab.Size = new System.Drawing.Size(1121, 459);
            this.customerTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.customerTab.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.customerTab.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.customerTab.TabIndex = 2;
            this.customerTab.SelectedIndexChanged += new System.EventHandler(this.customerTab_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cnfrmBtn);
            this.tabPage1.Controls.Add(this.edtBtn);
            this.tabPage1.Controls.Add(this.cnlBtn);
            this.tabPage1.Controls.Add(this.newBtn);
            this.tabPage1.Controls.Add(this.dltBtn);
            this.tabPage1.Controls.Add(this.lstBtn);
            this.tabPage1.Controls.Add(this.nxtBtn);
            this.tabPage1.Controls.Add(this.prevBtn);
            this.tabPage1.Controls.Add(this.frstBtn);
            this.tabPage1.Controls.Add(this.credit);
            this.tabPage1.Controls.Add(this.salesRep);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtaddressline2);
            this.tabPage1.Controls.Add(this.txtaddressline);
            this.tabPage1.Controls.Add(this.cmbpostalcode);
            this.tabPage1.Controls.Add(this.cmbcity);
            this.tabPage1.Controls.Add(this.cmbstate);
            this.tabPage1.Controls.Add(this.cmbcountry);
            this.tabPage1.Controls.Add(this.txtcontactNumber);
            this.tabPage1.Controls.Add(this.txtfirstName);
            this.tabPage1.Controls.Add(this.txtlastName);
            this.tabPage1.Controls.Add(this.txtcustName);
            this.tabPage1.Controls.Add(this.txtCustomerNumber);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Customer";
            // 
            // cnfrmBtn
            // 
            this.cnfrmBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cnfrmBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cnfrmBtn.Depth = 0;
            this.cnfrmBtn.Enabled = false;
            this.cnfrmBtn.HighEmphasis = true;
            this.cnfrmBtn.Icon = null;
            this.cnfrmBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.cnfrmBtn.Location = new System.Drawing.Point(828, 235);
            this.cnfrmBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cnfrmBtn.MinimumSize = new System.Drawing.Size(160, 0);
            this.cnfrmBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cnfrmBtn.Name = "cnfrmBtn";
            this.cnfrmBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cnfrmBtn.Size = new System.Drawing.Size(160, 36);
            this.cnfrmBtn.TabIndex = 56;
            this.cnfrmBtn.Text = "Confirm";
            this.cnfrmBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cnfrmBtn.UseAccentColor = false;
            this.cnfrmBtn.UseVisualStyleBackColor = true;
            this.cnfrmBtn.Click += new System.EventHandler(this.cnfrmBtn_Click_1);
            // 
            // edtBtn
            // 
            this.edtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edtBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.edtBtn.Depth = 0;
            this.edtBtn.HighEmphasis = true;
            this.edtBtn.Icon = null;
            this.edtBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.edtBtn.Location = new System.Drawing.Point(828, 187);
            this.edtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edtBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.edtBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.edtBtn.Name = "edtBtn";
            this.edtBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.edtBtn.Size = new System.Drawing.Size(75, 36);
            this.edtBtn.TabIndex = 55;
            this.edtBtn.Text = "Edit";
            this.edtBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.edtBtn.UseAccentColor = false;
            this.edtBtn.UseVisualStyleBackColor = true;
            this.edtBtn.Click += new System.EventHandler(this.edtBtn_Click_1);
            // 
            // cnlBtn
            // 
            this.cnlBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cnlBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cnlBtn.Depth = 0;
            this.cnlBtn.Enabled = false;
            this.cnlBtn.HighEmphasis = true;
            this.cnlBtn.Icon = null;
            this.cnlBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.cnlBtn.Location = new System.Drawing.Point(911, 187);
            this.cnlBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cnlBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.cnlBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cnlBtn.Name = "cnlBtn";
            this.cnlBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cnlBtn.Size = new System.Drawing.Size(77, 36);
            this.cnlBtn.TabIndex = 54;
            this.cnlBtn.Text = "Cancel";
            this.cnlBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cnlBtn.UseAccentColor = false;
            this.cnlBtn.UseVisualStyleBackColor = true;
            this.cnlBtn.Click += new System.EventHandler(this.cnlBtn_Click_1);
            // 
            // newBtn
            // 
            this.newBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.newBtn.Depth = 0;
            this.newBtn.HighEmphasis = true;
            this.newBtn.Icon = null;
            this.newBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.newBtn.Location = new System.Drawing.Point(828, 139);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.newBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.newBtn.Name = "newBtn";
            this.newBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.newBtn.Size = new System.Drawing.Size(75, 36);
            this.newBtn.TabIndex = 53;
            this.newBtn.Text = "New";
            this.newBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newBtn.UseAccentColor = false;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click_1);
            // 
            // dltBtn
            // 
            this.dltBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dltBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.dltBtn.Depth = 0;
            this.dltBtn.Enabled = false;
            this.dltBtn.HighEmphasis = true;
            this.dltBtn.Icon = null;
            this.dltBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.dltBtn.Location = new System.Drawing.Point(913, 139);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dltBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.dltBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dltBtn.Size = new System.Drawing.Size(75, 36);
            this.dltBtn.TabIndex = 52;
            this.dltBtn.Text = "Delete";
            this.dltBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dltBtn.UseAccentColor = false;
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click_1);
            // 
            // lstBtn
            // 
            this.lstBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lstBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lstBtn.Depth = 0;
            this.lstBtn.HighEmphasis = true;
            this.lstBtn.Icon = null;
            this.lstBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.lstBtn.Location = new System.Drawing.Point(260, 409);
            this.lstBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.lstBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lstBtn.Name = "lstBtn";
            this.lstBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lstBtn.Size = new System.Drawing.Size(75, 36);
            this.lstBtn.TabIndex = 51;
            this.lstBtn.Text = "Last";
            this.lstBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lstBtn.UseAccentColor = false;
            this.lstBtn.UseVisualStyleBackColor = true;
            this.lstBtn.Click += new System.EventHandler(this.lstBtn_Click_1);
            // 
            // nxtBtn
            // 
            this.nxtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nxtBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nxtBtn.Depth = 0;
            this.nxtBtn.HighEmphasis = true;
            this.nxtBtn.Icon = null;
            this.nxtBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.nxtBtn.Location = new System.Drawing.Point(177, 409);
            this.nxtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nxtBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.nxtBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nxtBtn.Size = new System.Drawing.Size(75, 36);
            this.nxtBtn.TabIndex = 50;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nxtBtn.UseAccentColor = false;
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click_1);
            // 
            // prevBtn
            // 
            this.prevBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.prevBtn.Depth = 0;
            this.prevBtn.Enabled = false;
            this.prevBtn.HighEmphasis = true;
            this.prevBtn.Icon = null;
            this.prevBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.prevBtn.Location = new System.Drawing.Point(94, 409);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.prevBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.prevBtn.Size = new System.Drawing.Size(75, 36);
            this.prevBtn.TabIndex = 49;
            this.prevBtn.Text = "Prev";
            this.prevBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.prevBtn.UseAccentColor = false;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click_1);
            // 
            // frstBtn
            // 
            this.frstBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frstBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.frstBtn.Depth = 0;
            this.frstBtn.Enabled = false;
            this.frstBtn.HighEmphasis = true;
            this.frstBtn.Icon = null;
            this.frstBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.frstBtn.Location = new System.Drawing.Point(11, 409);
            this.frstBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.frstBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.frstBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.frstBtn.Name = "frstBtn";
            this.frstBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.frstBtn.Size = new System.Drawing.Size(75, 36);
            this.frstBtn.TabIndex = 48;
            this.frstBtn.Text = "First";
            this.frstBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.frstBtn.UseAccentColor = false;
            this.frstBtn.UseVisualStyleBackColor = true;
            this.frstBtn.Click += new System.EventHandler(this.frstBtn_Click_1);
            // 
            // credit
            // 
            this.credit.BackColor = System.Drawing.Color.Transparent;
            this.credit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.credit.EdgeColor = System.Drawing.Color.White;
            this.credit.Enabled = false;
            this.credit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.Color.DimGray;
            this.credit.Location = new System.Drawing.Point(584, 104);
            this.credit.MaxLength = 32767;
            this.credit.Multiline = false;
            this.credit.Name = "credit";
            this.credit.ReadOnly = false;
            this.credit.Size = new System.Drawing.Size(394, 28);
            this.credit.TabIndex = 47;
            this.credit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.credit.UseSystemPasswordChar = false;
            // 
            // salesRep
            // 
            this.salesRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.salesRep.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.salesRep.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.salesRep.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.salesRep.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.salesRep.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.salesRep.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.salesRep.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.salesRep.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.salesRep.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.salesRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesRep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.salesRep.DropDownHeight = 100;
            this.salesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salesRep.Enabled = false;
            this.salesRep.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesRep.ForeColor = System.Drawing.Color.Black;
            this.salesRep.FormattingEnabled = true;
            this.salesRep.HoverSelectionColor = System.Drawing.Color.Empty;
            this.salesRep.IntegralHeight = false;
            this.salesRep.ItemHeight = 20;
            this.salesRep.Location = new System.Drawing.Point(584, 73);
            this.salesRep.Name = "salesRep";
            this.salesRep.Size = new System.Drawing.Size(394, 26);
            this.salesRep.StartIndex = 0;
            this.salesRep.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(515, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "Credit";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(481, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 44;
            this.label13.Text = "Sales Rep";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtaddressline2
            // 
            this.txtaddressline2.BackColor = System.Drawing.Color.Transparent;
            this.txtaddressline2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtaddressline2.EdgeColor = System.Drawing.Color.White;
            this.txtaddressline2.Enabled = false;
            this.txtaddressline2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddressline2.ForeColor = System.Drawing.Color.DimGray;
            this.txtaddressline2.Location = new System.Drawing.Point(584, 40);
            this.txtaddressline2.MaxLength = 32767;
            this.txtaddressline2.Multiline = false;
            this.txtaddressline2.Name = "txtaddressline2";
            this.txtaddressline2.ReadOnly = false;
            this.txtaddressline2.Size = new System.Drawing.Size(394, 28);
            this.txtaddressline2.TabIndex = 43;
            this.txtaddressline2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaddressline2.UseSystemPasswordChar = false;
            // 
            // txtaddressline
            // 
            this.txtaddressline.BackColor = System.Drawing.Color.Transparent;
            this.txtaddressline.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtaddressline.EdgeColor = System.Drawing.Color.White;
            this.txtaddressline.Enabled = false;
            this.txtaddressline.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddressline.ForeColor = System.Drawing.Color.DimGray;
            this.txtaddressline.Location = new System.Drawing.Point(584, 6);
            this.txtaddressline.MaxLength = 32767;
            this.txtaddressline.Multiline = false;
            this.txtaddressline.Name = "txtaddressline";
            this.txtaddressline.ReadOnly = false;
            this.txtaddressline.Size = new System.Drawing.Size(394, 28);
            this.txtaddressline.TabIndex = 42;
            this.txtaddressline.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtaddressline.UseSystemPasswordChar = false;
            // 
            // cmbpostalcode
            // 
            this.cmbpostalcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbpostalcode.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbpostalcode.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbpostalcode.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbpostalcode.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbpostalcode.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbpostalcode.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbpostalcode.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbpostalcode.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbpostalcode.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbpostalcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbpostalcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbpostalcode.DropDownHeight = 100;
            this.cmbpostalcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpostalcode.Enabled = false;
            this.cmbpostalcode.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpostalcode.ForeColor = System.Drawing.Color.Black;
            this.cmbpostalcode.FormattingEnabled = true;
            this.cmbpostalcode.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbpostalcode.IntegralHeight = false;
            this.cmbpostalcode.ItemHeight = 20;
            this.cmbpostalcode.Location = new System.Drawing.Point(181, 272);
            this.cmbpostalcode.Name = "cmbpostalcode";
            this.cmbpostalcode.Size = new System.Drawing.Size(252, 26);
            this.cmbpostalcode.StartIndex = 0;
            this.cmbpostalcode.TabIndex = 41;
            this.cmbpostalcode.SelectedIndexChanged += new System.EventHandler(this.cmbpostalcode_SelectedIndexChanged_1);
            this.cmbpostalcode.Click += new System.EventHandler(this.cmbpostalcode_Click);
            // 
            // cmbcity
            // 
            this.cmbcity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbcity.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbcity.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbcity.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbcity.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbcity.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbcity.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbcity.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbcity.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbcity.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbcity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcity.DropDownHeight = 100;
            this.cmbcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcity.Enabled = false;
            this.cmbcity.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcity.ForeColor = System.Drawing.Color.Black;
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbcity.IntegralHeight = false;
            this.cmbcity.ItemHeight = 20;
            this.cmbcity.Location = new System.Drawing.Point(181, 240);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(252, 26);
            this.cmbcity.StartIndex = 0;
            this.cmbcity.TabIndex = 40;
            this.cmbcity.SelectedIndexChanged += new System.EventHandler(this.cmbcity_SelectedIndexChanged_1);
            // 
            // cmbstate
            // 
            this.cmbstate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbstate.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbstate.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbstate.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbstate.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbstate.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbstate.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbstate.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbstate.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbstate.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbstate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbstate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbstate.DropDownHeight = 100;
            this.cmbstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstate.Enabled = false;
            this.cmbstate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstate.ForeColor = System.Drawing.Color.Black;
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbstate.IntegralHeight = false;
            this.cmbstate.ItemHeight = 20;
            this.cmbstate.Location = new System.Drawing.Point(181, 208);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(252, 26);
            this.cmbstate.StartIndex = 0;
            this.cmbstate.TabIndex = 39;
            this.cmbstate.SelectedIndexChanged += new System.EventHandler(this.cmbstate_SelectedIndexChanged);
            // 
            // cmbcountry
            // 
            this.cmbcountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbcountry.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbcountry.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbcountry.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbcountry.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbcountry.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbcountry.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbcountry.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbcountry.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbcountry.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbcountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcountry.DropDownHeight = 100;
            this.cmbcountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcountry.Enabled = false;
            this.cmbcountry.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcountry.ForeColor = System.Drawing.Color.Black;
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbcountry.IntegralHeight = false;
            this.cmbcountry.ItemHeight = 20;
            this.cmbcountry.Location = new System.Drawing.Point(181, 176);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(252, 26);
            this.cmbcountry.StartIndex = 0;
            this.cmbcountry.TabIndex = 38;
            this.cmbcountry.SelectedIndexChanged += new System.EventHandler(this.cmbcountry_SelectedIndexChanged);
            this.cmbcountry.SelectionChangeCommitted += new System.EventHandler(this.cmbcountry_SelectionChangeCommitted);
            this.cmbcountry.Click += new System.EventHandler(this.cmbcountry_Click);
            // 
            // txtcontactNumber
            // 
            this.txtcontactNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtcontactNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtcontactNumber.EdgeColor = System.Drawing.Color.White;
            this.txtcontactNumber.Enabled = false;
            this.txtcontactNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtcontactNumber.Location = new System.Drawing.Point(181, 142);
            this.txtcontactNumber.MaxLength = 32767;
            this.txtcontactNumber.Multiline = false;
            this.txtcontactNumber.Name = "txtcontactNumber";
            this.txtcontactNumber.ReadOnly = false;
            this.txtcontactNumber.Size = new System.Drawing.Size(252, 28);
            this.txtcontactNumber.TabIndex = 37;
            this.txtcontactNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontactNumber.UseSystemPasswordChar = false;
            // 
            // txtfirstName
            // 
            this.txtfirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtfirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtfirstName.EdgeColor = System.Drawing.Color.White;
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtfirstName.Location = new System.Drawing.Point(181, 108);
            this.txtfirstName.MaxLength = 32767;
            this.txtfirstName.Multiline = false;
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.ReadOnly = false;
            this.txtfirstName.Size = new System.Drawing.Size(252, 28);
            this.txtfirstName.TabIndex = 36;
            this.txtfirstName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfirstName.UseSystemPasswordChar = false;
            // 
            // txtlastName
            // 
            this.txtlastName.BackColor = System.Drawing.Color.Transparent;
            this.txtlastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtlastName.EdgeColor = System.Drawing.Color.White;
            this.txtlastName.Enabled = false;
            this.txtlastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtlastName.Location = new System.Drawing.Point(181, 74);
            this.txtlastName.MaxLength = 32767;
            this.txtlastName.Multiline = false;
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.ReadOnly = false;
            this.txtlastName.Size = new System.Drawing.Size(252, 28);
            this.txtlastName.TabIndex = 35;
            this.txtlastName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlastName.UseSystemPasswordChar = false;
            // 
            // txtcustName
            // 
            this.txtcustName.BackColor = System.Drawing.Color.Transparent;
            this.txtcustName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtcustName.EdgeColor = System.Drawing.Color.White;
            this.txtcustName.Enabled = false;
            this.txtcustName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustName.ForeColor = System.Drawing.Color.DimGray;
            this.txtcustName.Location = new System.Drawing.Point(181, 40);
            this.txtcustName.MaxLength = 32767;
            this.txtcustName.Multiline = false;
            this.txtcustName.Name = "txtcustName";
            this.txtcustName.ReadOnly = false;
            this.txtcustName.Size = new System.Drawing.Size(252, 28);
            this.txtcustName.TabIndex = 34;
            this.txtcustName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcustName.UseSystemPasswordChar = false;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCustomerNumber.EdgeColor = System.Drawing.Color.White;
            this.txtCustomerNumber.Enabled = false;
            this.txtCustomerNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomerNumber.Location = new System.Drawing.Point(181, 6);
            this.txtCustomerNumber.MaxLength = 32767;
            this.txtCustomerNumber.Multiline = false;
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.ReadOnly = false;
            this.txtCustomerNumber.Size = new System.Drawing.Size(252, 28);
            this.txtCustomerNumber.TabIndex = 33;
            this.txtCustomerNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCustomerNumber.UseSystemPasswordChar = false;
            this.txtCustomerNumber.TextChanged += new System.EventHandler(this.txtCustomerNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(439, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Address Line 2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(439, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Address Line 1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(60, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Postal Code";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(131, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "City";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(119, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "State";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(96, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Country";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(23, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Contact Number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(-1, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contact Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dgCustomers);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Customers";
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AllowUserToResizeRows = false;
            this.dgCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCustomers.EnableHeadersVisualStyles = false;
            this.dgCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgCustomers.Location = new System.Drawing.Point(6, 0);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(986, 442);
            this.dgCustomers.TabIndex = 0;
            this.dgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentClick_1);
            this.dgCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomers_CellContentDoubleClick_1);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.SteelBlue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-28, 0);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1175, 33);
            this.materialDivider1.TabIndex = 58;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BaseColor = System.Drawing.Color.LightCoral;
            this.exitBtn.BorderColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DisabledBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.exitBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.exitBtn.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(178)))), ((int)(((byte)(190)))));
            this.exitBtn.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.exitBtn.EnabledCalc = true;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1063, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitBtn.Size = new System.Drawing.Size(84, 33);
            this.exitBtn.TabIndex = 57;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.exitBtn_Click_1);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1145, 520);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.customerTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCustomers";
            this.RightToLeftLayout = true;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.customers_Load);
            this.customerTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage customerTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgCustomers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbcity;
        private ReaLTaiizor.Controls.DungeonComboBox cmbstate;
        private ReaLTaiizor.Controls.DungeonComboBox cmbcountry;
        private ReaLTaiizor.Controls.DungeonTextBox txtcontactNumber;
        private ReaLTaiizor.Controls.DungeonTextBox txtfirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtlastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtcustName;
        private ReaLTaiizor.Controls.DungeonTextBox txtCustomerNumber;
        private ReaLTaiizor.Controls.DungeonTextBox credit;
        private ReaLTaiizor.Controls.DungeonComboBox salesRep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private ReaLTaiizor.Controls.DungeonTextBox txtaddressline2;
        private ReaLTaiizor.Controls.DungeonTextBox txtaddressline;
        private ReaLTaiizor.Controls.DungeonComboBox cmbpostalcode;
        private ReaLTaiizor.Controls.MaterialButton cnfrmBtn;
        private ReaLTaiizor.Controls.MaterialButton edtBtn;
        private ReaLTaiizor.Controls.MaterialButton cnlBtn;
        private ReaLTaiizor.Controls.MaterialButton newBtn;
        private ReaLTaiizor.Controls.MaterialButton dltBtn;
        private ReaLTaiizor.Controls.MaterialButton lstBtn;
        private ReaLTaiizor.Controls.MaterialButton nxtBtn;
        private ReaLTaiizor.Controls.MaterialButton prevBtn;
        private ReaLTaiizor.Controls.MaterialButton frstBtn;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private ReaLTaiizor.Controls.FoxButton exitBtn;
    }
}