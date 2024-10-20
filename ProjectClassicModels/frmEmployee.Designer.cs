namespace ProjectClassicModels
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeTab = new ReaLTaiizor.Controls.AirTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exitBtn = new ReaLTaiizor.Controls.FoxButton();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.cnfrmBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.edtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.cnlBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.newBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.dltBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.lstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.nxtBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.prevBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.frstBtn = new ReaLTaiizor.Controls.MaterialButton();
            this.cmbJobTitle = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbReportsTo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbOfficeCode = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbExtension = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtEmployeeEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtEmployeeLastName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtEmployeeFirstName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtEmployeeNumber = new ReaLTaiizor.Controls.DungeonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmployees = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.employeeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTab
            // 
            this.employeeTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.employeeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeTab.BaseColor = System.Drawing.Color.AliceBlue;
            this.employeeTab.Controls.Add(this.tabPage1);
            this.employeeTab.Controls.Add(this.tabPage2);
            this.employeeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F);
            this.employeeTab.ItemSize = new System.Drawing.Size(30, 115);
            this.employeeTab.Location = new System.Drawing.Point(12, 51);
            this.employeeTab.Multiline = true;
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.NormalTextColor = System.Drawing.Color.Black;
            this.employeeTab.SelectedIndex = 0;
            this.employeeTab.SelectedTabBackColor = System.Drawing.Color.White;
            this.employeeTab.SelectedTextColor = System.Drawing.Color.Black;
            this.employeeTab.ShowOuterBorders = false;
            this.employeeTab.Size = new System.Drawing.Size(739, 460);
            this.employeeTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.employeeTab.SquareColor = System.Drawing.SystemColors.HotTrack;
            this.employeeTab.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.employeeTab.TabIndex = 0;
            this.employeeTab.SelectedIndexChanged += new System.EventHandler(this.employeeTab_SelectedIndexChanged);
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
            this.tabPage1.Controls.Add(this.cmbJobTitle);
            this.tabPage1.Controls.Add(this.cmbReportsTo);
            this.tabPage1.Controls.Add(this.cmbOfficeCode);
            this.tabPage1.Controls.Add(this.cmbExtension);
            this.tabPage1.Controls.Add(this.txtEmployeeEmail);
            this.tabPage1.Controls.Add(this.txtEmployeeLastName);
            this.tabPage1.Controls.Add(this.txtEmployeeFirstName);
            this.tabPage1.Controls.Add(this.txtEmployeeNumber);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(616, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Employee";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dgEmployees);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(616, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Employees";
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
            this.exitBtn.Location = new System.Drawing.Point(680, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitBtn.Size = new System.Drawing.Size(84, 33);
            this.exitBtn.TabIndex = 59;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new ReaLTaiizor.Util.FoxBase.ButtonFoxBase.ClickEventHandler(this.exitBtn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.SteelBlue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-73, -1);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(837, 33);
            this.materialDivider1.TabIndex = 60;
            this.materialDivider1.Text = "materialDivider1";
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
            // cmbJobTitle
            // 
            this.cmbJobTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbJobTitle.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbJobTitle.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbJobTitle.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbJobTitle.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbJobTitle.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbJobTitle.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbJobTitle.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbJobTitle.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbJobTitle.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbJobTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbJobTitle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJobTitle.DropDownHeight = 100;
            this.cmbJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobTitle.Enabled = false;
            this.cmbJobTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJobTitle.ForeColor = System.Drawing.Color.Black;
            this.cmbJobTitle.FormattingEnabled = true;
            this.cmbJobTitle.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbJobTitle.IntegralHeight = false;
            this.cmbJobTitle.ItemHeight = 20;
            this.cmbJobTitle.Location = new System.Drawing.Point(181, 235);
            this.cmbJobTitle.Name = "cmbJobTitle";
            this.cmbJobTitle.Size = new System.Drawing.Size(252, 26);
            this.cmbJobTitle.StartIndex = 0;
            this.cmbJobTitle.TabIndex = 76;
            // 
            // cmbReportsTo
            // 
            this.cmbReportsTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbReportsTo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbReportsTo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbReportsTo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbReportsTo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbReportsTo.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbReportsTo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbReportsTo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbReportsTo.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbReportsTo.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbReportsTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReportsTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReportsTo.DropDownHeight = 100;
            this.cmbReportsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportsTo.Enabled = false;
            this.cmbReportsTo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportsTo.ForeColor = System.Drawing.Color.Black;
            this.cmbReportsTo.FormattingEnabled = true;
            this.cmbReportsTo.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbReportsTo.IntegralHeight = false;
            this.cmbReportsTo.ItemHeight = 20;
            this.cmbReportsTo.Location = new System.Drawing.Point(181, 203);
            this.cmbReportsTo.Name = "cmbReportsTo";
            this.cmbReportsTo.Size = new System.Drawing.Size(252, 26);
            this.cmbReportsTo.StartIndex = 0;
            this.cmbReportsTo.TabIndex = 75;
            // 
            // cmbOfficeCode
            // 
            this.cmbOfficeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbOfficeCode.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbOfficeCode.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbOfficeCode.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbOfficeCode.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbOfficeCode.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbOfficeCode.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbOfficeCode.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbOfficeCode.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbOfficeCode.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbOfficeCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbOfficeCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOfficeCode.DropDownHeight = 100;
            this.cmbOfficeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfficeCode.Enabled = false;
            this.cmbOfficeCode.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOfficeCode.ForeColor = System.Drawing.Color.Black;
            this.cmbOfficeCode.FormattingEnabled = true;
            this.cmbOfficeCode.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbOfficeCode.IntegralHeight = false;
            this.cmbOfficeCode.ItemHeight = 20;
            this.cmbOfficeCode.Location = new System.Drawing.Point(181, 171);
            this.cmbOfficeCode.Name = "cmbOfficeCode";
            this.cmbOfficeCode.Size = new System.Drawing.Size(252, 26);
            this.cmbOfficeCode.StartIndex = 0;
            this.cmbOfficeCode.TabIndex = 74;
            // 
            // cmbExtension
            // 
            this.cmbExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbExtension.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbExtension.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbExtension.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbExtension.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbExtension.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbExtension.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbExtension.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbExtension.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbExtension.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbExtension.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbExtension.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExtension.DropDownHeight = 100;
            this.cmbExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtension.Enabled = false;
            this.cmbExtension.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExtension.ForeColor = System.Drawing.Color.Black;
            this.cmbExtension.FormattingEnabled = true;
            this.cmbExtension.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbExtension.IntegralHeight = false;
            this.cmbExtension.ItemHeight = 20;
            this.cmbExtension.Location = new System.Drawing.Point(181, 139);
            this.cmbExtension.Name = "cmbExtension";
            this.cmbExtension.Size = new System.Drawing.Size(252, 26);
            this.cmbExtension.StartIndex = 0;
            this.cmbExtension.TabIndex = 73;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmployeeEmail.EdgeColor = System.Drawing.Color.White;
            this.txtEmployeeEmail.Enabled = false;
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(181, 105);
            this.txtEmployeeEmail.MaxLength = 32767;
            this.txtEmployeeEmail.Multiline = false;
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.ReadOnly = false;
            this.txtEmployeeEmail.Size = new System.Drawing.Size(252, 28);
            this.txtEmployeeEmail.TabIndex = 71;
            this.txtEmployeeEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeEmail.UseSystemPasswordChar = false;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmployeeLastName.EdgeColor = System.Drawing.Color.White;
            this.txtEmployeeLastName.Enabled = false;
            this.txtEmployeeLastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmployeeLastName.Location = new System.Drawing.Point(181, 71);
            this.txtEmployeeLastName.MaxLength = 32767;
            this.txtEmployeeLastName.Multiline = false;
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.ReadOnly = false;
            this.txtEmployeeLastName.Size = new System.Drawing.Size(252, 28);
            this.txtEmployeeLastName.TabIndex = 70;
            this.txtEmployeeLastName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeLastName.UseSystemPasswordChar = false;
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmployeeFirstName.EdgeColor = System.Drawing.Color.White;
            this.txtEmployeeFirstName.Enabled = false;
            this.txtEmployeeFirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(181, 37);
            this.txtEmployeeFirstName.MaxLength = 32767;
            this.txtEmployeeFirstName.Multiline = false;
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.ReadOnly = false;
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(252, 28);
            this.txtEmployeeFirstName.TabIndex = 69;
            this.txtEmployeeFirstName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeFirstName.UseSystemPasswordChar = false;
            this.txtEmployeeFirstName.TextChanged += new System.EventHandler(this.txtcustName_TextChanged);
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeeNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmployeeNumber.EdgeColor = System.Drawing.Color.White;
            this.txtEmployeeNumber.Enabled = false;
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmployeeNumber.Location = new System.Drawing.Point(181, 3);
            this.txtEmployeeNumber.MaxLength = 32767;
            this.txtEmployeeNumber.Multiline = false;
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.ReadOnly = false;
            this.txtEmployeeNumber.Size = new System.Drawing.Size(252, 28);
            this.txtEmployeeNumber.TabIndex = 68;
            this.txtEmployeeNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeNumber.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(94, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Job Title";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(72, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Reports To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(66, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Office Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(114, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(80, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Extension";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(70, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 59;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(72, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Employee Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.AllowUserToDeleteRows = false;
            this.dgEmployees.AllowUserToResizeRows = false;
            this.dgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmployees.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgEmployees.EnableHeadersVisualStyles = false;
            this.dgEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgEmployees.Location = new System.Drawing.Point(6, 6);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.ReadOnly = true;
            this.dgEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployees.Size = new System.Drawing.Size(604, 440);
            this.dgEmployees.TabIndex = 1;
            this.dgEmployees.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellContentDoubleClick_1);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(763, 523);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.employeeTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmEmployee";
            this.RightToLeftLayout = true;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.employeeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage employeeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ReaLTaiizor.Controls.FoxButton exitBtn;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private ReaLTaiizor.Controls.MaterialButton cnfrmBtn;
        private ReaLTaiizor.Controls.MaterialButton edtBtn;
        private ReaLTaiizor.Controls.MaterialButton cnlBtn;
        private ReaLTaiizor.Controls.MaterialButton newBtn;
        private ReaLTaiizor.Controls.MaterialButton dltBtn;
        private ReaLTaiizor.Controls.MaterialButton lstBtn;
        private ReaLTaiizor.Controls.MaterialButton nxtBtn;
        private ReaLTaiizor.Controls.MaterialButton prevBtn;
        private ReaLTaiizor.Controls.MaterialButton frstBtn;
        private ReaLTaiizor.Controls.DungeonComboBox cmbJobTitle;
        private ReaLTaiizor.Controls.DungeonComboBox cmbReportsTo;
        private ReaLTaiizor.Controls.DungeonComboBox cmbOfficeCode;
        private ReaLTaiizor.Controls.DungeonComboBox cmbExtension;
        private ReaLTaiizor.Controls.DungeonTextBox txtEmployeeEmail;
        private ReaLTaiizor.Controls.DungeonTextBox txtEmployeeLastName;
        private ReaLTaiizor.Controls.DungeonTextBox txtEmployeeFirstName;
        private ReaLTaiizor.Controls.DungeonTextBox txtEmployeeNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgEmployees;
    }
}