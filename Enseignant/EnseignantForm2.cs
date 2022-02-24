using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using IRemoteAttendance;


namespace Enseignant
{
    public partial class EnseignantForm2 : Form
    {
        
        
        connection con = new connection();
        string id, username, password, firstname, lastname, address;
        public EnseignantForm2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {

                    if (!con.Open())
                    {
                        con.Open();
                    }
                    string query = "select id,username,password,firstname,lastname,address from users WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "' AND type='enseignant'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            firstname = row["firstname"].ToString();
                            lastname = row["lastname"].ToString();
                            address = row["address"].ToString();
                        }

                        



                        // application
                        
                        if (con.Open()) { con.Close(); }
                        EnseignantForm1 login = new EnseignantForm1(firstname + " " + lastname);
                        login.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}
