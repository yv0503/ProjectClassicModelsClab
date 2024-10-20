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
    public partial class frmEmployee : Form
    {
        ClassicModels cm = new ClassicModels();
        bool newOrEdit;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse
               );

        public frmEmployee()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cm.SelectEmployee(dgEmployees);
            cm.BindExtension(cmbExtension);
            cm.BindOfficeCode(cmbOfficeCode);
            cm.BindReportsTo(cmbReportsTo);
            cm.BindJobTitle(cmbJobTitle);
            FirstPrevNextLast(0);
        }

        private void BindEmployees(int e)
        {
            txtEmployeeNumber.Text = dgEmployees.Rows[e].Cells[0].Value.ToString();
            txtEmployeeLastName.Text = dgEmployees.Rows[e].Cells[1].Value.ToString();
            txtEmployeeFirstName.Text = dgEmployees.Rows[e].Cells[2].Value.ToString();
            txtEmployeeEmail.Text = dgEmployees.Rows[e].Cells[4].Value.ToString();

            cm.BindExtension(cmbExtension);
            cm.BindOfficeCode(cmbOfficeCode);
            cm.BindReportsTo(cmbReportsTo);
            cm.BindJobTitle(cmbJobTitle);


            SelectedExtension(cmbExtension, dgEmployees.Rows[e].Cells[3].Value.ToString());
            SelectedOfficeCode(cmbOfficeCode, dgEmployees.Rows[e].Cells[5].Value.ToString());
            SelectedreportsTo(cmbReportsTo, dgEmployees.Rows[e].Cells[6].Value.ToString());
            SelectedJobTitle(cmbJobTitle, dgEmployees.Rows[e].Cells[7].Value.ToString());

        }

        public void SelectedExtension(ComboBox cb, string selectedExtension)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string extension = rowView["extension"].ToString();

                    if (extension.Equals(selectedExtension, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedOfficeCode(ComboBox cb, string selectedOfficeCode)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string officeCode = rowView["officeCode"].ToString();

                    if (officeCode.Equals(selectedOfficeCode, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedreportsTo(ComboBox cb, string selectedReportsTo)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string reportsTo = rowView["reportsTo"].ToString();

                    if (reportsTo.Equals(selectedReportsTo, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        public void SelectedJobTitle(ComboBox cb, string selectedJobTitle)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string JobTitle = rowView["jobTitle"].ToString();

                    if (JobTitle.Equals(selectedJobTitle, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

        private void FirstPrevNextLast(int e)
        {
            txtEmployeeNumber.Text = dgEmployees.Rows[e].Cells[0].Value.ToString();
            txtEmployeeLastName.Text = dgEmployees.Rows[e].Cells[1].Value.ToString();
            txtEmployeeFirstName.Text = dgEmployees.Rows[e].Cells[2].Value.ToString();
            txtEmployeeEmail.Text = dgEmployees.Rows[e].Cells[4].Value.ToString();
            cmbExtension.Text = dgEmployees.Rows[e].Cells[3].Value.ToString();
            cmbJobTitle.Text = dgEmployees.Rows[e].Cells[7].Value.ToString();
            cmbOfficeCode.Text = dgEmployees.Rows[e].Cells[5].Value.ToString();
            cmbReportsTo.Text = dgEmployees.Rows[e].Cells[6].Value.ToString();
        }

        private void EnableControls(bool val)
        {
            foreach (Control ctrl in employeeTab.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is Button)
                {
                    ctrl.Enabled = val;
                }

            }

            foreach (Control ctrl in tabPage1.Controls)
            {
                ctrl.Enabled = val;
                txtEmployeeNumber.Enabled = false;


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

        private void tbpageEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcustName_TextChanged(object sender, EventArgs e)
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
            for (int n = 0; n < dgEmployees.Rows.Count; n++)
            {
                if (txtEmployeeNumber.Text == dgEmployees.Rows[n].Cells[0].Value.ToString())
                {

                    FirstPrevNextLast(n - 1);

                    break;
                }
            }

            if (txtEmployeeNumber.Text == dgEmployees.Rows[0].Cells[0].Value.ToString())
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
            for (int n = 0; n < dgEmployees.Rows.Count; n++)
            {
                if (txtEmployeeNumber.Text == dgEmployees.Rows[n].Cells[0].Value.ToString())
                {

                    FirstPrevNextLast(n + 1);

                    break;
                }
            }

            if (txtEmployeeNumber.Text == dgEmployees.Rows[dgEmployees.Rows.Count - 1].Cells[0].Value.ToString())
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

        public void NewEmployee()
        {
            txtEmployeeNumber.Text = "";
            txtEmployeeLastName.Text = "";
            txtEmployeeFirstName.Text = "";
            txtEmployeeEmail.Text = "";
            cmbExtension.Text = "";
            cmbJobTitle.Text = "";
            cmbOfficeCode.Text = "";
            cmbReportsTo.Text = "";

            cm.NewEmpNumber(txtEmployeeNumber);
        }

        private void lstBtn_Click(object sender, EventArgs e)
        {
            FirstPrevNextLast(dgEmployees.Rows.Count - 1);
            lstBtn.Enabled = false;
            nxtBtn.Enabled = false;
            frstBtn.Enabled = true;
            prevBtn.Enabled = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            dltBtn.Enabled = false;
            NewEmployee();
            newOrEdit = false;
        }

        private void edtBtn_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            newOrEdit = true;
        }

        private void cnfrmBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);

            if (newOrEdit == false)
            {
                cm.InsertNewEmployee(txtEmployeeNumber, txtEmployeeLastName, txtEmployeeFirstName, txtEmployeeEmail, cmbExtension, cmbOfficeCode, cmbReportsTo, cmbJobTitle);
                cm.SelectEmployee(dgEmployees);
                BindEmployees(dgEmployees.Rows.Count - 1);
            }

            else if (newOrEdit == true)
            {
                cm.UpdateEmployee(txtEmployeeNumber, txtEmployeeLastName, txtEmployeeFirstName, txtEmployeeEmail, cmbExtension, cmbOfficeCode, cmbReportsTo, cmbJobTitle);
                cm.SelectEmployee(dgEmployees);
                for (int n = 0; n < dgEmployees.Rows.Count; n++)
                {
                    if (txtEmployeeNumber.Text == dgEmployees.Rows[n].Cells[0].Value.ToString())
                    {
                        FirstPrevNextLast(n);
                        break;
                    }
                }
            }
        }

        private void cnlBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.SelectEmployee(dgEmployees);

            for (int n = 0; n < dgEmployees.Rows.Count; n++)
            {
                if (txtEmployeeNumber.Text == dgEmployees.Rows[n].Cells[0].Value.ToString())
                {
                    FirstPrevNextLast(n);
                    break;
                }
            }
            if (txtEmployeeNumber.Text == dgEmployees.Rows[dgEmployees.Rows.Count - 1].Cells[0].Value.ToString())
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
    

        private void dltBtn_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            cm.DeleteEmployee(txtEmployeeNumber);
        }

        private void dgEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeTab.SelectedIndex = 0;
            BindEmployees(e.RowIndex);
            EnableControls(false);
        }

        private void dgEmployees_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            employeeTab.SelectedIndex = 0;
            BindEmployees(e.RowIndex);
            EnableControls(false);

            if (txtEmployeeNumber.Text == dgEmployees.Rows[dgEmployees.Rows.Count - 1].Cells[0].Value.ToString())
            {
                lstBtn.Enabled = false;
                nxtBtn.Enabled = false;
            }

            if (txtEmployeeNumber.Text == dgEmployees.Rows[0].Cells[0].Value.ToString())
            {
                prevBtn.Enabled = false;
                frstBtn.Enabled = false;
            }
        }

        private void employeeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monitorWidth = Screen.PrimaryScreen.Bounds.Width;

            TabPage selectedTab = employeeTab.SelectedTab;

            if (employeeTab.SelectedIndex == 1)
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
