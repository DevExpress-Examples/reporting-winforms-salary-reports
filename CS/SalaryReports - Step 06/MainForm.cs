using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;

namespace SalaryReports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EmployeeReport empReport = new EmployeeReport();
           
            ReportPrintTool printTool = new ReportPrintTool(empReport);
            printTool.ShowPreviewDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ManagementReport manReport = new ManagementReport();

            ReportPrintTool printTool = new ReportPrintTool(manReport);
            printTool.ShowPreviewDialog();
        }
    }
}
