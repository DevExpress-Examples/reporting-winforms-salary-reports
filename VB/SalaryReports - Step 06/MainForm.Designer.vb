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
            Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' simpleButton3
            ' 
            Me.simpleButton3.Location = New System.Drawing.Point(12, 40)
            Me.simpleButton3.Name = "simpleButton3"
            Me.simpleButton3.Size = New System.Drawing.Size(346, 22)
            Me.simpleButton3.TabIndex = 14
            Me.simpleButton3.Text = "Preview the Management Report for a given date"
            AddHandler Me.simpleButton3.Click, New System.EventHandler(AddressOf Me.simpleButton3_Click)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 12)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(346, 22)
            Me.simpleButton1.TabIndex = 12
            Me.simpleButton1.Tag = ""
            Me.simpleButton1.Text = "Preview the Employee Salary Report"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(369, 211)
            Me.Controls.Add(Me.simpleButton3)
            Me.Controls.Add(Me.simpleButton1)
            Me.Name = "MainForm"
            Me.Text = "Salary Reports Tutorial"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private simpleButton3 As DevExpress.XtraEditors.SimpleButton

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
