Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace SalaryReports

    Public Partial Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim empReport As EmployeeReport = New EmployeeReport()
            Dim printTool As ReportPrintTool = New ReportPrintTool(empReport)
            printTool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
