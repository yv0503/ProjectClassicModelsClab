using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class frmCustomers : Form
    {
        ClassicModels cm = new ClassicModels();
        bool newOrEdit;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
               );

        public frmCustomers()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        { 
            cm.SelectCustomers(dgCustomers);
            FirstPrevNextLast(0);
            cm.BindCustomerCountry(cmbcountry);
            FirstPrevNextLast(0);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            cm.BindPostalCode(cmbpostalcode, cmbcountry);
            cm.BindSalesRep(salesRep);
            FirstPrevNextLast(0);
        }

        private void BindCustomers(int e)
        {
            txtCustomerNumber.Text = dgCustomers.Rows[e].Cells[0].Value.ToString();
            txtcustName.Text = dgCustomers.Rows[e].Cells[1].Value.ToString();
            txtlastName.Text = dgCustomers.Rows[e].Cells[4].Value.ToString();
            txtfirstName.Text = dgCustomers.Rows[e].Cells[5].Value.ToString();
            txtcontactNumber.Text = dgCustomers.Rows[e].Cells[6].Value.ToString();
            txtaddressline.Text = dgCustomers.Rows[e].Cells[7].Value.ToString();
            txtaddressline2.Text = dgCustomers.Rows[e].Cells[8].Value.ToString();
            salesRep.Text = dgCustomers.Rows[e].Cells[10].Value.ToString();
            credit.Text = dgCustomers.Rows[e].Cells[11].Value.ToString();


            cm.BindCustomerCountry(cmbcountry);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            cm.BindPostalCode(cmbpostalcode, cmbcountry);

            SelectedCity(cmbcity, dgCustomers.Rows[e].Cells[12].Value.ToString());
            SelectedState(cmbstate, dgCustomers.Rows[e].Cells[3].Value.ToString());
            SelectedCountry(cmbcountry, dgCustomers.Rows[e].Cells[2].Value.ToString());
            SelectedPostalCode(cmbpostalcode, dgCustomers.Rows[e].Cells[9].Value.ToString());

        }

        private void FirstPrevNextLast(int e)
        {
            txtCustomerNumber.Text = dgCustomers.Rows[e].Cells[0].Value.ToString();
            txtcustName.Text = dgCustomers.Rows[e].Cells[1].Value.ToString();
            txtlastName.Text = dgCustomers.Rows[e].Cells[4].Value.ToString();
            txtfirstName.Text = dgCustomers.Rows[e].Cells[5].Value.ToString();
            txtcontactNumber.Text = dgCustomers.Rows[e].Cells[6].Value.ToString();
            txtaddressline.Text = dgCustomers.Rows[e].Cells[7].Value.ToString();
            txtaddressline2.Text = dgCustomers.Rows[e].Cells[8].Value.ToString();
            salesRep.Text = dgCustomers.Rows[e].Cells[10].Value.ToString();
            credit.Text = dgCustomers.Rows[e].Cells[11].Value.ToString();
            cmbcity.Text = dgCustomers.Rows[e].Cells[12].Value.ToString();
            cmbstate.Text = dgCustomers.Rows[e].Cells[3].Value.ToString();
            cmbcountry.Text = dgCustomers.Rows[e].Cells[2].Value.ToString();
            cmbpostalcode.Text = dgCustomers.Rows[e].Cells[9].Value.ToString();
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

            foreach (Control ctrl in tabPage1.Controls)
            {
                ctrl.Enabled = val;
                txtCustomerNumber.Enabled = false;


                if (val == true)
                {
                    newBtn.Enabled = false;
                    edtBtn.Enabled = false;
                    prevBtn.Enabled = false;
                    nxtBtn.Enabled = false;
                    lstBtn.Enabled = false;
                    frstBtn.Enabled = false;
                }
                if (val == false) 
                {
                    prevBtn.Enabled = true;
                    nxtBtn.Enabled = true;
                    lstBtn.Enabled = true;
                    frstBtn.Enabled = true;
                    newBtn.Enabled = true;
                    edtBtn.Enabled = true;
                }
            }
        }

        private void dgCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerTab.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
            EnableControls(false);
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


        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void SelectedCity(ComboBox cb, string selectedCity)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string city = rowView["City"].ToString();

                    if (city.Equals(selectedCity, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedState(ComboBox cb, string selectedState)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string state = rowView["State"].ToString();

                    if (state.Equals(selectedState, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedCountry(ComboBox cb, string selectedCountry)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string country = rowView["Country"].ToString();

                    if (country.Equals(selectedCountry, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedPostalCode(ComboBox cb, string selectedPostalCode)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string country = rowView["postalCode"].ToString();

                    if (country.Equals(selectedPostalCode, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }


        public void NewCustomers()
        {
            txtCustomerNumber.Text = "";
            txtcustName.Text = "";
            txtlastName.Text = "";
            txtfirstName.Text = "";
            txtcontactNumber.Text = "";
            txtaddressline.Text = "";
            txtaddressline2.Text = "";
            salesRep.Text = "";
            credit.Text = "";
            cmbcity.Text = "";
            cmbstate.Text = "";
            cmbcountry.Text = "";
            cmbpostalcode.Text = "";

            cm.NewCustNumber(txtCustomerNumber);
        }


        private void edtBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            newOrEdit = true;
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.DeleteCustomer(txtCustomerNumber);
            cm.SelectCustomers(dgCustomers);
            cm.BindCustomerCountry(cmbcountry);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            BindCustomers(1);
        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            dltBtn.Enabled = false;
            NewCustomers();
            newOrEdit = false;
        }

        private void cnfrmBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            if (newOrEdit == false)
            {
                cm.InsertNewCustomer(txtCustomerNumber, txtlastName, txtfirstName, txtcontactNumber, txtaddressline, txtaddressline2, cmbcountry, cmbstate, cmbcity
                    , cmbpostalcode, salesRep, credit, txtcustName);
                cm.SelectCustomers(dgCustomers);
                BindCustomers(dgCustomers.Rows.Count - 2);
            }

            else if (newOrEdit == true)
            {
                cm.UpdateCustomer(txtCustomerNumber, txtlastName, txtfirstName, txtcontactNumber, txtaddressline, txtaddressline2, cmbcountry, cmbstate, cmbcity
                    , cmbpostalcode, salesRep, credit, txtcustName);
                cm.SelectCustomers(dgCustomers);
                for (int n = 0; n < dgCustomers.Rows.Count; n++)
                {
                    if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                    {
                        FirstPrevNextLast(n);
                        break;
                    }
                }
            }

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < dgCustomers.Rows.Count; n++)
            {
                if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n-1);
                    break;
                }
            }

            if (txtCustomerNumber.Text == dgCustomers.Rows[0].Cells[0].Value.ToString())
            {
                prevBtn.Enabled = false;
                frstBtn.Enabled = false;
            }
            else 
            {
                lstBtn.Enabled = true;
                nxtBtn.Enabled = true;
                frstBtn.Enabled = true;
                prevBtn.Enabled = true;
            }
            
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < dgCustomers.Rows.Count; n++)
            {
                if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n + 1);
                    break;
                }
            }
            if (txtCustomerNumber.Text == dgCustomers.Rows[dgCustomers.Rows.Count - 2].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }
            else {

                lstBtn.Enabled = true;
                nxtBtn.Enabled = true;
                frstBtn.Enabled = true;
                prevBtn.Enabled = true;
            }
        }

        private void frstBtn_Click(object sender, EventArgs e)
        {
            FirstPrevNextLast(0);
            frstBtn.Enabled = false;
            prevBtn.Enabled = false;
            lstBtn.Enabled = true;
            nxtBtn.Enabled = true;
        }

        private void lstBtn_Click(object sender, EventArgs e)
        {
            FirstPrevNextLast(dgCustomers.Rows.Count - 2);
            lstBtn.Enabled = false;
            nxtBtn.Enabled = false;
            frstBtn.Enabled = true;
            prevBtn.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbpostalcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void txtCustomerNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frstBtn_Click_1(object sender, EventArgs e)
        {

            FirstPrevNextLast(0);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            cm.BindPostalCode(cmbpostalcode, cmbcountry);
            FirstPrevNextLast(0);
            frstBtn.Enabled = false;
            prevBtn.Enabled = false;
            lstBtn.Enabled = true;
            nxtBtn.Enabled = true;
        }

        private void prevBtn_Click_1(object sender, EventArgs e)
        {
            for (int n = 0; n < dgCustomers.Rows.Count; n++)
            {
                if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                {

                    FirstPrevNextLast(n - 1);
                    cm.BindCustomerState(cmbstate, cmbcountry);
                    cm.BindCustomerCity(cmbcity, cmbcountry);
                    cm.BindPostalCode(cmbpostalcode, cmbcountry);
                    FirstPrevNextLast(n - 1);
                    break;
                }
            }

            if (txtCustomerNumber.Text == dgCustomers.Rows[0].Cells[0].Value.ToString())
            {
                prevBtn.Enabled = false;
                frstBtn.Enabled = false;
            }
            else
            {
                lstBtn.Enabled = true;
                nxtBtn.Enabled = true;
                frstBtn.Enabled = true;
                prevBtn.Enabled = true;
            }

        }

        private void nxtBtn_Click_1(object sender, EventArgs e)
        {


            for (int n = 0; n < dgCustomers.Rows.Count; n++)
            {
                if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n + 1);
                    cm.BindCustomerState(cmbstate, cmbcountry);
                    cm.BindCustomerCity(cmbcity, cmbcountry);
                    cm.BindPostalCode(cmbpostalcode, cmbcountry);
                    FirstPrevNextLast(n + 1);
                    break;
                }
            }
            if (txtCustomerNumber.Text == dgCustomers.Rows[dgCustomers.Rows.Count - 1].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }
            else
            {

                lstBtn.Enabled = true;
                nxtBtn.Enabled = true;
                frstBtn.Enabled = true;
                prevBtn.Enabled = true;
            } 
       
        }

        private void lstBtn_Click_1(object sender, EventArgs e)
        {
            
            FirstPrevNextLast(dgCustomers.Rows.Count - 1);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            cm.BindPostalCode(cmbpostalcode, cmbcountry);
            FirstPrevNextLast(dgCustomers.Rows.Count - 1);
            lstBtn.Enabled = false;
            nxtBtn.Enabled = false;
            frstBtn.Enabled = true;
            prevBtn.Enabled = true;

        }

        private void newBtn_Click_1(object sender, EventArgs e)
        {
            EnableControls(true);
            dltBtn.Enabled = false;
            NewCustomers();
            newOrEdit = false;
        }

        private void dltBtn_Click_1(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.DeleteCustomer(txtCustomerNumber);
            cm.SelectCustomers(dgCustomers);
            cm.BindCustomerCountry(cmbcountry);
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            BindCustomers(1);
        }

        private void edtBtn_Click_1(object sender, EventArgs e)
        {
            EnableControls(true);
            newOrEdit = true;
        }

        private void cnlBtn_Click_1(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.SelectCustomers(dgCustomers);
            
            for (int n = 0; n < dgCustomers.Rows.Count; n++)
            {
                if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n);
                    cm.BindCustomerState(cmbstate, cmbcountry);
                    cm.BindCustomerCity(cmbcity, cmbcountry);
                    cm.BindPostalCode(cmbpostalcode, cmbcountry);
                    FirstPrevNextLast(n);
                    cmbcountry.Enabled = false;
                    cmbcity.Enabled = false;
                    cmbstate.Enabled = false;
                    cmbpostalcode.Enabled = false;
                    break;
                }
            }
            if (txtCustomerNumber.Text == dgCustomers.Rows[dgCustomers.Rows.Count - 1].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }
            else
            {

                lstBtn.Enabled = true;
                nxtBtn.Enabled = true;
                frstBtn.Enabled = true;
                prevBtn.Enabled = true;
            }

        }



        private void cnfrmBtn_Click_1(object sender, EventArgs e)
        {
            EnableControls(false);

            if (newOrEdit == false)
            {
                cm.InsertNewCustomer(txtCustomerNumber, txtlastName, txtfirstName, txtcontactNumber, txtaddressline, txtaddressline2, cmbcountry, cmbstate, cmbcity
                    , cmbpostalcode, salesRep, credit, txtcustName);
                cm.SelectCustomers(dgCustomers);
                BindCustomers(dgCustomers.Rows.Count - 2);
            }

            else if (newOrEdit == true)
            {
                cm.UpdateCustomer(txtCustomerNumber, txtlastName, txtfirstName, txtcontactNumber, txtaddressline, txtaddressline2, cmbcountry, cmbstate, cmbcity
                    , cmbpostalcode, salesRep, credit, txtcustName);
                cm.SelectCustomers(dgCustomers);
                for (int n = 0; n < dgCustomers.Rows.Count; n++)
                {
                    if (txtCustomerNumber.Text == dgCustomers.Rows[n].Cells[0].Value.ToString())
                    {
                        FirstPrevNextLast(n);
                        break;
                    }
                }
            }
        }

        private void dgCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomers_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            customerTab.SelectedIndex = 0;
            BindCustomers(e.RowIndex);
            EnableControls(false);

            if (txtCustomerNumber.Text == dgCustomers.Rows[dgCustomers.Rows.Count - 1].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }

            if (txtCustomerNumber.Text == dgCustomers.Rows[0].Cells[0].Value.ToString())
            {
                prevBtn.Enabled = false;
                frstBtn.Enabled = false;
            }
        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void customerTab_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int monitorWidth = Screen.PrimaryScreen.Bounds.Width;

            TabPage selectedTab = customerTab.SelectedTab;

            if (customerTab.SelectedIndex == 1)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbcity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void cmbpostalcode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void cmbcountry_Click(object sender, EventArgs e)
        {
        }

        private void cmbpostalcode_Click(object sender, EventArgs e)
        {
        }

        private void cmbcountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cm.BindCustomerState(cmbstate, cmbcountry);
            cm.BindCustomerCity(cmbcity, cmbcountry);
            cm.BindPostalCode(cmbpostalcode, cmbcountry);
        }
    }

}
