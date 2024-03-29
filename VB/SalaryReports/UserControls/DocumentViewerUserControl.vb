Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Namespace SalaryReports.UserControls
	Partial Public Class DocumentViewerUserControl
		Inherits DevExpress.XtraEditors.XtraUserControl
		Private report_Renamed As XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Property Report() As XtraReport
			Get
				Return report_Renamed
			End Get
			Set(ByVal value As XtraReport)
				report_Renamed = value
				documentViewer1.DocumentSource = report_Renamed
				If report_Renamed IsNot Nothing Then
					report_Renamed.CreateDocument()
				End If
			End Set
		End Property
	End Class
End Namespace
