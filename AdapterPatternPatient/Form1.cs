using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatternPatient
{
    public partial class Form1 : Form
    {

        List<InsuranceInterface> patients = new List<InsuranceInterface>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            patients.Add(new InNetworkPatient("Tom Gibbons", "A111B222", PolicyLevels.Gold));
            patients.Add(new InNetworkPatient("Jen Rosato", "A222C444", PolicyLevels.Platnum));
            patients.Add(new InNetworkPatient("Dave Vosen", "D333B111", PolicyLevels.Silver));

            foreach (InsuranceInterface pat in patients)
            {
                cbName.Items.Add(pat.getPatientName());
            }
        }

        private void btnCheckCoverage_Click(object sender, EventArgs e)
        {

            int patientIndex = cbName.SelectedIndex;
            InsuranceInterface patient = patients[patientIndex];
            decimal chargeAmt = Decimal.Parse(txtAmount.Text);

            decimal coveredAmt = patient.CoverageAmount(cbProcedure.SelectedIndex, chargeAmt);
            txtAmtCovered.Text = coveredAmt.ToString("0.00");
        }

    }
}
