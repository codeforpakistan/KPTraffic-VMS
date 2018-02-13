namespace VMS.Reports
{
    partial class frmReportVisitsByVisitor
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGen = new DevComponents.DotNetBar.ButtonX();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_GetVisitsCountByVisitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVisManDataSet1 = new VMS.dbVisManDataSet1();
            this.usp_GetVisitsCountByVisitorTableAdapter = new VMS.dbVisManDataSet1TableAdapters.usp_GetVisitsCountByVisitorTableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitsCountByVisitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.reportViewer1);
            this.panelEx1.Controls.Add(this.btnGen);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.dtpTo);
            this.panelEx1.Controls.Add(this.dtpFrom);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(879, 517);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(71, 48);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(140, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2017, 12, 25, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(385, 48);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(129, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // btnGen
            // 
            this.btnGen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGen.Location = new System.Drawing.Point(658, 44);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(81, 24);
            this.btnGen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Generate";
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_GetVisitsCountByVisitorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMS.Rdlcs.ReportNoofVisitsByVisitor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(875, 422);
            this.reportViewer1.TabIndex = 5;
            // 
            // usp_GetVisitsCountByVisitorBindingSource
            // 
            this.usp_GetVisitsCountByVisitorBindingSource.DataMember = "usp_GetVisitsCountByVisitor";
            this.usp_GetVisitsCountByVisitorBindingSource.DataSource = this.dbVisManDataSet1;
            // 
            // dbVisManDataSet1
            // 
            this.dbVisManDataSet1.DataSetName = "dbVisManDataSet1";
            this.dbVisManDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_GetVisitsCountByVisitorTableAdapter
            // 
            this.usp_GetVisitsCountByVisitorTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportVisitsByVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 517);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmReportVisitsByVisitor";
            this.Text = "Report No. Visits By Visitor";
            this.Load += new System.EventHandler(this.frmReportVisitsByVisitor_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usp_GetVisitsCountByVisitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVisManDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnGen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbVisManDataSet1 dbVisManDataSet1;
        private dbVisManDataSet1TableAdapters.usp_GetVisitsCountByVisitorTableAdapter usp_GetVisitsCountByVisitorTableAdapter;
        private System.Windows.Forms.BindingSource usp_GetVisitsCountByVisitorBindingSource;
    }
}