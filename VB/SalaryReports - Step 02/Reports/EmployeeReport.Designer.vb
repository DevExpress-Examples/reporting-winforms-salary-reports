Imports Microsoft.VisualBasic
Imports System
Imports SalaryReports.Data
Imports SalaryReports.Data.EmployeesDBDataSetTableAdapters
Namespace SalaryReports
	Partial Public Class EmployeeReport
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.employeesDBDataSet1 = New SalaryReports.Data.EmployeesDBDataSet()
			Me.full_Emp_Data_QueryTableAdapter = New SalaryReports.Data.EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2, Me.xrLabel3, Me.xrLabel1, Me.xrTable1})
			Me.Detail.HeightF = 283.8333F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 208.8333F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow6})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(649.9999F, 75F)
			' 
			' xrTableRow4
			' 
			Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8})
			Me.xrTableRow4.Name = "xrTableRow4"
			Me.xrTableRow4.Weight = 1R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "Base salary:"
			Me.xrTableCell7.Weight = 1.1538462856676575R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PositionSalary", "{0:c2}")})
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "xrTableCell2"
			Me.xrTableCell8.Weight = 1.8461537143323425R
			' 
			' xrTableRow5
			' 
			Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow5.Name = "xrTableRow5"
			Me.xrTableRow5.Weight = 1R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "Sick days:"
			Me.xrTableCell9.Weight = 1.1538462856676575R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.SickDays")})
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Text = "xrTableCell4"
			Me.xrTableCell10.Weight = 1.8461537143323425R
			' 
			' xrTableRow6
			' 
			Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell11, Me.xrTableCell12})
			Me.xrTableRow6.Name = "xrTableRow6"
			Me.xrTableRow6.Weight = 1R
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Text = "Overtime (days):"
			Me.xrTableCell11.Weight = 1.1538462856676575R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.Overtime")})
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Text = "xrTableCell6"
			Me.xrTableCell12.Weight = 1.8461537143323425R
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PaymentDate", "Employee statistics in {0:MMMM, yyyy}")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 166.5F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(290F, 30F)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(290F, 30F)
			Me.xrLabel1.Text = "Employee Information:"
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 51.04167F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow3, Me.xrTableRow7})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(649.9999F, 100F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Full name:"
			Me.xrTableCell1.Weight = 1.1538462856676575R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.EmployeeName")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 1.8461537143323425R
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell4})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Email address:"
			Me.xrTableCell3.Weight = 1.1538462856676575R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.Email")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.Weight = 1.8461537143323425R
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.Weight = 1R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "Department:"
			Me.xrTableCell5.Weight = 1.1538462856676575R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.DepartmentName")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.Weight = 1.8461537143323425R
			' 
			' xrTableRow7
			' 
			Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell13, Me.xrTableCell14})
			Me.xrTableRow7.Name = "xrTableRow7"
			Me.xrTableRow7.Weight = 1R
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Text = "Position:"
			Me.xrTableCell13.Weight = 1.1538462856676575R
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PositionName")})
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.Text = "xrTableCell14"
			Me.xrTableCell14.Weight = 1.8461537143323425R
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' employeesDBDataSet1
			' 
			Me.employeesDBDataSet1.DataSetName = "EmployeesDBDataSet"
			Me.employeesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' full_Emp_Data_QueryTableAdapter
			' 
			Me.full_Emp_Data_QueryTableAdapter.ClearBeforeFill = True
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.lbTitle, Me.xrPageInfo2})
			Me.PageHeader.HeightF = 47.99997F
			Me.PageHeader.Name = "PageHeader"
			' 
			' xrLine1
			' 
			Me.xrLine1.LineWidth = 2
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 38.99997F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrLine1.SizeF = New System.Drawing.SizeF(650F, 9F)
			' 
			' lbTitle
			' 
			Me.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.lbTitle.Name = "lbTitle"
			Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbTitle.SizeF = New System.Drawing.SizeF(284.875F, 38F)
			Me.lbTitle.StylePriority.UseFont = False
			Me.lbTitle.StylePriority.UseForeColor = False
			Me.lbTitle.StylePriority.UseTextAlignment = False
			Me.lbTitle.Text = "Employee Salary Report"
			' 
			' xrPageInfo2
			' 
			Me.xrPageInfo2.Format = "{0:""Current Date: "" dddd, dd MMMM yyyy}"
			Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(358F, 15.99998F)
			Me.xrPageInfo2.Name = "xrPageInfo2"
			Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(292F, 23F)
			Me.xrPageInfo2.StylePriority.UseFont = False
			' 
			' EmployeeReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
			Me.DataAdapter = Me.full_Emp_Data_QueryTableAdapter
			Me.DataMember = "Full Emp Data Query"
			Me.DataSource = Me.employeesDBDataSet1
			Me.Version = "13.2"
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private employeesDBDataSet1 As EmployeesDBDataSet
		Private full_Emp_Data_QueryTableAdapter As Full_Emp_Data_QueryTableAdapter
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private lbTitle As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
	End Class
End Namespace
