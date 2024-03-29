Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports SalaryReports.UserControls

Namespace SalaryReports

    Public Partial Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub windowsUIView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
            Select Case CInt(e.Document.Tag)
                Case 0
                    e.Control = New SalaryReports.UserControls.DocumentViewerUserControl() With {.Report = New SalaryReports.ManagementReport()}
                Case 1
                    e.Control = New SalaryReports.UserControls.DocumentViewerUserControl() With {.Report = New SalaryReports.EmployeeReport()}
                Case 2
                    Dim report As SalaryReports.EmployeeReport = New SalaryReports.EmployeeReport()
                    report.Parameters(CStr(("paramEmpName"))).Value = String.Empty
                    report.Parameters(CStr(("paramEmpName"))).Visible = False
                    e.Control = New SalaryReports.UserControls.DocumentViewerUserControl() With {.Report = report}
                Case 3
                    e.Control = New SalaryReports.UserControls.OptionsUserControl()
            End Select
        End Sub
    End Class
End Namespace
