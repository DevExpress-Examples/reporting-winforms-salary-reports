Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace SalaryReports
	Partial Public Class ManagementReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ManagementReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
			Dim report As ManagementReport = TryCast(sender, ManagementReport)
			Dim year As Integer = Convert.ToInt32(report.Parameters("paramYear").Value)
			Dim month As Integer = Convert.ToInt32(report.Parameters("paramMonth").Value)

			report.Parameters("paramPaymentDate").Value = New DateTime(year, month, 1)
		End Sub

	End Class
End Namespace
