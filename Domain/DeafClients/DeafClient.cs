using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace InterpreterBookingSystem.Domain.DeafClients
{
    /// <summary>
    /// DeafClient Class in Domain Layer
    /// </summary>
    [Serializable]
    public class DeafClient
    {
        private string name = null;
        private string gender = null;
        private string signingPreference = null;
        private List<string> listOfInterpreterPreference = null; 

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

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string SigningPreference
        {
            get
            {
                return signingPreference;
            }
            set
            {
                signingPreference = value;
            }
        }

        public List<string> ListOFInterpreterPreference
        {
            get
            {
                return listOfInterpreterPreference;
            }
            set
            {
                listOfInterpreterPreference = value;
            }
        }

        public bool ValidateDeafClient()
        {
            if (Name == null) return false;
            if (Gender == null) return false;
            if (SigningPreference == null) return false;
            if (ListOFInterpreterPreference.Count == 0) return false;
            return true;
        }
    }
}
