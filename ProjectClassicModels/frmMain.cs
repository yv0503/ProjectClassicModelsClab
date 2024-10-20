using Google.Protobuf.WellKnownTypes;
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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void custTab_Click(object sender, EventArgs e)
        {
            Form childForm1 = new frmCustomers();
            childForm1.MdiParent = this;
            childForm1.Show();
        }

        private void empTab_Click(object sender, EventArgs e)
        {
            Form childForm2 = new frmEmployee();
            childForm2.MdiParent = this;
            childForm2.Show();
        }

        private void offTab_Click(object sender, EventArgs e)
        {
            Form childForm3 = new frmOffices();
            childForm3.MdiParent = this;
            childForm3.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
