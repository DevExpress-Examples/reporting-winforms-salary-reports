Namespace SalaryReports

    Partial Class MainForm

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

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(13, 13)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(259, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Preview"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "MainForm"
            Me.Text = "Salary Reports Tutorial"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
