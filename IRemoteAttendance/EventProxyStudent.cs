using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteAttendance
{
    public class EventProxyStudent : MarshalByRefObject
    {
        
        public event EtudiantnArrivedEvent EtudaiantArrived;

        public override object InitializeLifetimeService()
        {
            return null;            //Returning null holds the object alive until it is explicitly destroyed
        }


       


        
    }
}
