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

        private void xrChart1_BeforePrint(object sender, CancelEventArgs e)
        {
            XRChart xrc = (XRChart)sender;

            DateTime filter_value = (DateTime)paramPaymentDate.Value;

            // Clears the filters that may be set before.
            foreach (Series series in xrc.Series)
            {
                series.DataFilters.Clear();                
                series.DataFilters.Add(new DataFilter("PaymentDate", "System.DateTime",
                    DataFilterCondition.Equal, filter_value));
            }

        }

        private void ManagementReport_AfterPrint(object sender, EventArgs e)
        {
            ManagementReportTitle titleReport = new ManagementReportTitle();
            titleReport.Parameters["paramPaymentDate"].Value = paramPaymentDate.Value;
            titleReport.CreateDocument();

            this.PrintingSystem.ContinuousPageNumbering = true;
            this.Pages.Insert(0, titleReport.Pages[0]);            
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
