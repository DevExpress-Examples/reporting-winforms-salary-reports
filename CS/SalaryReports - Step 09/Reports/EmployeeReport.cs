using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SalaryReports
{
    public partial class EmployeeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void EmployeeReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            EmployeeReport report = sender as EmployeeReport;
            int year = Convert.ToInt32(report.Parameters["paramYear"].Value);
            int month = Convert.ToInt32(report.Parameters["paramMonth"].Value);

            report.Parameters["paramPaymentDate"].Value = new DateTime(year, month, 1);
        }

    }
}
