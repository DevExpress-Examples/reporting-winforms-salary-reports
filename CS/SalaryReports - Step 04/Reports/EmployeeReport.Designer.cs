using SalaryReports.Data;
using SalaryReports.Data.EmployeesDBDataSetTableAdapters;
namespace SalaryReports
{
    partial class EmployeeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.employeesDBDataSet1 = new SalaryReports.Data.EmployeesDBDataSet();
            this.full_Emp_Data_QueryTableAdapter = new SalaryReports.Data.EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.totalPayment = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrPageHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrTableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrTableCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.overtimeFormattingRule = new DevExpress.XtraReports.UI.FormattingRule();
            this.sickDaysFormattingRule = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrTable2,
            this.xrLabel2,
            this.xrLabel1,
            this.xrTable1});
            this.Detail.HeightF = 347.7917F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.totalPayment", "Total payment: {0:c2}")});
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(250.0001F, 305.1667F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(399.9999F, 42.625F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Total payment:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-05F, 208.8333F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow6});
            this.xrTable2.SizeF = new System.Drawing.SizeF(649.9999F, 75F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StyleName = "xrTableHeaderStyle";
            this.xrTableCell7.Text = "Base salary:";
            this.xrTableCell7.Weight = 1.1538462856676575D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.PositionSalary", "{0:c2}")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StyleName = "xrTableCellStyle";
            this.xrTableCell8.Text = "xrTableCell2";
            this.xrTableCell8.Weight = 1.8461537143323425D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StyleName = "xrTableHeaderStyle";
            this.xrTableCell9.Text = "Sick days:";
            this.xrTableCell9.Weight = 1.1538462856676575D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xrTableCell10.BorderColor = System.Drawing.Color.White;
            this.xrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.SickDays")});
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StyleName = "xrTableCellStyle";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.Text = "xrTableCell4";
            this.xrTableCell10.Weight = 1.8461537143323425D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StyleName = "xrTableHeaderStyle";
            this.xrTableCell11.Text = "Overtime (days):";
            this.xrTableCell11.Weight = 1.1538462856676575D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.Overtime")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StyleName = "xrTableCellStyle";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.Text = "xrTableCell6";
            this.xrTableCell12.Weight = 1.8461537143323425D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.PaymentDate", "Employee statistics in {0:MMMM, yyyy}")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-05F, 166.5F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(450.4167F, 30F);
            this.xrLabel2.StyleName = "xrControlHeaderStyle";
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(290F, 30F);
            this.xrLabel1.StyleName = "xrControlHeaderStyle";
            this.xrLabel1.Text = "Employee Information:";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-05F, 51.04167F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow7});
            this.xrTable1.SizeF = new System.Drawing.SizeF(649.9999F, 100F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StyleName = "xrTableHeaderStyle";
            this.xrTableCell1.Text = "Full name:";
            this.xrTableCell1.Weight = 1.1538462856676575D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.EmployeeName")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StyleName = "xrTableCellStyle";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1.8461537143323425D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StyleName = "xrTableHeaderStyle";
            this.xrTableCell3.Text = "Email address:";
            this.xrTableCell3.Weight = 1.1538462856676575D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.Email")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StyleName = "xrTableCellStyle";
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.Weight = 1.8461537143323425D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StyleName = "xrTableHeaderStyle";
            this.xrTableCell5.Text = "Department:";
            this.xrTableCell5.Weight = 1.1538462856676575D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.DepartmentName")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StyleName = "xrTableCellStyle";
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.Weight = 1.8461537143323425D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StyleName = "xrTableHeaderStyle";
            this.xrTableCell13.Text = "Position:";
            this.xrTableCell13.Weight = 1.1538462856676575D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Full Emp Data Query.PositionName")});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StyleName = "xrTableCellStyle";
            this.xrTableCell14.Text = "xrTableCell14";
            this.xrTableCell14.Weight = 1.8461537143323425D;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // employeesDBDataSet1
            // 
            this.employeesDBDataSet1.DataSetName = "EmployeesDBDataSet";
            this.employeesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // full_Emp_Data_QueryTableAdapter
            // 
            this.full_Emp_Data_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lbTitle,
            this.xrPageInfo2});
            this.PageHeader.HeightF = 47.99997F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StyleName = "xrPageHeaderStyle";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 38.99997F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLine1.SizeF = new System.Drawing.SizeF(650F, 9F);
            // 
            // lbTitle
            // 
            this.lbTitle.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTitle.SizeF = new System.Drawing.SizeF(284.875F, 38F);
            this.lbTitle.StylePriority.UseFont = false;
            this.lbTitle.StylePriority.UseForeColor = false;
            this.lbTitle.StylePriority.UseTextAlignment = false;
            this.lbTitle.Text = "Employee Salary Report";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "{0:\"Current Date: \" dddd, dd MMMM yyyy}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(358F, 15.99998F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(292F, 23F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            // 
            // totalPayment
            // 
            this.totalPayment.DataMember = "Full Emp Data Query";
            this.totalPayment.Expression = "[PositionSalary] + (([PositionSalary] * [Overtime]) / 22)";
            this.totalPayment.FieldType = DevExpress.XtraReports.UI.FieldType.Float;
            this.totalPayment.Name = "totalPayment";
            // 
            // xrPageHeaderStyle
            // 
            this.xrPageHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrPageHeaderStyle.Name = "xrPageHeaderStyle";
            this.xrPageHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableHeaderStyle
            // 
            this.xrTableHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(132)))), ((int)(((byte)(213)))));
            this.xrTableHeaderStyle.BorderColor = System.Drawing.Color.White;
            this.xrTableHeaderStyle.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableHeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrTableHeaderStyle.ForeColor = System.Drawing.Color.White;
            this.xrTableHeaderStyle.Name = "xrTableHeaderStyle";
            this.xrTableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableCellStyle
            // 
            this.xrTableCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrTableCellStyle.Name = "xrTableCellStyle";
            this.xrTableCellStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100F);
            this.xrTableCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrControlHeaderStyle
            // 
            this.xrControlHeaderStyle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.xrControlHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.xrControlHeaderStyle.Name = "xrControlHeaderStyle";
            this.xrControlHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // overtimeFormattingRule
            // 
            this.overtimeFormattingRule.Condition = "[Overtime] > 0";
            // 
            // 
            // 
            this.overtimeFormattingRule.Formatting.BackColor = System.Drawing.Color.Pink;
            this.overtimeFormattingRule.Name = "overtimeFormattingRule";
            // 
            // sickDaysFormattingRule
            // 
            this.sickDaysFormattingRule.Condition = "[SickDays] > 0";
            // 
            // 
            // 
            this.sickDaysFormattingRule.Formatting.BackColor = System.Drawing.Color.Pink;
            this.sickDaysFormattingRule.Name = "sickDaysFormattingRule";
            // 
            // EmployeeReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.totalPayment});
            this.DataAdapter = this.full_Emp_Data_QueryTableAdapter;
            this.DataMember = "Full Emp Data Query";
            this.DataSource = this.employeesDBDataSet1;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.sickDaysFormattingRule,
            this.overtimeFormattingRule});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrPageHeaderStyle,
            this.xrTableHeaderStyle,
            this.xrTableCellStyle,
            this.xrControlHeaderStyle});
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private EmployeesDBDataSet employeesDBDataSet1;
        private Full_Emp_Data_QueryTableAdapter full_Emp_Data_QueryTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel lbTitle;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.CalculatedField totalPayment;
        private DevExpress.XtraReports.UI.XRControlStyle xrPageHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle xrTableHeaderStyle;
        private DevExpress.XtraReports.UI.XRControlStyle xrTableCellStyle;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlHeaderStyle;
        private DevExpress.XtraReports.UI.FormattingRule overtimeFormattingRule;
        private DevExpress.XtraReports.UI.FormattingRule sickDaysFormattingRule;
    }
}
