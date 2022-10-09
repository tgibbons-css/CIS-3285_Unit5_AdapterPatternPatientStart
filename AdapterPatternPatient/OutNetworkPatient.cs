using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternPatient
{

    class OutNetworkPatient 
    {
        public OutNetworkPatient(string newName, int newPolicyNumber)
        {
            Name = newName;
            PolicyNumber = newPolicyNumber;
        }
        public string Name { get; set; }                // patient's full name
        public int PolicyNumber { get; set; }            // policy number
        public DateTime Dob { get; set; }               // date of birth

        public decimal CoveragePercent (decimal ProcedureCost)
        {
            decimal percent;
            if (ProcedureCost<1000.00M)
            {
                percent = 0.7M;
            }
            else
            {
                percent = 0.5M;
            }
            return percent; 
        }

        // required for Insurance Interface
        public string IsCovered(string patientName, int policyNumber)
        {
            if ((patientName == Name) && (policyNumber==PolicyNumber))
            {
                return "yes";
            } else
            {
                return "no";
            }
        }

        public string getPatientName()
        {
            return Name;
        }
    }
}
