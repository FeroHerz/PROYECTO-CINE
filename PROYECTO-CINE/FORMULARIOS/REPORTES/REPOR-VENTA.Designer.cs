namespace PROYECTO_CINE.FORMULARIOS.REPORTES
{
    partial class Reporte_de_ventas
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
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cINEDataSet2 = new PROYECTO_CINE.CINEDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reservasTableAdapter = new PROYECTO_CINE.CINEDataSet2TableAdapters.ReservasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.reservasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.cINEDataSet2;
            // 
            // cINEDataSet2
            // 
            this.cINEDataSet2.DataSetName = "CINEDataSet2";
            this.cINEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reservasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_CINE.FORMULARIOS.REPORTES.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 692);
            this.reportViewer1.TabIndex = 0;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1030, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservasBindingSource1
            // 
            this.reservasBindingSource1.DataMember = "Reservas";
            this.reservasBindingSource1.DataSource = this.cINEDataSet2;
            // 
            // Reporte_de_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reporte_de_ventas";
            this.Text = "Reporte_de_ventas";
            this.Load += new System.EventHandler(this.Reporte_de_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cINEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CINEDataSet2 cINEDataSet2;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private CINEDataSet2TableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource reservasBindingSource1;
    }
}