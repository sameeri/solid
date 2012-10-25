using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    interface IModemThatFollowsSRP
    {
        string ManufacturerName { get; set; }
        string BuildNumber { get; }
        string Color { get; }

        IModemCommunication Communication { get; set; }
        IModemConnection Connection { get; set; }
    }
    //SPlitting the interfaces
    public interface IModemCommunication
    {

        void Dial();
        void Hangup();
    }


    public interface IModemConnection
    {
        void Send();
        void Receive();
    }

    public class CableModem : IModemThatFollowsSRP
    {
        public string ManufacturerName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string BuildNumber
        {
            get { throw new NotImplementedException(); }
        }

        public string Color
        {
            get { throw new NotImplementedException(); }
        }

        public IModemCommunication Communication
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IModemConnection Connection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }

    public class DialupModem : IModemThatFollowsSRP
    {
        public string ManufacturerName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string BuildNumber
        {
            get { throw new NotImplementedException(); }
        }

        public string Color
        {
            get { throw new NotImplementedException(); }
        }

        public IModemCommunication Communication
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public IModemConnection Connection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }

    internal interface IRepo<Modem>
    {
        IModemThatFollowsSRP Get(string buildNumber);
        List<IModemThatFollowsSRP> GetAll(string manufacturerName);
        IModemThatFollowsSRP Create(IModemThatFollowsSRP modem);
        void Delete(IModemThatFollowsSRP modem);
        IModemThatFollowsSRP Update(IModemThatFollowsSRP modem);
    }
}
