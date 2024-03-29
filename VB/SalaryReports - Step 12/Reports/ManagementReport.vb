Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Namespace SalaryReports

    Public Partial Class ManagementReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrChart1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            Dim xrc As XRChart = CType(sender, XRChart)
            Dim filter_value As Date = CDate(paramPaymentDate.Value)
            ' Clears the filters that may be set before.
            For Each series As Series In xrc.Series
                series.DataFilters.Clear()
                series.DataFilters.Add(New DataFilter("PaymentDate", "System.DateTime", DataFilterCondition.Equal, filter_value))
            Next
        End Sub

        Private Sub ManagementReport_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
            Dim titleReport As ManagementReportTitle = New ManagementReportTitle()
            titleReport.Parameters("paramPaymentDate").Value = paramPaymentDate.Value
            titleReport.CreateDocument()
            PrintingSystem.ContinuousPageNumbering = True
            Pages.Insert(0, titleReport.Pages(0))
        End Sub

        Private Sub ManagementReport_ParametersRequestSubmit(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)
            Dim report As ManagementReport = TryCast(sender, ManagementReport)
            Dim year As Integer = Convert.ToInt32(report.Parameters("paramYear").Value)
            Dim month As Integer = Convert.ToInt32(report.Parameters("paramMonth").Value)
            report.Parameters("paramPaymentDate").Value = New DateTime(year, month, 1)
        End Sub
    End Class
End Namespace
