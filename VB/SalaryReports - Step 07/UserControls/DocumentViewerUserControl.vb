Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Namespace SalaryReports.UserControls

    Public Partial Class DocumentViewerUserControl
        Inherits XtraUserControl

        Private reportField As XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Property Report As XtraReport
            Get
                Return reportField
            End Get

            Set(ByVal value As XtraReport)
                reportField = value
                documentViewer1.DocumentSource = reportField
                If reportField IsNot Nothing Then reportField.CreateDocument()
            End Set
        End Property
    End Class
End Namespace
