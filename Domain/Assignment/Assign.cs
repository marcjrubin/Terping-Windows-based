using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Domain.Interpreters;
using InterpreterBookingSystem.Domain.DeafClients;
using System.Runtime.Serialization;

namespace InterpreterBookingSystem.Domain.Assignment
{
    /// <summary>
    /// Assign Class for the Assignment in Domain Layer 
    /// </summary>
    [Serializable]
    public class Assign
    {
        // private data members required for unit testing purposes
        private string startDate = null;
        private string endDate = null;
        private string startTime = null;
        private string endTime = null;

        public string StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public string EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }

        public bool ValidateAssignment()
        {
            if (StartDate == null) return false;
            if (EndDate == null) return false;
            if (StartTime == null) return false;
            if (EndTime == null) return false;
            return true;
        }

        IDictionary businessClient = new Hashtable();
        IDictionary interpreter = new Hashtable();
        IDictionary deafClient = new Hashtable();

        /// <summary>
        /// Add BusinessClient to the associating Assignment
        /// </summary>
        /// <param name="bc"></param>
        public void AddBusinessClient(BusinessClient bc)
        {
            // note: the .Type method does not exist for some reason and couldn't find a 
            // work around to it because I don't want to change to IList interface 
            // same goes for the rest of methods below 
            businessClient.Add(bc, bc);
        }

        public void RemoveBusinessClient(BusinessClient bc)
        {
            businessClient.Remove(bc);
        }

        /// <summary>
        /// Add Interpreter to the list 
        /// </summary>
        /// <param name="terp"></param>
        public void AddInterpreter(Interpreter terp)
        {
            interpreter.Add(terp, terp);
        }

        public void RemoveInterpreter(Interpreter terp)
        {
            interpreter.Remove(terp);
        }

        /// <summary>
        /// Add DeafClient to the list 
        /// </summary>
        /// <param name="dc"></param>
        public void AddDeafClient(DeafClient dc)
        {
            deafClient.Add(dc, dc);
        }

        public void RemoveDeafClient(DeafClient dc)
        {
            deafClient.Remove(dc);
        }
    }
}
