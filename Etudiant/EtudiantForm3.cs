using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IRemoteAttendance;

namespace Etudiant
{
    public partial class EtudiantForm3 : Form
    {
        connection con = new connection();
        public EtudiantForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!con.Open())
                {
                    con.Open();
                }
                string query = "insert into users(username,password,firstname,lastname,address,type)values('" + txtUser.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtAddress.Text + "','etudiant')";
                con.Execute(query);
                txtUser.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                MessageBox.Show("Successfully Added", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Connection Error", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
