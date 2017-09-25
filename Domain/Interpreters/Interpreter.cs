using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InterpreterBookingSystem.Domain.Interpreters
{
    /// <summary>
    /// Interpreter Class in Domain Layer
    /// </summary>
    [Serializable]
    public class Interpreter
    {
        private string name = null;
        private string address1 = null;
        private string address2 = null;
        private string city = null;
        private string state = null;
        private string zip = null;
        private string phone = null;
        private string email = null;
        private int yearsOfExperience = 0;
        private string highestLevelCertification = null;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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

        public int YearsOfExperience
        {
            get
            {
                return yearsOfExperience;
            }
            set
            {
                yearsOfExperience = value;
            }
        }

        public string HighestLevelCertification
        {
            get
            {
                return highestLevelCertification;
            }
            set
            {
                highestLevelCertification = value;
            }
        }

        public bool ValidateInterpreter()
        {
            if (Name == null) return false;
            if (Address1 == null) return false;
            if (Address2 == null) return false;
            if (City == null) return false;
            if (State == null) return false;
            if (Zip == null) return false;
            if (Zip.ToString().Length != 5) return false;
            if (Phone == null) return false;
            if (Email == null) return false;
            if (YearsOfExperience <=0 ) return false;
            if (HighestLevelCertification == null) return false;
            return true;
        }
    }
}
