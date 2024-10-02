using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                            "addressLine2, postalCode, salesRepEmployeeNumber ,creditLimit FROM customers";

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

        public void BindCustomerState(ComboBox cb)
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

        public void BindCustomerCity(ComboBox cb)
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

        public void SelectedCity(ComboBox cb, string selectedCity) {
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

        public void SelectedPostalCode(ComboBox cb, string selectedCountry)
        {
            for (int index = 0; index < cb.Items.Count; index++)
            {
                DataRowView rowView = cb.Items[index] as DataRowView;

                if (rowView != null)
                {
                    string PostalCode = rowView["postalCode"].ToString();

                    if (PostalCode.Equals(SelectedPostalCode, StringComparison.OrdinalIgnoreCase))
                    {
                        cb.SelectedIndex = index;
                        break;
                    }
                }

            }
        }

    }
}
