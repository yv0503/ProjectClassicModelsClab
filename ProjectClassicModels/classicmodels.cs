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

        private string connstring = @"server=localhost;userid=root;password=123456;database=classicmodels";


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
                        string query = "SELECT Distinct state AS State FROM customers ORDER BY State ASC";

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
                        string query = "SELECT Distinct city AS City FROM customers ORDER BY City ASC";

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
                        string query = "SELECT Distinct postalCode AS postalCode FROM customers ORDER BY postalCode ASC";

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

        public void NewCustNumber(TextBox tb)
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

        public void InsertNewCustomer(TextBox CustNo, TextBox CustLstName, TextBox CustFrstName, TextBox ContactNo, TextBox AddressLine1, TextBox AddressLine2,
            ComboBox cmbcountry, ComboBox cmbstate, ComboBox cmbcity, ComboBox cmbpostalcode, ComboBox salesrep, TextBox credit, TextBox custName)
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


        public void DeleteCustomer(TextBox CustNo)
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

        public void UpdateCustomer(TextBox CustNo, TextBox CustLstName, TextBox CustFrstName, TextBox ContactNo, TextBox AddressLine1, TextBox AddressLine2,
            ComboBox cmbcountry, ComboBox cmbstate, ComboBox cmbcity, ComboBox cmbpostalcode, ComboBox salesrep, TextBox credit, TextBox custName)
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

                        MySqlCommand cmd = new MySqlCommand("UPDATE customers SET customerName='"+m+"', contactLastName='"+b+"'," + "contactFirstName='"+c+"', phone='"+d+"', addressLine1='"+e+"', addressLine2='"+f+"', city='"+h+"', state='"+j+"'," + " postalCode='"+i+"', country='"+g+"', salesRepEmployeeNumber='"+k+"', creditLimit='"+l+"' WHERE customerNumber="+a+"", myConn);

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
    }
    }

