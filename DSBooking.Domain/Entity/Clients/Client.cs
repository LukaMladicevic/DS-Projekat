using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBooking.Domain.Clients
{
    internal abstract class Client
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _passNo;
        private DateTime _date;
        private string _email;
        private string _phoneNo;

        public Client(int id,string name,string lastname, string passNo,DateTime date,string email, string phoneNo)
        {
            this._id = id;
            this._name = name;
            this._lastName = lastname;
            this._passNo = passNo;
            this._date = date;
            this._email = email;
            this._phoneNo = phoneNo;
        }


    }
}
