using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class frmLogin : Form
    {
        ClassicModels cm = new ClassicModels();
        public frmLogin()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void dungeonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cm.Authentication(username.Text.Trim(), password.Text.Trim()))
            {
                Form main = new frmMain();
                main.Show();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }
    }
}
