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

namespace Etudiant
{
    public partial class EtudiantForm2 : Form
    {
       
        connection con = new connection();
        public string id, username, password, firstname, lastname, address,numAbs;
        public EtudiantForm2()
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
                    string query = "select id,username,password,firstname,lastname,address,num_abs from users WHERE username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "' AND type = 'etudiant'";
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
                            numAbs = row["num_abs"].ToString();
                        }


                        


                        // application
                        
                        if (con.Open()) { con.Close(); }

                        EtudiantForm1 login;
                        if (Convert.ToInt32(numAbs) > 3)
                        {
                            login = new EtudiantForm1(firstname + " " + lastname , "(exclu)");

                        }
                        else
                        {
                            login = new EtudiantForm1(firstname + " " + lastname,"");
                        }

                        login.ShowDialog();
                        this.Close();

                        


                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

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

        private void EtudiantForm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtudiantForm3 register = new EtudiantForm3();
            register.ShowDialog();
            this.Close();
        }
     }
}

