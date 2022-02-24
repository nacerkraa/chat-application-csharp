using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteChat
{
    public class EventProxy : MarshalByRefObject
    {

        #region Event Declarations

        public event MessageArrivedEvent MessageArrived;

        public event EtudaiantArrivedEvent EtudaiantArrived;

        

        #endregion

        #region Lifetime Services

        public override object InitializeLifetimeService()
        {
            return null;            //Returning null holds the object alive until it is explicitly destroyed
        }

        #endregion

        #region Local Handlers

        public void LocallyHandleMessageArrived(string Message)
        {
            if (MessageArrived != null)
                MessageArrived(Message);
        }

        public void LocallyHandleEtudiantArrived(string Message)
        {
            if (EtudaiantArrived != null)
                EtudaiantArrived(Message);
        }


        #endregion

        
    }
}
