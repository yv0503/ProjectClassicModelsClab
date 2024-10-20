using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassicModels
{
    class ClassicModels
    {

        private MySqlConnection myConn = null;
        private MySqlCommand myCommand = new MySqlCommand();
        private MySqlDataAdapter mydataAdapter = new MySqlDataAdapter();
        private DataTable dt = new DataTable();
        private MySqlDataReader MySqlDataReader = null;

        private string connstring = @"server=localhost;userid=root;password=Cake!070503;database=classicmodels";


        public bool Authentication1(string username, string password)
        {
            try
            {
                using (myConn = new MySqlConnection(connstring))
                {
                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT count(*) AS Record FROM login WHERE username=@username AND password=@password";

                        using (MySqlCommand cmd = new MySqlCommand(query, myConn))
                        {

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);


                            int recordCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (recordCount > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error message is: " + e.Message);
            }

            return false;
        }

        public bool Authentication(string username, string password)
        {
            try
            {

                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();

                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = String.Format("SELECT count(*) AS Record FROM login " +
                                             "WHERE username='{0}' AND password='{1}'", username, password);

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);
                        DataSet ds = new DataSet();

                        da.Fill(ds, "login");
                        dt = ds.Tables["login"];

                        int recordCount = Convert.ToInt32(dt.Rows[0]["Record"]);

                        if (recordCount > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error message is: " + e.Message);
            }

            return false;
        }



        public void SelectCustomers(DataGridView dgCustomers)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT customerNumber AS 'Customer Number', customerName AS 'Customer Name', " +
                            "country AS Country, state, contactLastName, contactFirstName, Phone, addressLine1, " +
                            "addressLine2, postalCode, salesRepEmployeeNumber ,creditLimit, city FROM customers";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "customers");
                        dt = ds.Tables["customers"];



                        dgCustomers.DataSource = dt;
                        dgCustomers.Columns[0].Width = 200;
                        dgCustomers.Columns[1].Width = 450;
                        dgCustomers.Columns[2].Width = 200;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
            //totalRows = dt.Rows.Count - 1;
            //EnabledCustomerForm("000000");
            //ClearForms();
            //EnabledButton("1000001");
            //EnabledNavButtons("1110");
        }

        public void BindCustomerCountry(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct country AS Country FROM customers ORDER BY Country ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "Country";
                        cb.ValueMember = "Country";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindCustomerState(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct state AS State FROM customers WHERE country = '"+cmbcountry.Text+"' ORDER BY State ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "State";
                        cb.ValueMember = "State";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindCustomerCity(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct city AS City FROM customers WHERE country = '"+cmbcountry.Text+"' ORDER BY City ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "City";
                        cb.ValueMember = "City";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        public void BindPostalCode(ComboBox cb, ComboBox cmbcountry)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        
                        {
                            string query = "SELECT Distinct postalCode AS postalCode FROM customers WHERE country = '"+cmbcountry.Text+"' ORDER BY postalCode ASC";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "postalCode";
                            cb.ValueMember = "postalCode";
                        
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindSalesRep(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT Distinct salesRepEmployeeNumber AS salesRep FROM customers ORDER BY salesRep ASC";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        cb.DataSource = dt;
                        cb.DisplayMember = "salesRep";
                        cb.ValueMember = "salesRep";
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void NewCustNumber(ReaLTaiizor.Controls.DungeonTextBox tb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT MAX(customerNumber) +1 AS newCustomerNumber FROM customers";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        tb.Text = dt.Rows[0][0].ToString();

                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void InsertNewCustomer(ReaLTaiizor.Controls.DungeonTextBox CustNo, ReaLTaiizor.Controls.DungeonTextBox CustLstName, ReaLTaiizor.Controls.DungeonTextBox CustFrstName,
            ReaLTaiizor.Controls.DungeonTextBox ContactNo, ReaLTaiizor.Controls.DungeonTextBox AddressLine1, ReaLTaiizor.Controls.DungeonTextBox AddressLine2,
            ComboBox cmbcountry, ComboBox cmbstate, ComboBox cmbcity, ComboBox cmbpostalcode, ComboBox salesrep, ReaLTaiizor.Controls.DungeonTextBox credit, ReaLTaiizor.Controls.DungeonTextBox custName)
        {
            string a = CustNo.Text.Trim();
            string b = CustLstName.Text.Trim();
            string c = CustFrstName.Text.Trim();
            string d = ContactNo.Text.Trim();
            string e = AddressLine1.Text.Trim();
            string f = AddressLine2.Text.Trim();
            string g = cmbcountry.Text.Trim();
            string h = cmbcity.Text.Trim();
            string i = cmbpostalcode.Text.Trim();
            string j = cmbstate.Text.Trim();
            string k = salesrep.Text.Trim();
            string l = credit.Text.Trim(); 
            string m = custName.Text.Trim();

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        //string query = "INSERT INTO customers(customerNumber, customerName, contactLastName, " +
                        //    "contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)" +
                        //    "VALUES("+a+", "+m+", "+b+","+c+", "+d+","+e+", "+f+","+g+", "+h+","+i+", "+j+","+k+", "+l+")";

                        //MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO customers(customerNumber, customerName, contactLastName, " +
                            "contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)" +
                           "VALUES("+"'"+a+ "'"+", "+"'"+m+"'"+", "+"'"+b+"'"+", " + "'" + c + "'" + ", " + "'" + d + "'" + ", " + "'" + e + "'" + ", " + "'" + f + "'" 
                           + ", " + "'" + h + "'" + ", " + "'" + j + "'" + ", " + "'" + i + "'" + ", " + "'" + g + "'" + ", " + 
                           "'" + k + "'" + ", " + "'" + l + "'" + ")", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Inputted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        public void DeleteCustomer(ReaLTaiizor.Controls.DungeonTextBox CustNo)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("DELETE FROM customers WHERE customerNumber='"+CustNo.Text+"'", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Deleted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

        }

        public void UpdateCustomer(ReaLTaiizor.Controls.DungeonTextBox CustNo, ReaLTaiizor.Controls.DungeonTextBox CustLstName, ReaLTaiizor.Controls.DungeonTextBox CustFrstName,
            ReaLTaiizor.Controls.DungeonTextBox ContactNo, ReaLTaiizor.Controls.DungeonTextBox AddressLine1, ReaLTaiizor.Controls.DungeonTextBox AddressLine2,
            ComboBox cmbcountry, ComboBox cmbstate, ComboBox cmbcity, ComboBox cmbpostalcode, ComboBox salesrep, ReaLTaiizor.Controls.DungeonTextBox credit, ReaLTaiizor.Controls.DungeonTextBox custName)
        {
            string a = CustNo.Text.Trim();
            string b = CustLstName.Text.Trim();
            string c = CustFrstName.Text.Trim();
            string d = ContactNo.Text.Trim();
            string e = AddressLine1.Text.Trim();
            string f = AddressLine2.Text.Trim();
            string g = cmbcountry.Text.Trim();
            string h = cmbcity.Text.Trim();
            string i = cmbpostalcode.Text.Trim();
            string j = cmbstate.Text.Trim();
            string k = salesrep.Text.Trim();
            string l = credit.Text.Trim();
            string m = custName.Text.Trim();

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("UPDATE customers SET customerName='"+m+"', contactLastName='"+b+"'," + "contactFirstName='"+c+"', phone='"+d+"', " +
                            "addressLine1='"+e+"', addressLine2='"+f+"', city='"+h+"', state='"+j+"'," + " postalCode='"+i+"', country='"+g+"', salesRepEmployeeNumber='"+k+"', " +
                            "creditLimit='"+l+"' WHERE customerNumber="+a+"", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Updated");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        //EMPLOYEES//


        public void SelectEmployee(DataGridView dgEmployee)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT employeeNumber AS 'Employee Number', lastName AS 'Last Name', " +
                            "firstName AS 'First Name', extension as 'Extension', email as 'Email Address', officeCode as 'Office Code', reportsTo as 'Reports To', " +
                            "jobTitle as 'Job Title' FROM employees";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "employees");
                        dt = ds.Tables["employees"];



                        dgEmployee.DataSource = dt;
                        dgEmployee.Columns[0].Width = 200;
                        dgEmployee.Columns[1].Width = 200;
                        dgEmployee.Columns[2].Width = 200;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
            //totalRows = dt.Rows.Count - 1;
            //EnabledCustomerForm("000000");
            //ClearForms();
            //EnabledButton("1000001");
            //EnabledNavButtons("1110");
        }



        public void BindOfficeCode(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct officeCode AS OfficeCode FROM employees";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "OfficeCode";
                            cb.ValueMember = "OfficeCode";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindExtension(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct extension AS extension FROM employees ORDER BY extension ASC";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "extension";
                            cb.ValueMember = "extension";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindReportsTo(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct reportsTo AS reportsTo FROM employees ORDER BY reportsTo ASC";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "reportsTo";
                            cb.ValueMember = "reportsTo";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindJobTitle(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct jobTitle AS jobTitle FROM employees ORDER BY jobTitle ASC";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "jobTitle";
                            cb.ValueMember = "jobTitle";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void NewEmpNumber(ReaLTaiizor.Controls.DungeonTextBox tb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT MAX(employeeNumber) +1 AS newEmployeeNumber FROM employees";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        tb.Text = dt.Rows[0][0].ToString();

                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void UpdateEmployee(ReaLTaiizor.Controls.DungeonTextBox EmpNo, ReaLTaiizor.Controls.DungeonTextBox EmpLastName, ReaLTaiizor.Controls.DungeonTextBox EmpFirstName,
                                    ReaLTaiizor.Controls.DungeonTextBox Email, ComboBox cmbExtension, ComboBox cmbOfficeCode, ComboBox cmbReportsTo, ComboBox cmbJobTitle)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("UPDATE employees SET lastName='" + EmpLastName.Text + "', firstName='" + EmpFirstName.Text + "'," + "extension='" + cmbExtension.Text + "', email='" + Email.Text + "', " +
                            "officeCode='" + cmbOfficeCode.Text + "', reportsTo='" + cmbReportsTo.Text + "', jobTitle='" + cmbJobTitle.Text + "' WHERE employeeNumber="+EmpNo.Text+"", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Updated");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void InsertNewEmployee(ReaLTaiizor.Controls.DungeonTextBox EmpNo, ReaLTaiizor.Controls.DungeonTextBox EmpLastName, ReaLTaiizor.Controls.DungeonTextBox EmpFirstName,
                                    ReaLTaiizor.Controls.DungeonTextBox Email,ComboBox cmbExtension, ComboBox cmbOfficeCode, ComboBox cmbReportsTo, ComboBox cmbJobTitle)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        //string query = "INSERT INTO customers(customerNumber, customerName, contactLastName, " +
                        //    "contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)" +
                        //    "VALUES("+a+", "+m+", "+b+","+c+", "+d+","+e+", "+f+","+g+", "+h+","+i+", "+j+","+k+", "+l+")";

                        //MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO customers(employeeNumber, lastName, firstName, " +
                            "extension, email, officeCode, reportsTo, jobTitle) " +
                           "VALUES(" + "'" + EmpNo.Text + "'" + ", " + "'" + EmpLastName.Text + "'" + ", " + "'" + EmpFirstName.Text + "'" + ", " + "'" + cmbExtension.Text + "'" 
                           + ", " + "'" + Email.Text + "'" + ", " + "'" + cmbOfficeCode.Text + "'" + ", " + "'" + cmbReportsTo.Text + "'"
                           + ", " + "'" + cmbJobTitle.Text + ")", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Inputted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        public void DeleteEmployee(ReaLTaiizor.Controls.DungeonTextBox EmpNo)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE employeeNumber='" + EmpNo.Text + "'", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Deleted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

        }

        //Office//

        public void SelectOffice(DataGridView dgOffice)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT officeCode AS 'Office Code', city AS 'City', " +
                            "phone AS 'Phone', addressLine1 as 'Address Line 1', addressline2 as 'Address Line 2', state as 'State', " +
                            "country as 'Country', " +
                            "postalCode as 'Postal Code', territory as Territory FROM offices";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "offices");
                        dt = ds.Tables["offices"];



                        dgOffice.DataSource = dt;
                        dgOffice.Columns[0].Width = 200;
                        dgOffice.Columns[1].Width = 200;
                        dgOffice.Columns[2].Width = 200;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
            //totalRows = dt.Rows.Count - 1;
            //EnabledCustomerForm("000000");
            //ClearForms();
            //EnabledButton("1000001");
            //EnabledNavButtons("1110");
        }

        public void BindCity2(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct city AS City FROM offices";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "City";
                            cb.ValueMember = "City";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindState2(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct state AS State FROM offices";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "State";
                            cb.ValueMember = "State";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindCountry2(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct country AS Country FROM offices";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "Country";
                            cb.ValueMember = "Country";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindPostalCode2(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct postalCode AS PostalCode FROM offices";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "PostalCode";
                            cb.ValueMember = "PostalCode";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void BindTerritory(ComboBox cb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        {
                            string query = "SELECT Distinct territory AS Territory FROM offices";


                            MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                            DataSet ds = new DataSet();

                            da.Fill(ds, "0");
                            dt = ds.Tables["0"];

                            cb.DataSource = dt;
                            cb.DisplayMember = "Territory";
                            cb.ValueMember = "Territory";

                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void NewOfficeCode(ReaLTaiizor.Controls.DungeonTextBox tb)
        {
            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        string query = "SELECT MAX(officeCode) +1 AS newOfficeCode FROM offices";

                        MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        DataSet ds = new DataSet();

                        da.Fill(ds, "0");
                        dt = ds.Tables["0"];

                        tb.Text = dt.Rows[0][0].ToString();

                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void UpdateOffice(ReaLTaiizor.Controls.DungeonTextBox officeCode, ReaLTaiizor.Controls.DungeonTextBox Phone, ReaLTaiizor.Controls.DungeonTextBox addressLine1,
                                    ReaLTaiizor.Controls.DungeonTextBox addressLine2, ComboBox cmbcity, ComboBox cmbstate, ComboBox cmbcountry, ComboBox cmbpostalcode, ComboBox cmbterritory)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("UPDATE offices SET phone='" + Phone.Text + "', city='" + cmbcity.Text + "'," + "addressLine1='" + addressLine1.Text + "', addressLine2='" + addressLine2.Text + "', " +
                            "postalCode='" + cmbpostalcode.Text + "', state='" + cmbstate.Text + "', territory='" + cmbterritory.Text + "', country='"+cmbcountry+"' WHERE employeeNumber=" + officeCode.Text + "", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Updated");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }

        public void InsertNewOffice(ReaLTaiizor.Controls.DungeonTextBox officeCode, ReaLTaiizor.Controls.DungeonTextBox Phone, ReaLTaiizor.Controls.DungeonTextBox addressLine1,
                                    ReaLTaiizor.Controls.DungeonTextBox addressLine2, ComboBox cmbcity, ComboBox cmbstate, ComboBox cmbcountry, ComboBox cmbpostalcode, ComboBox cmbterritory)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {
                        //string query = "INSERT INTO customers(customerNumber, customerName, contactLastName, " +
                        //    "contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)" +
                        //    "VALUES("+a+", "+m+", "+b+","+c+", "+d+","+e+", "+f+","+g+", "+h+","+i+", "+j+","+k+", "+l+")";

                        //MySqlDataAdapter da = new MySqlDataAdapter(query, myConn);

                        MySqlCommand cmd = new MySqlCommand("INSERT INTO offices(officeCode, city, phone, " +
                            "addressLine1, addressLine2, state, country, postalCode, territory) " +
                           "VALUES(" + "'" + officeCode.Text + "'" + ", " + "'" + cmbcity.Text + "'" + ", " + "'" + Phone.Text + "'" + ", " + "'" + addressLine1.Text + "'"
                           + ", " + "'" + addressLine2.Text + "'" + ", " + "'" + cmbstate.Text + "'" + ", " + "'" + cmbcountry.Text + "'"
                           + ", " + "'" + cmbpostalcode.Text + ", " + "'" + cmbpostalcode.Text + ")", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Inputted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }
        }


        public void DeleteOffice(ReaLTaiizor.Controls.DungeonTextBox officeCode)
        {

            try
            {
                myConn = new MySqlConnection(connstring);

                if (myConn.State != ConnectionState.Open)
                {
                    myConn.Open();
                    if (myConn.State == ConnectionState.Open)
                    {

                        MySqlCommand cmd = new MySqlCommand("DELETE FROM offices WHERE officeCode='" + officeCode.Text + "'", myConn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Deleted");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error message is: " + e1.Message);
            }

        }
    }
    }

