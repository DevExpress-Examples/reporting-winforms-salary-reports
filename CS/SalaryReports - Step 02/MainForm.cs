using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

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
    }
}
