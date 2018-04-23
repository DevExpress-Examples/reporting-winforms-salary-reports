Imports Microsoft.VisualBasic
Imports System
Imports SalaryReports.Data
Imports SalaryReports.Data.EmployeesDBDataSetTableAdapters
Namespace SalaryReports
	Partial Public Class ManagementReport
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
			Dim staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary3 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.lbTitle = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.employeesDBDataSet1 = New EmployeesDBDataSet()
			Me.paramYear = New DevExpress.XtraReports.Parameters.Parameter()
			Me.paramMonth = New DevExpress.XtraReports.Parameters.Parameter()
			Me.paramPaymentDate = New DevExpress.XtraReports.Parameters.Parameter()
			Me.departmentsTableAdapter1 = New DepartmentsTableAdapter()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.departmentEmployeesTableAdapter = New DepartmentEmployeesTableAdapter()
			Me.xrPageHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrControlHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrTableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrTableCellStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.calcTotalPayment = New DevExpress.XtraReports.UI.CalculatedField()
			Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
			Me.full_Emp_Data_QueryTableAdapter = New Full_Emp_Data_QueryTableAdapter()
			Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine2, Me.xrLabel1})
			Me.Detail.HeightF = 55.91669F
			Me.Detail.KeepTogetherWithDetailReports = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StyleName = "xrControlHeaderStyle"
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLine2
			' 
			Me.xrLine2.LineWidth = 2
			Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 42.37502F)
			Me.xrLine2.Name = "xrLine2"
			Me.xrLine2.SizeF = New System.Drawing.SizeF(400F, 13.54167F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.DepartmentName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(400F, 32.37502F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(549.7023F, 26F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(100F, 23F)
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
			Me.lbTitle.Font = New System.Drawing.Font("Tahoma", 18F)
			Me.lbTitle.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.lbTitle.Name = "lbTitle"
			Me.lbTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbTitle.SizeF = New System.Drawing.SizeF(345.5F, 38F)
			Me.lbTitle.StylePriority.UseFont = False
			Me.lbTitle.StylePriority.UseForeColor = False
			Me.lbTitle.StylePriority.UseTextAlignment = False
			Me.lbTitle.Text = "Salary Report by Departments"
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
			' employeesDBDataSet1
			' 
			Me.employeesDBDataSet1.DataSetName = "EmployeesDBDataSet"
			Me.employeesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
			Me.paramPaymentDate.ValueInfo = "2013-04-17"
			Me.paramPaymentDate.Visible = False
			' 
			' departmentsTableAdapter1
			' 
			Me.departmentsTableAdapter1.ClearBeforeFill = True
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.ReportHeader, Me.ReportFooter})
			Me.DetailReport.DataAdapter = Me.departmentEmployeesTableAdapter
			Me.DetailReport.DataMember = "Departments.Departments_Employees"
			Me.DetailReport.DataSource = Me.employeesDBDataSet1
			Me.DetailReport.FilterString = "[PaymentDate] = ?paramPaymentDate"
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail1.HeightF = 25F
			Me.Detail1.Name = "Detail1"
			Me.Detail1.StyleName = "xrTableCellStyle"
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.EmployeeName")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 0.30769230769230771R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.PositionName")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 0.26775147928994086R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.Overtime")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell4.Weight = 0.17110453227567957R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.SickDays")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell5.Weight = 0.16420113287028476R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.calcTotalPayment", "{0:c2}")})
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell6.Weight = 0.16617362479486408R
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.ReportHeader.HeightF = 25F
			Me.ReportHeader.Name = "ReportHeader"
			Me.ReportHeader.StyleName = "xrTableHeaderStyle"
			' 
			' xrTable2
			' 
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Employee Name"
			Me.xrTableCell1.Weight = 0.30769230769230771R
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Text = "Position"
			Me.xrTableCell7.Weight = 0.26775147928994086R
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.Text = "Overtime"
			Me.xrTableCell8.Weight = 0.17110453227567957R
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Text = "Sick days"
			Me.xrTableCell9.Weight = 0.16420113287028476R
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Text = "Payment"
			Me.xrTableCell10.Weight = 0.16617362479486408R
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable3})
			Me.ReportFooter.HeightF = 59.99997F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' xrTable3
			' 
			Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(323.363F, 9.999974F)
			Me.xrTable3.Name = "xrTable3"
			Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3, Me.xrTableRow4})
			Me.xrTable3.SizeF = New System.Drawing.SizeF(326.637F, 50F)
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell13})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.StyleName = "xrTableHeaderStyle"
			Me.xrTableRow3.Weight = 1R
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Text = "Total Overtime"
			Me.xrTableCell11.Weight = 1.0235987286770183R
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Text = "Total Sick days"
			Me.xrTableCell12.Weight = 0.98230059430306316R
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Text = "Total payment"
			Me.xrTableCell13.Weight = 0.99410067701991855R
			' 
			' xrTableRow4
			' 
			Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell14, Me.xrTableCell15, Me.xrTableCell16})
			Me.xrTableRow4.Name = "xrTableRow4"
			Me.xrTableRow4.StyleName = "xrTableCellStyle"
			Me.xrTableRow4.Weight = 1R
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.Overtime")})
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.StylePriority.UseTextAlignment = False
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrTableCell14.Summary = xrSummary1
			Me.xrTableCell14.Text = "xrTableCell14"
			Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell14.Weight = 1.0235987286770183R
			' 
			' xrTableCell15
			' 
			Me.xrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.SickDays")})
			Me.xrTableCell15.Name = "xrTableCell15"
			Me.xrTableCell15.StylePriority.UseTextAlignment = False
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrTableCell15.Summary = xrSummary2
			Me.xrTableCell15.Text = "xrTableCell15"
			Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell15.Weight = 0.98230059430306316R
			' 
			' xrTableCell16
			' 
			Me.xrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Departments.Departments_Employees.calcTotalPayment")})
			Me.xrTableCell16.Name = "xrTableCell16"
			Me.xrTableCell16.StylePriority.UseTextAlignment = False
			xrSummary3.FormatString = "{0:c2}"
			xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrTableCell16.Summary = xrSummary3
			Me.xrTableCell16.Text = "xrTableCell16"
			Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell16.Weight = 0.99410067701991855R
			' 
			' departmentEmployeesTableAdapter
			' 
			Me.departmentEmployeesTableAdapter.ClearBeforeFill = True
			' 
			' xrPageHeaderStyle
			' 
			Me.xrPageHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(84))))), (CInt(Fix((CByte(132))))), (CInt(Fix((CByte(213))))))
			Me.xrPageHeaderStyle.Name = "xrPageHeaderStyle"
			Me.xrPageHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' xrControlHeaderStyle
			' 
			Me.xrControlHeaderStyle.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrControlHeaderStyle.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(120))))), (CInt(Fix((CByte(0))))))
			Me.xrControlHeaderStyle.Name = "xrControlHeaderStyle"
			Me.xrControlHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
			' 
			' xrTableHeaderStyle
			' 
			Me.xrTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(84))))), (CInt(Fix((CByte(132))))), (CInt(Fix((CByte(213))))))
			Me.xrTableHeaderStyle.BorderColor = System.Drawing.Color.White
			Me.xrTableHeaderStyle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableHeaderStyle.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrTableHeaderStyle.ForeColor = System.Drawing.Color.White
			Me.xrTableHeaderStyle.Name = "xrTableHeaderStyle"
			Me.xrTableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableCellStyle
			' 
			Me.xrTableCellStyle.BorderColor = System.Drawing.Color.Gainsboro
			Me.xrTableCellStyle.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellStyle.Name = "xrTableCellStyle"
			Me.xrTableCellStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F)
			' 
			' calcTotalPayment
			' 
			Me.calcTotalPayment.DataMember = "Departments.Departments_Employees"
			Me.calcTotalPayment.Expression = "[PositionSalary] + (([PositionSalary] * [Overtime]) / 22)"
			Me.calcTotalPayment.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
			Me.calcTotalPayment.Name = "calcTotalPayment"
			' 
			' ReportFooter1
			' 
			Me.ReportFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1, Me.xrLine3, Me.xrLabel2})
			Me.ReportFooter1.HeightF = 443.75F
			Me.ReportFooter1.Name = "ReportFooter1"
			Me.ReportFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
			Me.ReportFooter1.StyleName = "xrControlHeaderStyle"
			' 
			' xrChart1
			' 
			Me.xrChart1.BorderColor = System.Drawing.Color.Black
			Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart1.DataAdapter = Me.full_Emp_Data_QueryTableAdapter
			Me.xrChart1.DataMember = "Full Emp Data Query"
			Me.xrChart1.DataSource = Me.employeesDBDataSet1
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False
			Me.xrChart1.Diagram = xyDiagram1
			Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 45.91675F)
			Me.xrChart1.Name = "xrChart1"
			series1.ArgumentDataMember = "DepartmentName"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series1.Name = "Sick Days"
			series1.SummaryFunction = "SUM([SickDays])"
			series2.ArgumentDataMember = "DepartmentName"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series2.Name = "Overtime"
			series2.SummaryFunction = "SUM([Overtime])"
			Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.xrChart1.SizeF = New System.Drawing.SizeF(650F, 397.8333F)
