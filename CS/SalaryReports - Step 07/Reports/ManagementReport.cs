using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraCharts;

namespace SalaryReports
{
    public partial class ManagementReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ManagementReport()
        {
            InitializeComponent();
        }

        private void ManagementReport_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            ManagementReport report = sender as ManagementReport;
            int year = Convert.ToInt32(report.Parameters["paramYear"].Value);
            int month = Convert.ToInt32(report.Parameters["paramMonth"].Value);

            report.Parameters["paramPaymentDate"].Value = new DateTime(year, month, 1);
        }
    }
}
