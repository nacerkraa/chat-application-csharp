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

using MySql.Data.MySqlClient;

using System.Collections;

using IRemoteChat;
using IRemoteAttendance;

namespace Etudiant
{
    public partial class EtudiantForm1 : Form
    {
        User user;
        string situiation;
        IRegistration remoteServerRegistration;
        IChatRoom remoteServer;

        EventProxy eventProxy;
        TcpChannel tcpChan;
        BinaryClientFormatterSinkProvider clientProv;
        BinaryServerFormatterSinkProvider serverProv;
        private string serverURI = "tcp://localhost:8085/obj";        //Replace with your IP
        private bool connected = false;

        private delegate void SetBoxText(string Message);

        connection con = new connection();
        
        public EtudiantForm1(string strTextBox,string st)
        {

            InitializeComponent();
            label1.Text = strTextBox;
            situiation = st;
            
            clientProv = new BinaryClientFormatterSinkProvider();
            serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;

            eventProxy = new EventProxy();
            eventProxy.MessageArrived += new MessageArrivedEvent(eventProxy_MessageArrived);

            Hashtable props = new Hashtable();
            props["name"] = "obj";
            props["port"] = 8095;    //First available port

            tcpChan = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(tcpChan, false);

            RemotingConfiguration.RegisterWellKnownClientType(new WellKnownClientTypeEntry(typeof(IChatRoom), serverURI));
           
            
        }

        private void EtudiantForm_Load(object sender, EventArgs e)
        {
            
        }

        void eventProxy_MessageArrived(string Message)
        {
            SetTextBox(Message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            

            btnJoin.Text = "Joined";
            btnJoin.ForeColor = Color.Green;
            if (connected)
                return;

            try
            {
                
                remoteServer = (IChatRoom)Activator.GetObject(typeof(IChatRoom), serverURI);
                remoteServerRegistration = (IRegistration)Activator.GetObject(typeof(IRegistration), serverURI);
                remoteServer.PublishMessage(label1.Text + ": Connected");
                remoteServer.Notificaion(label1.Text+situiation);

                
                //This is where it will break if we didn't connect
                //remoteServerRegistration.NotifierEnsegenant(2);
                //Now we have to attach the events...
                remoteServer.MessageArrived += new MessageArrivedEvent(eventProxy.LocallyHandleMessageArrived);
                connected = true;
            }

            catch (Exception ex)
            {
                connected = false;
                SetTextBox("Could not connect: " + ex.Message);
            }

            
        }

        private void btnSender_Click(object sender, EventArgs e)
        {

            if (!connected)
                return;

            remoteServer.PublishMessage(label1.Text +": "+ txtMessege.Text);
            txtMessege.Text = "";

        }

        

        private void bttn_Disconnect_Click(object sender, EventArgs e)
        {
            if (!connected)
                return;

            remoteServer.PublishMessage(label1.Text + "Discounect");
            //First remove the event
            remoteServer.MessageArrived -= eventProxy.LocallyHandleMessageArrived;

            //Now we can close it out
            ChannelServices.UnregisterChannel(tcpChan);
        }

        private void SetTextBox(string Message)
        {
            

                if (listMesseges.InvokeRequired)
                {
                    this.BeginInvoke(new SetBoxText(SetTextBox), new object[] { Message });
                    return;
                }
                else
                    listMesseges.Items.Add(Message + "\r\n");

            
        }

        

       
    }
}
