using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public interface IModemDoesNotFollowSRP
    {
        //Communication methods

        void Dial();
        void Hangup();

        //Connection methods
        void Send();
        void Receive();

    }


    

}
