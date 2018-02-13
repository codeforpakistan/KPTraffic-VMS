namespace VMS.Reports
{
    partial class frmReportCheckOutWithBadges
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnGo = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbVisManDataSet3 = new VMS.dbVisManDataSet3();
            this.uspGetVisitorsCheckOutWithBadgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_GetVisitorsCheckOutWithBadgeTableAdapter = new VMS.dbVisManDataSet3TableAdapters.usp_GetVisitorsCheckOutWithBadgeTableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorsCheckOutWithBadgeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.panelEx1.Size = new System.Drawing.Size(770, 65);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGo.Location = new System.Drawing.Point(663, 18);
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
            reportDataSource1.Value = this.uspGetVisitorsCheckOutWithBadgeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMS.Rdlcs.ReportChkOutWithBadge.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(770, 437);
            this.reportViewer1.TabIndex = 3;
            // 
            // dbVisManDataSet3
            // 
            this.dbVisManDataSet3.DataSetName = "dbVisManDataSet3";
            this.dbVisManDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspGetVisitorsCheckOutWithBadgeBindingSource
            // 
            this.uspGetVisitorsCheckOutWithBadgeBindingSource.DataMember = "usp_GetVisitorsCheckOutWithBadge";
            this.uspGetVisitorsCheckOutWithBadgeBindingSource.DataSource = this.dbVisManDataSet3;
            // 
            // usp_GetVisitorsCheckOutWithBadgeTableAdapter
            // 
            this.usp_GetVisitorsCheckOutWithBadgeTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportCheckOutWithBadges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 497);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmReportCheckOutWithBadges";
            this.Text = "ReportCheckOutWithBadges";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspGetVisitorsCheckOutWithBadgeBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource uspGetVisitorsCheckOutWithBadgeBindingSource;
        private dbVisManDataSet3 dbVisManDataSet3;
        private dbVisManDataSet3TableAdapters.usp_GetVisitorsCheckOutWithBadgeTableAdapter usp_GetVisitorsCheckOutWithBadgeTableAdapter;
    }
}