namespace VMS.Reports
{
    partial class frmReportDateWise
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspGetVisitorDetailsBwDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVisManDataSet = new VMS.dbVisManDataSet();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnGo = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_GetVisitorDetailsBwDatesTableAdapter = new VMS.dbVisManDataSetTableAdapters.usp_GetVisitorDetailsBwDatesTableAdapter();
            this.usp_GetVisitorDetailsBwDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorDetailsBwDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitorDetailsBwDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uspGetVisitorDetailsBwDatesBindingSource
            // 
            this.uspGetVisitorDetailsBwDatesBindingSource.DataMember = "usp_GetVisitorDetailsBwDates";
            this.uspGetVisitorDetailsBwDatesBindingSource.DataSource = this.dbVisManDataSet;
            // 
            // dbVisManDataSet
            // 
            this.dbVisManDataSet.DataSetName = "dbVisManDataSet";
            this.dbVisManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnGo);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.dtpTo);
            this.panelEx1.Controls.Add(this.dtpFrom);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(929, 520);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGo.Location = new System.Drawing.Point(707, 17);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 32);
            this.btnGo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(431, 6);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "To";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(165, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "From";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy/MM/dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(431, 32);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy/MM/dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(165, 32);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.usp_GetVisitorDetailsBwDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMS.Rdlcs.ReportDateWiseDaily.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(929, 452);
            this.reportViewer1.TabIndex = 1;
            // 
            // usp_GetVisitorDetailsBwDatesTableAdapter
            // 
            this.usp_GetVisitorDetailsBwDatesTableAdapter.ClearBeforeFill = true;
            // 
            // usp_GetVisitorDetailsBwDatesBindingSource
            // 
            this.usp_GetVisitorDetailsBwDatesBindingSource.DataMember = "usp_GetVisitorDetailsBwDates";
            this.usp_GetVisitorDetailsBwDatesBindingSource.DataSource = this.dbVisManDataSet;
            // 
            // frmReportDateWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmReportDateWise";
            this.Text = "Report Date Wise";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDateWise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorDetailsBwDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitorDetailsBwDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevComponents.DotNetBar.ButtonX btnGo;
        private System.Windows.Forms.BindingSource uspGetVisitorDetailsBwDatesBindingSource;
        private dbVisManDataSet dbVisManDataSet;
        private dbVisManDataSetTableAdapters.usp_GetVisitorDetailsBwDatesTableAdapter usp_GetVisitorDetailsBwDatesTableAdapter;
        private System.Windows.Forms.BindingSource usp_GetVisitorDetailsBwDatesBindingSource;
    }
}