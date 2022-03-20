using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IRemoteAttendance
{
    public interface IRegistration
    {
        /* .... the new methodes ... */
        void setUser(User user);
        void CheakStudent(string userN,string pass);
        void CheakTeacher(int user,string pass);

       

    }
}
