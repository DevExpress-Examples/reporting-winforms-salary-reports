Namespace SalaryReports.UserControls

    Partial Class OptionsUserControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
            Me.galleryControl1.Name = "galleryControl1"
            Me.galleryControl1.Size = New System.Drawing.Size(549, 350)
            Me.galleryControl1.TabIndex = 0
            Me.galleryControl1.Text = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient1.Size = New System.Drawing.Size(528, 346)
            ' 
            ' OptionsUserControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.galleryControl1)
            Me.Name = "OptionsUserControl"
            Me.Size = New System.Drawing.Size(549, 350)
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl

        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    End Class
End Namespace
