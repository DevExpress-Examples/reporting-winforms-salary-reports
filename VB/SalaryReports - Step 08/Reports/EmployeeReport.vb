Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace SalaryReports

    Public Partial Class EmployeeReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub EmployeeReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)
            Dim report As EmployeeReport = TryCast(sender, EmployeeReport)
            Dim year As Integer = Convert.ToInt32(report.Parameters("paramYear").Value)
            Dim month As Integer = Convert.ToInt32(report.Parameters("paramMonth").Value)
            report.Parameters("paramPaymentDate").Value = New DateTime(year, month, 1)
        End Sub
    End Class
End Namespace
