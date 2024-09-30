using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class login : Form
    {
        ClassicModels cm = new ClassicModels();
        public login()
        {
            InitializeComponent();
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

            if (cm.Authentication(username.Text.Trim(), password.Text.Trim()))
            {
                Form main = new main();
                main.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