'			Me.xrChart1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrChart1_BeforePrint);
			' 
			' full_Emp_Data_QueryTableAdapter
			' 
			Me.full_Emp_Data_QueryTableAdapter.ClearBeforeFill = True
			' 
			' xrLine3
			' 
			Me.xrLine3.LineWidth = 2
			Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 32.37508F)
			Me.xrLine3.Name = "xrLine3"
			Me.xrLine3.SizeF = New System.Drawing.SizeF(650F, 13.54167F)
			' 
			' xrLabel2
			' 
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(650F, 32.37502F)
			Me.xrLabel2.Text = "Summary Chart by departments"
			' 
			' ManagementReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.DetailReport, Me.ReportFooter1})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calcTotalPayment})
			Me.DataAdapter = Me.departmentsTableAdapter1
			Me.DataMember = "Departments"
			Me.DataSource = Me.employeesDBDataSet1
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramYear, Me.paramMonth, Me.paramPaymentDate})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrPageHeaderStyle, Me.xrControlHeaderStyle, Me.xrTableHeaderStyle, Me.xrTableCellStyle})
			Me.Version = "13.2"
'			Me.ParametersRequestSubmit += New System.EventHandler(Of DevExpress.XtraReports.Parameters.ParametersRequestEventArgs)(Me.ManagementReport_ParametersRequestSubmit);
			CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private lbTitle As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private employeesDBDataSet1 As EmployeesDBDataSet
		Private paramYear As DevExpress.XtraReports.Parameters.Parameter
		Private paramMonth As DevExpress.XtraReports.Parameters.Parameter
		Private paramPaymentDate As DevExpress.XtraReports.Parameters.Parameter
		Private departmentsTableAdapter1 As DepartmentsTableAdapter
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private departmentEmployeesTableAdapter As DepartmentEmployeesTableAdapter
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrPageHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrLine2 As DevExpress.XtraReports.UI.XRLine
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private xrControlHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrTableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private xrTableCellStyle As DevExpress.XtraReports.UI.XRControlStyle
		Private calcTotalPayment As DevExpress.XtraReports.UI.CalculatedField
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrTable3 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand
		Private WithEvents xrChart1 As DevExpress.XtraReports.UI.XRChart
		Private xrLine3 As DevExpress.XtraReports.UI.XRLine
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private full_Emp_Data_QueryTableAdapter As Full_Emp_Data_QueryTableAdapter
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
	End Class
End Namespace
