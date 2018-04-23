Imports Microsoft.VisualBasic
Imports System
Namespace SalaryReports
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Me.documentManagerMain = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
			Me.tileContainer1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
			Me.tileManagementReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.docManagementReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.tileAllEmployeeReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.docAllEmployeeReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.tileEmployeeReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.docEmployeeReport = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.tileSettings = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.docSettings = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.formAssistant1 = New DevExpress.XtraBars.FormAssistant()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.documentManagerMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileManagementReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docManagementReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileAllEmployeeReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docAllEmployeeReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileEmployeeReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docEmployeeReport, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManagerMain
			' 
			Me.documentManagerMain.ContainerControl = Me
			Me.documentManagerMain.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False
			Me.documentManagerMain.View = Me.windowsUIView1
			Me.documentManagerMain.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.windowsUIView1})
			' 
			' windowsUIView1
			' 
			Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.tileContainer1})
			Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.docEmployeeReport, Me.docAllEmployeeReport, Me.docManagementReport, Me.docSettings})
			Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.tileEmployeeReport, Me.tileAllEmployeeReport, Me.tileManagementReport, Me.tileSettings})
'			Me.windowsUIView1.QueryControl += New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(Me.windowsUIView1_QueryControl);
			' 
			' tileContainer1
			' 
			Me.tileContainer1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.tileManagementReport, Me.tileAllEmployeeReport, Me.tileEmployeeReport, Me.tileSettings})
			Me.tileContainer1.Name = "tileContainer1"
			' 
			' tileManagementReport
			' 
			Me.tileManagementReport.Document = Me.docManagementReport
			tileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
			tileItemElement4.Appearance.Normal.Options.UseFont = True
			tileItemElement4.Text = "Management Report"
			tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.tileManagementReport.Elements.Add(tileItemElement4)
			Me.tileManagementReport.Group = "GroupReports"
			Me.tileManagementReport.Name = "tileManagementReport"
			Me.tileManagementReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			' 
			' docManagementReport
			' 
			Me.docManagementReport.Caption = "Management Report"
			Me.docManagementReport.ControlName = ""
			Me.docManagementReport.Tag = 0
			' 
			' tileAllEmployeeReport
			' 
			Me.tileAllEmployeeReport.Document = Me.docAllEmployeeReport
			tileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
			tileItemElement5.Appearance.Normal.Options.UseFont = True
			tileItemElement5.Appearance.Normal.Options.UseTextOptions = True
			tileItemElement5.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			tileItemElement5.Text = "Report for all Employees"
			tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.tileAllEmployeeReport.Elements.Add(tileItemElement5)
			Me.tileAllEmployeeReport.Group = "GroupReports"
			Me.tileContainer1.SetID(Me.tileAllEmployeeReport, 2)
			Me.tileAllEmployeeReport.Name = "tileAllEmployeeReport"
			Me.tileAllEmployeeReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			' 
			' docAllEmployeeReport
			' 
			Me.docAllEmployeeReport.Caption = "All Employee Report"
			Me.docAllEmployeeReport.ControlName = ""
			Me.docAllEmployeeReport.Tag = 2
			' 
			' tileEmployeeReport
			' 
			Me.tileEmployeeReport.Document = Me.docEmployeeReport
			tileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
			tileItemElement1.Appearance.Normal.Options.UseFont = True
			tileItemElement1.Text = "Employee Report"
			tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.tileEmployeeReport.Elements.Add(tileItemElement1)
			Me.tileEmployeeReport.Group = "GroupReports"
			Me.tileContainer1.SetID(Me.tileEmployeeReport, 1)
			Me.tileEmployeeReport.Name = "tileEmployeeReport"
			Me.tileEmployeeReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			' 
			' docEmployeeReport
			' 
			Me.docEmployeeReport.Caption = "Employee Report"
			Me.docEmployeeReport.ControlName = ""
			Me.docEmployeeReport.Tag = 1
			' 
			' tileSettings
			' 
			Me.tileSettings.Document = Me.docSettings
			tileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
			tileItemElement2.Appearance.Normal.Options.UseFont = True
			tileItemElement2.Text = "Settings"
			tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			Me.tileSettings.Elements.Add(tileItemElement2)
			Me.tileSettings.Group = "GroupSettings"
			Me.tileContainer1.SetID(Me.tileSettings, 3)
			Me.tileSettings.Name = "tileSettings"
			Me.tileSettings.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			' 
			' docSettings
			' 
			Me.docSettings.Caption = "Settings"
			Me.docSettings.ControlName = ""
			Me.docSettings.Tag = 3
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(901, 547)
			Me.Name = "MainForm"
			Me.Text = "Salary Reports Tutorial"
			CType(Me.documentManagerMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileManagementReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docManagementReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileAllEmployeeReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docAllEmployeeReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileEmployeeReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docEmployeeReport, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileSettings, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManagerMain As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private tileContainer1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
		Private tileManagementReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private tileAllEmployeeReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private tileEmployeeReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private tileSettings As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private docEmployeeReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private docAllEmployeeReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private docManagementReport As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private docSettings As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private formAssistant1 As DevExpress.XtraBars.FormAssistant
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel


	End Class
End Namespace