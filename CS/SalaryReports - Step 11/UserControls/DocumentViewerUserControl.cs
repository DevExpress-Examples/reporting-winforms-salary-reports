using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace SalaryReports.UserControls
{
    public partial class DocumentViewerUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private XtraReport report;

        public DocumentViewerUserControl()
        {
            InitializeComponent();
        }

        public XtraReport Report 
        {
            get
            {
                return report;
            }
            set
            {
            	report = value;
                documentViewer1.DocumentSource = report;
                if (report != null)
                    report.CreateDocument();
            }
        }
    }
}
