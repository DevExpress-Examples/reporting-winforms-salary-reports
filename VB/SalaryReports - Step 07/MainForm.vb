Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports SalaryReports.UserControls

Namespace SalaryReports
	Partial Public Class MainForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub windowsUIView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles windowsUIView1.QueryControl
			Select Case CInt(Fix(e.Document.Tag))
				Case 0
					e.Control = New DocumentViewerUserControl() With {.Report = New ManagementReport()}
				Case 1
					e.Control = New DocumentViewerUserControl() With {.Report = New EmployeeReport()}
				Case 2
					Dim report As New EmployeeReport()
					report.Parameters("paramEmpName").Value = String.Empty
					report.Parameters("paramEmpName").Visible = False
					e.Control = New DocumentViewerUserControl() With {.Report = report}
			End Select
		End Sub
	End Class
End Namespace