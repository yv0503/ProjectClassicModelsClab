using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class frmCustomers : Form
    {
        ClassicModels cm = new ClassicModels();

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {
            cm.SelectCustomers(dgCustomers);
            cm.BindCustomerCountry(cmbcountry);
            cm.BindCustomerState(cmbstate);
            cm.BindCustomerCity(cmbcity);
        }

        private void BindCustomers(int e) 
        {


            txtCustomerNumber.Text = dgCustomers.Rows[e].Cells[0].Value.ToString();
            txtlastName.Text = dgCustomers.Rows[e].Cells[5].Value.ToString();
            txtfirstName.Text = dgCustomers.Rows[e].Cells[6].Value.ToString();  
            txtcontactNumber.Text = dgCustomers.Rows[e].Cells[7].Value.ToString();
            txtaddressline.Text = dgCustomers.Rows[e].Cells[8].Value.ToString();
            txtaddressline2.Text = dgCustomers.Rows[e].Cells[9].Value.ToString();
            cmbpostalcode.Text = dgCustomers.Rows[e].Cells[10].Value.ToString();
            credit.Text = dgCustomers.Rows[e].Cells[11].Value.ToString();

            cm.BindCustomerCountry(cmbcountry);
            cm.BindCustomerState(cmbstate);
            cm.BindCustomerCity(cmbcity);

            cm.SelectedCity(cmbcity, dgCustomers.Rows[e].Cells[4].Value.ToString());
            cm.SelectedState(cmbstate, dgCustomers.Rows[e].Cells[3].Value.ToString());
            cm.SelectedCountry(cmbcountry, dgCustomers.Rows[e].Cells[2].Value.ToString());
        }


        private void newBtn_Click(object sender, EventArgs e)
        {

        }

        private void EnableControls(bool val)
        {
            foreach (Control ctrl in customerTab.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is Button)
                {
                    ctrl.Enabled = val;
                }

            }
        }

        private void dgCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerTab.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
        }



        private void customerTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monitorWidth = Screen.PrimaryScreen.Bounds.Width;

            TabPage selectedTab = customerTab.SelectedTab;

            if (customerTab.SelectedIndex == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void customerID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
