namespace SalaryReports
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManagerMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.tileManagementReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.docManagementReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileAllEmployeeReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.docAllEmployeeReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileEmployeeReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.docEmployeeReport = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tileSettings = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.docSettings = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileManagementReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManagementReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAllEmployeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docAllEmployeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEmployeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docEmployeeReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManagerMain
            // 
            this.documentManagerMain.ContainerControl = this;
            this.documentManagerMain.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManagerMain.View = this.windowsUIView1;
            this.documentManagerMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.docEmployeeReport,
            this.docAllEmployeeReport,
            this.docManagementReport,
            this.docSettings});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileEmployeeReport,
            this.tileAllEmployeeReport,
            this.tileManagementReport,
            this.tileSettings});
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // tileContainer1
            // 
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tileManagementReport,
            this.tileAllEmployeeReport,
            this.tileEmployeeReport,
            this.tileSettings});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // tileManagementReport
            // 
            this.tileManagementReport.Document = this.docManagementReport;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Management Report";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileManagementReport.Elements.Add(tileItemElement4);
            this.tileManagementReport.Group = "GroupReports";
            this.tileManagementReport.Name = "tileManagementReport";
            this.tileManagementReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // docManagementReport
            // 
            this.docManagementReport.Caption = "Management Report";
            this.docManagementReport.ControlName = "";
            this.docManagementReport.Tag = 0;
            // 
            // tileAllEmployeeReport
            // 
            this.tileAllEmployeeReport.Document = this.docAllEmployeeReport;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement5.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileItemElement5.Text = "Report for all Employees";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileAllEmployeeReport.Elements.Add(tileItemElement5);
            this.tileAllEmployeeReport.Group = "GroupReports";
            this.tileContainer1.SetID(this.tileAllEmployeeReport, 2);
            this.tileAllEmployeeReport.Name = "tileAllEmployeeReport";
            this.tileAllEmployeeReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // docAllEmployeeReport
            // 
            this.docAllEmployeeReport.Caption = "All Employee Report";
            this.docAllEmployeeReport.ControlName = "";
            this.docAllEmployeeReport.Tag = 2;
            // 
            // tileEmployeeReport
            // 
            this.tileEmployeeReport.Document = this.docEmployeeReport;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Employee Report";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileEmployeeReport.Elements.Add(tileItemElement1);
            this.tileEmployeeReport.Group = "GroupReports";
            this.tileContainer1.SetID(this.tileEmployeeReport, 1);
            this.tileEmployeeReport.Name = "tileEmployeeReport";
            this.tileEmployeeReport.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // docEmployeeReport
            // 
            this.docEmployeeReport.Caption = "Employee Report";
            this.docEmployeeReport.ControlName = "";
            this.docEmployeeReport.Tag = 1;
            // 
            // tileSettings
            // 
            this.tileSettings.Document = this.docSettings;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Settings";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSettings.Elements.Add(tileItemElement2);
            this.tileSettings.Group = "GroupSettings";
            this.tileContainer1.SetID(this.tileSettings, 3);
            this.tileSettings.Name = "tileSettings";
            this.tileSettings.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // docSettings
            // 
            this.docSettings.Caption = "Settings";
            this.docSettings.ControlName = "";
            this.docSettings.Tag = 3;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 547);
            this.Name = "MainForm";
            this.Text = "Salary Reports Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.documentManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileManagementReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManagementReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileAllEmployeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docAllEmployeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileEmployeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docEmployeeReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManagerMain;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tileManagementReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tileAllEmployeeReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tileEmployeeReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tileSettings;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docEmployeeReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docAllEmployeeReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docManagementReport;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docSettings;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;


    }
}