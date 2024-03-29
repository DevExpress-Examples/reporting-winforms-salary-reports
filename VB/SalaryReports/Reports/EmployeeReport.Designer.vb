﻿Imports Microsoft.VisualBasic
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
			Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
			Dim staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
			Me.employeesTableAdapter = New EmployeesDBDataSetTableAdapters.EmployeesTableAdapter()
			Me.employeesDBDataSet1 = New EmployeesDBDataSet()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.sickDaysFormattingRule = New DevExpress.XtraReports.UI.FormattingRule()
			Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.overtimeFormattingRule = New DevExpress.XtraReports.UI.FormattingRule()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
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
			Me.full_Emp_Data_QueryTableAdapter = New EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.totalPayment = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xrPageHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrTableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrTableCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrControlHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.paramEmpName = New DevExpress.XtraReports.Parameters.Parameter()
			Me.paramYear = New DevExpress.XtraReports.Parameters.Parameter()
			Me.paramMonth = New DevExpress.XtraReports.Parameters.Parameter()
			Me.paramPaymentDate = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' employeesDBDataSet1
			' 
			Me.employeesDBDataSet1.DataSetName = "EmployeesDBDataSet"
			Me.employeesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrTable2, Me.xrLabel2, Me.xrLabel1, Me.xrTable1})
			Me.Detail.HeightF = 347.7917F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.totalPayment", "Total payment: {0:c2}")})
			Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(0))))))
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(250.0001F, 305.1667F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(399.9999F, 42.625F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "Total payment:"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
			Me.xrTableCell7.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell7.Text = "Base salary:"
			Me.xrTableCell7.Weight = 1.1538462856676575R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PositionSalary", "{0:c2}")})
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.StyleName = "xrTableCellStyle"
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
			Me.xrTableCell9.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell9.Text = "Sick days:"
			Me.xrTableCell9.Weight = 1.1538462856676575R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.xrTableCell10.BorderColor = System.Drawing.Color.White
			Me.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.SickDays")})
			Me.xrTableCell10.FormattingRules.Add(Me.sickDaysFormattingRule)
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StyleName = "xrTableCellStyle"
			Me.xrTableCell10.StylePriority.UseBackColor = False
			Me.xrTableCell10.StylePriority.UseBorderColor = False
			Me.xrTableCell10.StylePriority.UseBorders = False
			Me.xrTableCell10.Text = "xrTableCell4"
			Me.xrTableCell10.Weight = 1.8461537143323425R
			' 
			' sickDaysFormattingRule
			' 
			Me.sickDaysFormattingRule.Condition = "[SickDays] > 0"
			' 
			' 
			' 
			Me.sickDaysFormattingRule.Formatting.BackColor = System.Drawing.Color.Pink
			Me.sickDaysFormattingRule.Name = "sickDaysFormattingRule"
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
			Me.xrTableCell11.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell11.Text = "Overtime (days):"
			Me.xrTableCell11.Weight = 1.1538462856676575R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))))
			Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.Overtime")})
			Me.xrTableCell12.FormattingRules.Add(Me.overtimeFormattingRule)
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.StyleName = "xrTableCellStyle"
			Me.xrTableCell12.StylePriority.UseBackColor = False
			Me.xrTableCell12.Text = "xrTableCell6"
			Me.xrTableCell12.Weight = 1.8461537143323425R
			' 
			' overtimeFormattingRule
			' 
			Me.overtimeFormattingRule.Condition = "[Overtime] > 0"
			' 
			' 
			' 
			Me.overtimeFormattingRule.Formatting.BackColor = System.Drawing.Color.Pink
			Me.overtimeFormattingRule.Name = "overtimeFormattingRule"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PaymentDate", "Employee statistics in {0:MMMM, yyyy}")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(7.947286E-05F, 166.5F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(450.4167F, 30F)
			Me.xrLabel2.StyleName = "xrControlHeaderStyle"
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(290F, 30F)
			Me.xrLabel1.StyleName = "xrControlHeaderStyle"
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
			Me.xrTableCell1.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell1.Text = "Full name:"
			Me.xrTableCell1.Weight = 1.1538462856676575R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.EmployeeName")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StyleName = "xrTableCellStyle"
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
			Me.xrTableCell3.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell3.Text = "Email address:"
			Me.xrTableCell3.Weight = 1.1538462856676575R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.Email")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StyleName = "xrTableCellStyle"
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
			Me.xrTableCell5.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell5.Text = "Department:"
			Me.xrTableCell5.Weight = 1.1538462856676575R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.DepartmentName")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StyleName = "xrTableCellStyle"
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
			Me.xrTableCell13.StyleName = "xrTableHeaderStyle"
			Me.xrTableCell13.Text = "Position:"
			Me.xrTableCell13.Weight = 1.1538462856676575R
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Full Emp Data Query.PositionName")})
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.StyleName = "xrTableCellStyle"
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
			' full_Emp_Data_QueryTableAdapter
			' 
			Me.full_Emp_Data_QueryTableAdapter.ClearBeforeFill = True
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.lbTitle, Me.xrPageInfo2})
			Me.PageHeader.HeightF = 47.99997F
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.StyleName = "xrPageHeaderStyle"
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
			Me.lbTitle.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
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
			' totalPayment
			' 
			Me.totalPayment.DataMember = "Full Emp Data Query"
			Me.totalPayment.Expression = "[PositionSalary] + (([PositionSalary] * [Overtime]) / 22)"
			Me.totalPayment.FieldType = DevExpress.XtraReports.UI.FieldType.Float
			Me.totalPayment.Name = "totalPayment"
			' 
			' xrPageHeaderStyle
			' 
			Me.xrPageHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(84))))), (CInt(Fix((CByte(132))))), (CInt(Fix((CByte(213))))))
			Me.xrPageHeaderStyle.Name = "xrPageHeaderStyle"
			Me.xrPageHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' xrTableHeaderStyle
			' 
			Me.xrTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(84))))), (CInt(Fix((CByte(132))))), (CInt(Fix((CByte(213))))))
			Me.xrTableHeaderStyle.BorderColor = System.Drawing.Color.White
			Me.xrTableHeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableHeaderStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", (CByte(204)))})
			Me.xrTableHeaderStyle.ForeColor = System.Drawing.Color.White
			Me.xrTableHeaderStyle.Name = "xrTableHeaderStyle"
			Me.xrTableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableCellStyle
			' 
			Me.xrTableCellStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", (CByte(204)))})
			Me.xrTableCellStyle.Name = "xrTableCellStyle"
			Me.xrTableCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100F)
			Me.xrTableCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrControlHeaderStyle
			' 
			Me.xrControlHeaderStyle.Font = New DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.xrControlHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(0))))))
			Me.xrControlHeaderStyle.Name = "xrControlHeaderStyle"
			Me.xrControlHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' paramEmpName
			' 
			Me.paramEmpName.Description = "Employee"
			dynamicListLookUpSettings1.DataAdapter = Me.employeesTableAdapter
			dynamicListLookUpSettings1.DataMember = "Employees"
			dynamicListLookUpSettings1.DataSource = Me.employeesDBDataSet1
			dynamicListLookUpSettings1.DisplayMember = "EmployeeName"
			dynamicListLookUpSettings1.ValueMember = "EmployeeName"
			Me.paramEmpName.LookUpSettings = dynamicListLookUpSettings1
			Me.paramEmpName.Name = "paramEmpName"
			Me.paramEmpName.ValueInfo = "Robert M. Street"
			' 
			' paramYear
			' 
			Me.paramYear.Description = "Year"
			Me.paramYear.Name = "paramYear"
			Me.paramYear.Type = GetType(Integer)
			Me.paramYear.ValueInfo = "2012"
			' 
			' paramMonth
			' 
			Me.paramMonth.Description = "Month"
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(1, "January"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(2, "February"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(3, "March"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(4, "April"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(5, "May"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(6, "June"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(7, "July"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(8, "August"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(9, "September"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(10, "October"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(11, "November"))
			staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue(12, "December"))
			Me.paramMonth.LookUpSettings = staticListLookUpSettings1
			Me.paramMonth.Name = "paramMonth"
			Me.paramMonth.Type = GetType(Integer)
			Me.paramMonth.ValueInfo = "1"
			' 
			' paramPaymentDate
			' 
			Me.paramPaymentDate.Description = "Payment Date"
			Me.paramPaymentDate.Name = "paramPaymentDate"
			Me.paramPaymentDate.Type = GetType(System.DateTime)
			Me.paramPaymentDate.ValueInfo = "01/01/2013 14:11:12"
			Me.paramPaymentDate.Visible = False
			' 
			' EmployeeReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.totalPayment})
			Me.DataAdapter = Me.full_Emp_Data_QueryTableAdapter
			Me.DataMember = "Full Emp Data Query"
			Me.DataSource = Me.employeesDBDataSet1
			Me.FilterString = "Contains([EmployeeName], ?paramEmpName) And [PaymentDate] = ?paramPaymentDate"
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.sickDaysFormattingRule, Me.overtimeFormattingRule})
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramEmpName, Me.paramYear, Me.paramMonth, Me.paramPaymentDate})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrPageHeaderStyle, Me.xrTableHeaderStyle, Me.xrTableCellStyle, Me.xrControlHeaderStyle})
			Me.Version = "13.2"
'			Me.ParametersRequestSubmit += New System.EventHandler(Of DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)(Me.EmployeeReport_ParametersRequestSubmit);

			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private employeesDBDataSet1 As EmployeesDBDataSet
		Private full_Emp_Data_QueryTableAdapter As EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
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
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
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
		Private totalPayment As DevExpress.XtraReports.UI.CalculatedField
		Private xrPageHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrTableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrTableCellStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrControlHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private sickDaysFormattingRule As DevExpress.XtraReports.UI.FormattingRule
		Private overtimeFormattingRule As DevExpress.XtraReports.UI.FormattingRule
		Private paramEmpName As DevExpress.XtraReports.Parameters.Parameter
		Private employeesTableAdapter As EmployeesDBDataSetTableAdapters.EmployeesTableAdapter
		Private paramYear As DevExpress.XtraReports.Parameters.Parameter
		Private paramMonth As DevExpress.XtraReports.Parameters.Parameter
		Private paramPaymentDate As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace
