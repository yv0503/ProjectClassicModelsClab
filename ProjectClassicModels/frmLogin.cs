using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class frmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse 
               );


        //[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.dll", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //protected override CreateParams CreateParams{
        //    get { 
        //        CreateParams cp = base.CreateParams;
        //        cp.Style = 0x20000;
        //        return cp;
        //    }
        //}

        ClassicModels cm = new ClassicModels();
        public frmLogin()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
                this.Hide();
                Form main = new frmMain();
                main.ShowDialog();
                main = null;
                this.Show();  
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

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnOk_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
