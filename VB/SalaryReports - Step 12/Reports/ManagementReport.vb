Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Namespace SalaryReports
	Partial Public Class ManagementReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrChart1_BeforePrint(ByVal sender As Object, ByVal e As CancelEventArgs) Handles xrChart1.BeforePrint
			Dim xrc As XRChart = CType(sender, XRChart)

			Dim filter_value As DateTime = CDate(paramPaymentDate.Value)

			' Clears the filters that may be set before.
			For Each series As Series In xrc.Series
				series.DataFilters.Clear()
				series.DataFilters.Add(New DataFilter("PaymentDate", "System.DateTime", DataFilterCondition.Equal, filter_value))
			Next series

		End Sub

		Private Sub ManagementReport_AfterPrint(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.AfterPrint
			Dim titleReport As New ManagementReportTitle()
			titleReport.Parameters("paramPaymentDate").Value = paramPaymentDate.Value
			titleReport.CreateDocument()

			Me.PrintingSystem.ContinuousPageNumbering = True
			Me.Pages.Insert(0, titleReport.Pages(0))
		End Sub

		Private Sub ManagementReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
			Dim report As ManagementReport = TryCast(sender, ManagementReport)
			Dim year As Integer = Convert.ToInt32(report.Parameters("paramYear").Value)
			Dim month As Integer = Convert.ToInt32(report.Parameters("paramMonth").Value)

			report.Parameters("paramPaymentDate").Value = New DateTime(year, month, 1)
		End Sub

	End Class
End Namespace
