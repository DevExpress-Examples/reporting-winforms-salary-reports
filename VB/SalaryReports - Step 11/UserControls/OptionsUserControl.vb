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
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers

Namespace SalaryReports.UserControls
	Partial Public Class OptionsUserControl
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			InitializeComponent()
			SkinHelper.InitSkinGallery(galleryControl1)
		End Sub
	End Class
End Namespace
