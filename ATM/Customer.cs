using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public class Customer
    {
        private string Name;
        private string UserName;
        private string Address;
        private string Phone;
        private string PinCode;
        private string Acc_no;
        private decimal Balance;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string userName
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        public string pinCode
        {
            get { return PinCode; }
            set 
            {
                if (value.Length >= 6)
                {
                    PinCode = value;
                }
                else
                {
                    throw new Exception("The PinCode must be 6 digits or more.");
                }
            }
        }
        public string acc_no
        {
            get { return Acc_no; }
            set
            {
                if (value.Length >= 6)
                {
                    Acc_no = value;
                }
                else
                {
                    throw new Exception("The Account No must be 6 digits or more.");
                }
            }
        }
        public decimal balance
        {
            
            get { return Balance; }
            set
            {
                if (value >= 500)
                {
                    Balance = value;
                }
                else
                {
                    throw new Exception("Minimum balance should be 500/=");
                }
            }
        }
    }
}
