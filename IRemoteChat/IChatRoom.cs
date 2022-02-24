using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteChat
{
    public interface IChatRoom
    {

        #region Events

        event MessageArrivedEvent MessageArrived;

        event EtudaiantArrivedEvent EtudaiantArrived;

        #endregion

        #region Methods

        void Notificaion(string Message);

        void PublishMessage(string Message);

        #endregion
    }
}
