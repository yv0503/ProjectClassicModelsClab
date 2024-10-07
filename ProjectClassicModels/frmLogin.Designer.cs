namespace ProjectClassicModels
{
    partial class frmLogin
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new ReaLTaiizor.Controls.DungeonTextBox();
            this.password = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnOk = new ReaLTaiizor.Controls.MaterialButton();
            this.crownListView1 = new ReaLTaiizor.Controls.CrownListView();
            this.btnCncl = new ReaLTaiizor.Controls.MaterialButton();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(311, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.username.EdgeColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Tahoma", 11F);
            this.username.ForeColor = System.Drawing.Color.DimGray;
            this.username.Location = new System.Drawing.Point(413, 77);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(200, 28);
            this.username.TabIndex = 8;
            this.username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.UseSystemPasswordChar = false;
            this.username.TextChanged += new System.EventHandler(this.dungeonTextBox1_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.password.EdgeColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password.ForeColor = System.Drawing.Color.DimGray;
            this.password.Location = new System.Drawing.Point(413, 111);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(200, 28);
            this.password.TabIndex = 9;
            this.password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = null;
            this.btnOk.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnOk.Location = new System.Drawing.Point(413, 148);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk.Size = new System.Drawing.Size(67, 36);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Enter";
            this.btnOk.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // crownListView1
            // 
            this.crownListView1.Location = new System.Drawing.Point(558, 289);
            this.crownListView1.Name = "crownListView1";
            this.crownListView1.Size = new System.Drawing.Size(75, 23);
            this.crownListView1.TabIndex = 11;
            this.crownListView1.Text = "crownListView1";
            // 
            // btnCncl
            // 
            this.btnCncl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCncl.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCncl.Depth = 0;
            this.btnCncl.HighEmphasis = true;
            this.btnCncl.Icon = null;
            this.btnCncl.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCncl.Location = new System.Drawing.Point(488, 148);
            this.btnCncl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCncl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCncl.Size = new System.Drawing.Size(77, 36);
            this.btnCncl.TabIndex = 12;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCncl.UseAccentColor = false;
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.DarkGray;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, -5);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(287, 230);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 224);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.crownListView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ReaLTaiizor.Controls.DungeonTextBox username;
        private ReaLTaiizor.Controls.DungeonTextBox password;
        private ReaLTaiizor.Controls.MaterialButton btnOk;
        private ReaLTaiizor.Controls.CrownListView crownListView1;
        private ReaLTaiizor.Controls.MaterialButton btnCncl;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
    }
}

