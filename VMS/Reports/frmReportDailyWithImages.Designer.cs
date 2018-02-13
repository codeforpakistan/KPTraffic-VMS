namespace VMS.Reports
{
    partial class frmReportDailyWithImages
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVisitorDetailWithImages = new VMS.dsVisitorDetailWithImages();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnGo = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspGetVisitorDetailsWithImagesBwDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter = new VMS.dsVisitorDetailWithImagesTableAdapters.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVisitorDetailWithImages)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorDetailsWithImagesBwDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_GetVisitorDetailsWithImagesBwDatesBindingSource
            // 
            this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource.DataMember = "usp_GetVisitorDetailsWithImagesBwDates";
            this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource.DataSource = this.dsVisitorDetailWithImages;
            // 
            // dsVisitorDetailWithImages
            // 
            this.dsVisitorDetailWithImages.DataSetName = "dsVisitorDetailWithImages";
            this.dsVisitorDetailWithImages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(890, 65);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGo.Location = new System.Drawing.Point(665, 22);
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
            this.labelX2.Location = new System.Drawing.Point(389, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "To";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(123, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(389, 29);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(123, 30);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMS.Rdlcs.ReportDailyWithImages.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(890, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // uspGetVisitorDetailsWithImagesBwDatesBindingSource
            // 
            this.uspGetVisitorDetailsWithImagesBwDatesBindingSource.DataMember = "usp_GetVisitorDetailsWithImagesBwDates";
            this.uspGetVisitorDetailsWithImagesBwDatesBindingSource.DataSource = this.dsVisitorDetailWithImages;
            // 
            // usp_GetVisitorDetailsWithImagesBwDatesTableAdapter
            // 
            this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportDailyWithImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmReportDailyWithImages";
            this.Text = "Report Daily With Images";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDailyWithImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVisitorDetailWithImages)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorDetailsWithImagesBwDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnGo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_GetVisitorDetailsWithImagesBwDatesBindingSource;
        private dsVisitorDetailWithImages dsVisitorDetailWithImages;
        private System.Windows.Forms.BindingSource uspGetVisitorDetailsWithImagesBwDatesBindingSource;
        private dsVisitorDetailWithImagesTableAdapters.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter usp_GetVisitorDetailsWithImagesBwDatesTableAdapter;
    }
}