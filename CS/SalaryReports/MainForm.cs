using SalaryReports.UserControls;

namespace SalaryReports {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            switch ((int)e.Document.Tag)
            {
                case 0:
                    e.Control = new DocumentViewerUserControl() { Report = new ManagementReport() };
                    break;
                case 1:
                    e.Control = new DocumentViewerUserControl() { Report = new EmployeeReport() };
                    break;
                case 2:
                    EmployeeReport report = new EmployeeReport();
                    report.Parameters["paramEmpName"].Value = string.Empty;
                    report.Parameters["paramEmpName"].Visible = false;
                    e.Control = new DocumentViewerUserControl() { Report = report };
                    break;
                case 3:
                    e.Control = new OptionsUserControl();
                    break;
            }
        }
    }
}