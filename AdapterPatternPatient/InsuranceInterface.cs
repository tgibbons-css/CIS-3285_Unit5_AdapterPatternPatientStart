using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternPatient
{
    interface InsuranceInterface
    {
        // verifies that the patient is currently covered by this policy
        bool IsCovered(string patientName, string policyNumber);
        decimal CoverageAmount(int ProcedureID, decimal ProcedureCost);
        string getPatientName();
    }
}
