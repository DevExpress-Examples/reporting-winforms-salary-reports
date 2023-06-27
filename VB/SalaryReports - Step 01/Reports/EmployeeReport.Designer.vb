Imports Microsoft.VisualBasic
Imports System
Imports SalaryReports.Data
Imports SalaryReports.Data.EmployeesDBDataSetTableAdapters
Imports EmployeesDBDataSetTableAdapters

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
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.employeesDBDataSet1 = New EmployeesDBDataSet()
            Me.full_Emp_Data_QueryTableAdapter = New EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter()
            CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 99.87501F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
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
            ' EmployeeReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.DataAdapter = Me.full_Emp_Data_QueryTableAdapter
            Me.DataMember = "Full Emp Data Query"
            Me.DataSource = Me.employeesDBDataSet1
            Me.Version = "13.2"
            CType(Me.employeesDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

#End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private employeesDBDataSet1 As EmployeesDBDataSet
        Private full_Emp_Data_QueryTableAdapter As EmployeesDBDataSetTableAdapters.Full_Emp_Data_QueryTableAdapter
    End Class
End Namespace
