Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Namespace SalaryReports
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim empReport As New EmployeeReport()

			Dim printTool As New ReportPrintTool(empReport)
			printTool.ShowPreviewDialog()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			Dim manReport As New ManagementReport()

			Dim printTool As New ReportPrintTool(manReport)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
