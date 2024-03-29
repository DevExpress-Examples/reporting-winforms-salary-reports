Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers

Namespace SalaryReports.UserControls

    Public Partial Class OptionsUserControl
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            Call SkinHelper.InitSkinGallery(galleryControl1)
        End Sub
    End Class
End Namespace
