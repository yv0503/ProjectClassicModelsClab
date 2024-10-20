using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    public partial class frmOffices : Form
    {

        ClassicModels cm = new ClassicModels();
        bool newOrEdit;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
               );

        public frmOffices()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmOffices_Load(object sender, EventArgs e)
        {
            cm.SelectOffice(dgOffice);
            cm.BindCity2(cmbcity);
            cm.BindState2(cmbstate);
            cm.BindCountry2(cmbcountry);
            cm.BindPostalCode2(cmbpostalcode);
            cm.BindTerritory(cmbterritory);
            FirstPrevNextLast(0);
        }

        private void EnableControls(bool val)
        {
            foreach (Control ctrl in officeTab.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is Button)
                {
                    ctrl.Enabled = val;
                }

            }

            foreach (Control ctrl in tabPage1.Controls)
            {
                ctrl.Enabled = val;
                txtOfficeCode.Enabled = false;


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


        private void FirstPrevNextLast(int e)
        {
            txtOfficeCode.Text = dgOffice.Rows[e].Cells[0].Value.ToString();
            txtAddressLine1.Text = dgOffice.Rows[e].Cells[3].Value.ToString();
            txtPhoneNumber.Text = dgOffice.Rows[e].Cells[2].Value.ToString();
            txtAddressLine2.Text = dgOffice.Rows[e].Cells[4].Value.ToString();
            cmbcity.Text = dgOffice.Rows[e].Cells[1].Value.ToString();
            cmbpostalcode.Text = dgOffice.Rows[e].Cells[7].Value.ToString();
            cmbstate.Text = dgOffice.Rows[e].Cells[5].Value.ToString();
            cmbcountry.Text = dgOffice.Rows[e].Cells[6].Value.ToString();
            cmbterritory.Text = dgOffice.Rows[e].Cells[8].Value.ToString();
        }

    private void BindOffice(int e)
    {
        txtOfficeCode.Text = dgOffice.Rows[e].Cells[0].Value.ToString();
        txtAddressLine1.Text = dgOffice.Rows[e].Cells[3].Value.ToString();
        txtPhoneNumber.Text = dgOffice.Rows[e].Cells[2].Value.ToString();
        txtAddressLine2.Text = dgOffice.Rows[e].Cells[4].Value.ToString();

        cm.BindCountry2(cmbcountry);
        cm.BindState2(cmbstate);
        cm.BindCity2(cmbcity);
        cm.BindPostalCode2(cmbpostalcode);
        cm.BindTerritory(cmbterritory);

        SelectedCity(cmbcity, dgOffice.Rows[e].Cells[1].Value.ToString());
        SelectedState(cmbstate, dgOffice.Rows[e].Cells[5].Value.ToString());
        SelectedCountry(cmbcountry, dgOffice.Rows[e].Cells[6].Value.ToString());
        SelectedPostalCode(cmbpostalcode, dgOffice.Rows[e].Cells[7].Value.ToString());
        SelectedTerritory(cmbterritory, dgOffice.Rows[e].Cells[8].Value.ToString());

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
                    string postalCode = rowView["postalCode"].ToString();

                    if (postalCode.Equals(selectedPostalCode, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedTerritory(ComboBox cb, string selectedTerritory)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string territory = rowView["territory"].ToString();

                    if (territory.Equals(selectedTerritory, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }


        public void NewOffice()
        {
            txtOfficeCode.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtPhoneNumber.Text = "";
            cmbcity.Text = "";
            cmbstate.Text = "";
            cmbcountry.Text = "";
            cmbpostalcode.Text = "";
            cmbterritory.Text = "";

            cm.NewOfficeCode(txtOfficeCode);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frstBtn_Click(object sender, EventArgs e)
        {
            FirstPrevNextLast(0);
            frstBtn.Enabled = false;
            prevBtn.Enabled = false;
            lstBtn.Enabled = true;
            nxtBtn.Enabled = true;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < dgOffice.Rows.Count; n++)
            {
                if (txtOfficeCode.Text == dgOffice.Rows[n].Cells[0].Value.ToString())
                {

                    FirstPrevNextLast(n - 1);

                    break;
                }
            }

            if (txtOfficeCode.Text == dgOffice.Rows[0].Cells[0].Value.ToString())
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
            for (int n = 0; n < dgOffice.Rows.Count; n++)
            {
                if (txtOfficeCode.Text == dgOffice.Rows[n].Cells[0].Value.ToString())
                {

                    FirstPrevNextLast(n + 1);

                    break;
                }
            }

            if (txtOfficeCode.Text == dgOffice.Rows[dgOffice.Rows.Count - 1].Cells[0].Value.ToString())
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

        private void lstBtn_Click(object sender, EventArgs e)
        {
            FirstPrevNextLast(dgOffice.Rows.Count - 1);
            lstBtn.Enabled = false;
            nxtBtn.Enabled = false;
            frstBtn.Enabled = true;
            prevBtn.Enabled = true;
        }

        private void cnfrmBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            if (newOrEdit == false)
            {
                cm.InsertNewOffice(txtOfficeCode, txtPhoneNumber, txtAddressLine1, txtAddressLine2, cmbcity, cmbstate, cmbcountry, cmbpostalcode, cmbterritory);
                cm.SelectOffice(dgOffice);
                BindOffice(dgOffice.Rows.Count - 1);
            }

            else if (newOrEdit == true)
            {
                cm.UpdateOffice(txtOfficeCode, txtPhoneNumber, txtAddressLine1, txtAddressLine2, cmbcity, cmbstate, cmbcountry, cmbpostalcode, cmbterritory);
                cm.SelectOffice(dgOffice);
                for (int n = 0; n < dgOffice.Rows.Count; n++)
                {
                    if (txtOfficeCode.Text == dgOffice.Rows[n].Cells[0].Value.ToString())
                    {
                        FirstPrevNextLast(n);
                        break;
                    }
                }
            }
        }

        private void edtBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            newOrEdit = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            dltBtn.Enabled = false;
            NewOffice();
            newOrEdit = false;
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.DeleteOffice(txtOfficeCode);
        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.SelectOffice(dgOffice);

            for (int n = 0; n < dgOffice.Rows.Count; n++)
            {
                if (dgOffice.Text == dgOffice.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n);
                    break;
                }
            }
            if (txtOfficeCode.Text == dgOffice.Rows[dgOffice.Rows.Count - 1].Cells[0].Value.ToString())
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

        private void dgOffice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            officeTab.SelectedIndex = 0;
            BindOffice(e.RowIndex);
            EnableControls(false);

            if (txtOfficeCode.Text == dgOffice.Rows[dgOffice.Rows.Count - 1].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }

            if (txtOfficeCode.Text == dgOffice.Rows[0].Cells[0].Value.ToString())
            {
                prevBtn.Enabled = false;
                frstBtn.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void officeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monitorWidth = Screen.PrimaryScreen.Bounds.Width;

            TabPage selectedTab = officeTab.SelectedTab;

            if (officeTab.SelectedIndex == 1)
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
    }
}
