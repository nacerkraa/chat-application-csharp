using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

using IRemoteChat;
using IRemoteAttendance;

namespace Enseignant
{
    public partial class EnseignantForm1 : Form
    {

        
        
        Impl server;
        private delegate void SetBoxText(string Message);
        private delegate void SetTextInListEtud(string Message);

        private string serverURI = "tcp://localhost:8085/obj";
        IChatRoom remoteServer;

        public EnseignantForm1(string strTextBox)
        {
            InitializeComponent();
            label1.Text = "Dr." + strTextBox;
            
        }

        private void EnseignantForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            server = new Impl();
            server.StartServer(8085);

            server.MessageArrived += new IRemoteChat.MessageArrivedEvent(server_MessageArrived);
            server.EtudaiantArrived += new IRemoteChat.EtudaiantArrivedEvent(server_EtudiantArrived);

            btnConnect.Text = "Session Started";
            btnConnect.ForeColor = Color.Green;

            SetTextBox("Session Started");
            
           
        }

        void server_MessageArrived(string Message)
        {
            SetTextBox(Message);
        }

        void server_EtudiantArrived(string Message)
        {

            listDesEtudiants.Items.Add(Message);

        }

        private void bttn_StopServer_Click(object sender, EventArgs e)
        {
            remoteServer.PublishMessage("session Ended");
            server.StopServer();
            server = null;
            
        }

        private void SetTextBox(string Message)
        {
            if (listMessages.InvokeRequired)
            {
                this.BeginInvoke(new SetBoxText(SetTextBox), new object[] { Message });
                return;
            }
            else
                listMessages.Items.Add(Message + "\r\n");
        }

       


        
        

        private void btnSender_Click(object sender, EventArgs e)
        {


            remoteServer = (IChatRoom)Activator.GetObject(typeof(IChatRoom), serverURI);
            remoteServer.PublishMessage(label1.Text +": " + textMessage.Text);
            textMessage.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

       

      


    }

    
}
