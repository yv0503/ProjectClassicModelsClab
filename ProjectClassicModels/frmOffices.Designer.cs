namespace ProjectClassicModels
{
    partial class frmOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffices));
            this.officeTab = new ReaLTaiizor.Controls.AirTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbterritory = new ReaLTaiizor.Controls.DungeonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cnfrmBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.edtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.cnlBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.newBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.dltBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.lstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.nxtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.prevBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.frstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.cmbpostalcode = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbcountry = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbstate = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbcity = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtAddressLine2 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtAddressLine1 = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtPhoneNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtOfficeCode = new ReaLTaiizor.Controls.DungeonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgOffice = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.exitBtn = new ReaLTaiizor.Controls.FoxButton();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.officeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOffice)).BeginInit();
            this.SuspendLayout();
            // 
            // officeTab
            // 
            this.officeTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.officeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.officeTab.BaseColor = System.Drawing.Color.AliceBlue;
            this.officeTab.Controls.Add(this.tabPage1);
            this.officeTab.Controls.Add(this.tabPage2);
            this.officeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.officeTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.officeTab.ItemSize = new System.Drawing.Size(30, 115);
            this.officeTab.Location = new System.Drawing.Point(12, 39);
            this.officeTab.Multiline = true;
            this.officeTab.Name = "officeTab";
            this.officeTab.NormalTextColor = System.Drawing.Color.Black;
            this.officeTab.SelectedIndex = 0;
            this.officeTab.SelectedTabBackColor = System.Drawing.Color.White;
            this.officeTab.SelectedTextColor = System.Drawing.Color.Black;
            this.officeTab.ShowOuterBorders = false;
            this.officeTab.Size = new System.Drawing.Size(951, 463);
            this.officeTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.officeTab.SquareColor = System.Drawing.SystemColors.HotTrack;
            this.officeTab.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.officeTab.TabIndex = 61;
            this.officeTab.SelectedIndexChanged += new System.EventHandler(this.officeTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cmbterritory);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cnfrmBtn);
            this.tabPage1.Controls.Add(this.edtBtn);
            this.tabPage1.Controls.Add(this.cnlBtn);
            this.tabPage1.Controls.Add(this.newBtn);
            this.tabPage1.Controls.Add(this.dltBtn);
            this.tabPage1.Controls.Add(this.lstBtn);
            this.tabPage1.Controls.Add(this.nxtBtn);
            this.tabPage1.Controls.Add(this.prevBtn);
            this.tabPage1.Controls.Add(this.frstBtn);
            this.tabPage1.Controls.Add(this.cmbpostalcode);
            this.tabPage1.Controls.Add(this.cmbcountry);
            this.tabPage1.Controls.Add(this.cmbstate);
            this.tabPage1.Controls.Add(this.cmbcity);
            this.tabPage1.Controls.Add(this.txtAddressLine2);
            this.tabPage1.Controls.Add(this.txtAddressLine1);
            this.tabPage1.Controls.Add(this.txtPhoneNumber);
            this.tabPage1.Controls.Add(this.txtOfficeCode);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Office";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmbterritory
            // 
            this.cmbterritory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbterritory.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbterritory.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbterritory.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbterritory.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbterritory.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbterritory.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbterritory.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbterritory.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbterritory.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbterritory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbterritory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbterritory.DropDownHeight = 100;
            this.cmbterritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbterritory.Enabled = false;
            this.cmbterritory.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbterritory.ForeColor = System.Drawing.Color.Black;
            this.cmbterritory.FormattingEnabled = true;
            this.cmbterritory.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbterritory.IntegralHeight = false;
            this.cmbterritory.ItemHeight = 20;
            this.cmbterritory.Location = new System.Drawing.Point(181, 267);
            this.cmbterritory.Name = "cmbterritory";
            this.cmbterritory.Size = new System.Drawing.Size(252, 26);
            this.cmbterritory.StartIndex = 0;
            this.cmbterritory.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(92, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "Territory";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cnfrmBtn.Location = new System.Drawing.Point(449, 105);
            this.cnfrmBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cnfrmBtn.MinimumSize = new System.Drawing.Size(160, 0);
            this.cnfrmBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cnfrmBtn.Name = "cnfrmBtn";
            this.cnfrmBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cnfrmBtn.Size = new System.Drawing.Size(160, 36);
            this.cnfrmBtn.TabIndex = 91;
            this.cnfrmBtn.Text = "Confirm";
            this.cnfrmBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cnfrmBtn.UseAccentColor = false;
            this.cnfrmBtn.UseVisualStyleBackColor = true;
            this.cnfrmBtn.Click += new System.EventHandler(this.cnfrmBtn_Click);
            // 
            // edtBtn
            // 
            this.edtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edtBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.edtBtn.Depth = 0;
            this.edtBtn.HighEmphasis = true;
            this.edtBtn.Icon = null;
            this.edtBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.edtBtn.Location = new System.Drawing.Point(449, 57);
            this.edtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edtBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.edtBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.edtBtn.Name = "edtBtn";
            this.edtBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.edtBtn.Size = new System.Drawing.Size(75, 36);
            this.edtBtn.TabIndex = 90;
            this.edtBtn.Text = "Edit";
            this.edtBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.edtBtn.UseAccentColor = false;
            this.edtBtn.UseVisualStyleBackColor = true;
            this.edtBtn.Click += new System.EventHandler(this.edtBtn_Click);
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
            this.cnlBtn.Location = new System.Drawing.Point(532, 57);
            this.cnlBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cnlBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.cnlBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.cnlBtn.Name = "cnlBtn";
            this.cnlBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cnlBtn.Size = new System.Drawing.Size(77, 36);
            this.cnlBtn.TabIndex = 89;
            this.cnlBtn.Text = "Cancel";
            this.cnlBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cnlBtn.UseAccentColor = false;
            this.cnlBtn.UseVisualStyleBackColor = true;
            this.cnlBtn.Click += new System.EventHandler(this.cnlBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.newBtn.Depth = 0;
            this.newBtn.HighEmphasis = true;
            this.newBtn.Icon = null;
            this.newBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.newBtn.Location = new System.Drawing.Point(449, 9);
            this.newBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.newBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.newBtn.Name = "newBtn";
            this.newBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.newBtn.Size = new System.Drawing.Size(75, 36);
            this.newBtn.TabIndex = 88;
            this.newBtn.Text = "New";
            this.newBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newBtn.UseAccentColor = false;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
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
            this.dltBtn.Location = new System.Drawing.Point(534, 9);
            this.dltBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dltBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.dltBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.dltBtn.Size = new System.Drawing.Size(75, 36);
            this.dltBtn.TabIndex = 87;
            this.dltBtn.Text = "Delete";
            this.dltBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.dltBtn.UseAccentColor = false;
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // lstBtn
            // 
            this.lstBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lstBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lstBtn.Depth = 0;
            this.lstBtn.HighEmphasis = true;
            this.lstBtn.Icon = null;
            this.lstBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.lstBtn.Location = new System.Drawing.Point(260, 406);
            this.lstBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.lstBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.lstBtn.Name = "lstBtn";
            this.lstBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lstBtn.Size = new System.Drawing.Size(75, 36);
            this.lstBtn.TabIndex = 86;
            this.lstBtn.Text = "Last";
            this.lstBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lstBtn.UseAccentColor = false;
            this.lstBtn.UseVisualStyleBackColor = true;
            this.lstBtn.Click += new System.EventHandler(this.lstBtn_Click);
            // 
            // nxtBtn
            // 
            this.nxtBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nxtBtn.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nxtBtn.Depth = 0;
            this.nxtBtn.HighEmphasis = true;
            this.nxtBtn.Icon = null;
            this.nxtBtn.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.nxtBtn.Location = new System.Drawing.Point(177, 406);
            this.nxtBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nxtBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.nxtBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nxtBtn.Size = new System.Drawing.Size(75, 36);
            this.nxtBtn.TabIndex = 85;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nxtBtn.UseAccentColor = false;
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.nxtBtn_Click);
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
            this.prevBtn.Location = new System.Drawing.Point(94, 406);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.prevBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.prevBtn.Size = new System.Drawing.Size(75, 36);
            this.prevBtn.TabIndex = 84;
            this.prevBtn.Text = "Prev";
            this.prevBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.prevBtn.UseAccentColor = false;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
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
            this.frstBtn.Location = new System.Drawing.Point(11, 406);
            this.frstBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.frstBtn.MinimumSize = new System.Drawing.Size(75, 0);
            this.frstBtn.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.frstBtn.Name = "frstBtn";
            this.frstBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.frstBtn.Size = new System.Drawing.Size(75, 36);
            this.frstBtn.TabIndex = 83;
            this.frstBtn.Text = "First";
            this.frstBtn.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.frstBtn.UseAccentColor = false;
            this.frstBtn.UseVisualStyleBackColor = true;
            this.frstBtn.Click += new System.EventHandler(this.frstBtn_Click);
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
            this.cmbpostalcode.Location = new System.Drawing.Point(181, 235);
            this.cmbpostalcode.Name = "cmbpostalcode";
            this.cmbpostalcode.Size = new System.Drawing.Size(252, 26);
            this.cmbpostalcode.StartIndex = 0;
            this.cmbpostalcode.TabIndex = 76;
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
            this.cmbcountry.Location = new System.Drawing.Point(181, 203);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(252, 26);
            this.cmbcountry.StartIndex = 0;
            this.cmbcountry.TabIndex = 75;
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
            this.cmbstate.Location = new System.Drawing.Point(181, 171);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(252, 26);
            this.cmbstate.StartIndex = 0;
            this.cmbstate.TabIndex = 74;
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
            this.cmbcity.Location = new System.Drawing.Point(181, 139);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(252, 26);
            this.cmbcity.StartIndex = 0;
            this.cmbcity.TabIndex = 73;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.BackColor = System.Drawing.Color.Transparent;
            this.txtAddressLine2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddressLine2.EdgeColor = System.Drawing.Color.White;
            this.txtAddressLine2.Enabled = false;
            this.txtAddressLine2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine2.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddressLine2.Location = new System.Drawing.Point(181, 105);
            this.txtAddressLine2.MaxLength = 32767;
            this.txtAddressLine2.Multiline = false;
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.ReadOnly = false;
            this.txtAddressLine2.Size = new System.Drawing.Size(252, 28);
            this.txtAddressLine2.TabIndex = 71;
            this.txtAddressLine2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddressLine2.UseSystemPasswordChar = false;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.BackColor = System.Drawing.Color.Transparent;
            this.txtAddressLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtAddressLine1.EdgeColor = System.Drawing.Color.White;
            this.txtAddressLine1.Enabled = false;
            this.txtAddressLine1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine1.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddressLine1.Location = new System.Drawing.Point(181, 71);
            this.txtAddressLine1.MaxLength = 32767;
            this.txtAddressLine1.Multiline = false;
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.ReadOnly = false;
            this.txtAddressLine1.Size = new System.Drawing.Size(252, 28);
            this.txtAddressLine1.TabIndex = 70;
            this.txtAddressLine1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddressLine1.UseSystemPasswordChar = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPhoneNumber.EdgeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.Location = new System.Drawing.Point(181, 37);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = false;
            this.txtPhoneNumber.Size = new System.Drawing.Size(252, 28);
            this.txtPhoneNumber.TabIndex = 69;
            this.txtPhoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // txtOfficeCode
            // 
            this.txtOfficeCode.BackColor = System.Drawing.Color.Transparent;
            this.txtOfficeCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtOfficeCode.EdgeColor = System.Drawing.Color.White;
            this.txtOfficeCode.Enabled = false;
            this.txtOfficeCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtOfficeCode.Location = new System.Drawing.Point(181, 3);
            this.txtOfficeCode.MaxLength = 32767;
            this.txtOfficeCode.Multiline = false;
            this.txtOfficeCode.Name = "txtOfficeCode";
            this.txtOfficeCode.ReadOnly = false;
            this.txtOfficeCode.Size = new System.Drawing.Size(252, 28);
            this.txtOfficeCode.TabIndex = 68;
            this.txtOfficeCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOfficeCode.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(60, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Postal Code";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(96, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Country";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(119, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "State";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(36, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "Address Line 1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(36, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Address Line 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(34, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "Phone Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(131, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "City";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Office Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dgOffice);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Offices";
            // 
            // dgOffice
            // 
            this.dgOffice.AllowUserToAddRows = false;
            this.dgOffice.AllowUserToDeleteRows = false;
            this.dgOffice.AllowUserToResizeRows = false;
            this.dgOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOffice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgOffice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOffice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgOffice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOffice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOffice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOffice.EnableHeadersVisualStyles = false;
            this.dgOffice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgOffice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgOffice.Location = new System.Drawing.Point(6, 6);
            this.dgOffice.Name = "dgOffice";
            this.dgOffice.ReadOnly = true;
            this.dgOffice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOffice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgOffice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOffice.Size = new System.Drawing.Size(816, 443);
            this.dgOffice.TabIndex = 1;
            this.dgOffice.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOffice_CellContentDoubleClick);
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
            this.exitBtn.Location = new System.Drawing.Point(865, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitBtn.Size = new System.Drawing.Size(110, 33);
            this.exitBtn.TabIndex = 62;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.exitBtn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.SteelBlue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 0);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(976, 33);
            this.materialDivider1.TabIndex = 63;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // frmOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(975, 502);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.officeTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOffices";
            this.RightToLeftLayout = true;
            this.Text = "Offices";
            this.Load += new System.EventHandler(this.frmOffices_Load);
            this.officeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOffice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.AirTabPage officeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialButton cnfrmBtn;
        private ReaLTaiizor.Controls.MaterialButton edtBtn;
        private ReaLTaiizor.Controls.MaterialButton cnlBtn;
        private ReaLTaiizor.Controls.MaterialButton newBtn;
        private ReaLTaiizor.Controls.MaterialButton dltBtn;
        private ReaLTaiizor.Controls.MaterialButton lstBtn;
        private ReaLTaiizor.Controls.MaterialButton nxtBtn;
        private ReaLTaiizor.Controls.MaterialButton prevBtn;
        private ReaLTaiizor.Controls.MaterialButton frstBtn;
        private ReaLTaiizor.Controls.DungeonComboBox cmbpostalcode;
        private ReaLTaiizor.Controls.DungeonComboBox cmbcountry;
        private ReaLTaiizor.Controls.DungeonComboBox cmbstate;
        private ReaLTaiizor.Controls.DungeonComboBox cmbcity;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddressLine2;
        private ReaLTaiizor.Controls.DungeonTextBox txtAddressLine1;
        private ReaLTaiizor.Controls.DungeonTextBox txtPhoneNumber;
        private ReaLTaiizor.Controls.DungeonTextBox txtOfficeCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgOffice;
        private System.Windows.Forms.Label label7;
        private ReaLTaiizor.Controls.FoxButton exitBtn;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbterritory;
    }
}