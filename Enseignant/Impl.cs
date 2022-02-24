using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


using System.Collections;

using IRemoteChat;
using IRemoteAttendance;

namespace Enseignant
{
    public class Impl: MarshalByRefObject,IChatRoom,IRegistration
    {
        #region Fields

        User user = new User();

        private TcpServerChannel serverChannel;
        private int tcpPort;
        private ObjRef internalRef;
        private bool serverActive = false;
        private static string serverURI = "obj";

        private connection con = new connection();
        

        #endregion

        #region IServerObject Members

        public event MessageArrivedEvent MessageArrived;

        public void PublishMessage(string Message)
        {
            SafeInvokeMessageArrived(Message);
        }

        #endregion



        public void StartServer(int port)
        {
            if (serverActive)
                return;

            Hashtable props = new Hashtable();
            props["port"] = port;
            props["name"] = serverURI;

            //Set up for remoting events properly
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;

            serverChannel = new TcpServerChannel(props, serverProv);

            try
            {
                ChannelServices.RegisterChannel(serverChannel, false);
                internalRef = RemotingServices.Marshal(this, props["name"].ToString());
                serverActive = true;
            }
            catch (RemotingException re)
            {
                //Could not start the server because of a remoting exception
            }
            catch (Exception ex)
            {
                //Could not start the server because of some other exception
            }
        }

        public void StopServer()
        {
            if (!serverActive)
                return;

            RemotingServices.Unmarshal(internalRef);

            try
            {
                ChannelServices.UnregisterChannel(serverChannel);
            }
            catch (Exception ex)
            {

            }
        }

        private void SafeInvokeMessageArrived(string Message)
        {
            if (!serverActive)
                return;

            if (MessageArrived == null)
                return;         //No Listeners

            MessageArrivedEvent listener = null;
            Delegate[] dels = MessageArrived.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (MessageArrivedEvent) del;
                    listener.Invoke(Message);
                }
                catch (Exception ex)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    MessageArrived -= listener;
                }
            }
        }



        public void CheakStudent(string userN, string pass)
        {
            throw new NotImplementedException();
        }

        public void CheakTeacher(int user, string pass)
        {
            throw new NotImplementedException();
        }




        

        // Etudiant
        int i = 1;
        public event EtudaiantArrivedEvent EtudaiantArrived;

        public void Notificaion(string Message)
        {
            SafeInvokeEtudaiantArrived(Message);
            i = i + 1;
        }

        private void SafeInvokeEtudaiantArrived(string Message)
        {
            if (!serverActive)
                return;

            if (EtudaiantArrived == null)
                return;         //No Listeners

            EtudaiantArrivedEvent listener = null;
            Delegate[] dels = EtudaiantArrived.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (EtudaiantArrivedEvent)del;
                    listener.Invoke(Message);
                }
                catch (Exception ex)
                {
                    //Could not reach the destination, so remove it
                    //from the list
                    EtudaiantArrived -= listener;
                }
            }
        }



        public void setUser(User us)
        {
            this.user = us;
        }
    }
}
