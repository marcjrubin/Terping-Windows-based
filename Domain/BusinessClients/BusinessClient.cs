using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InterpreterBookingSystem.Domain.BusinessClients
{
    /// <summary>
    /// BusinessClient class in Domain Layer 
    /// </summary>
    [Serializable]
    public class BusinessClient
    {
        // private data members required for unit testing purposes 
        private string companyName = null;
        private string pointOfContact = null;
        private string address1 = null;
        private string address2 = null;
        private string city = null;
        private string state = null;
        private string zip = null; 
        private string phone = null;
        private string email = null;

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        public string PointOfContact
        {
            get
            {
                return pointOfContact;
            }
            set
            {
                pointOfContact = value;
            }
        }

        public string Address1
        {
            get
            {
                return address1;
            }
            set
            {
                address1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public bool ValidateBusinessClient()
        {
            if (CompanyName == null) return false;
            if (PointOfContact == null) return false;
            if (Address1 == null) return false;
            if (Address2 == null) return false;
            if (City == null) return false;
            if (State == null) return false;
            if (Zip == null) return false;
            if (Zip.ToString().Length != 5) return false;
            if (Phone == null) return false;
            if (Email == null) return false;
            return true;
        }
    }
}
