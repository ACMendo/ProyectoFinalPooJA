
namespace ProyectoFinalPooJA.Formularios.ReportesUI
{
    partial class ReporteEntregas
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
            this.dgvEntregasReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnActualizarDatosReporte = new FontAwesome.Sharp.IconButton();
            this.btnExcelData = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntregasReport
            // 
            this.dgvEntregasReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntregasReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntregasReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasReport.Location = new System.Drawing.Point(27, 248);
            this.dgvEntregasReport.Name = "dgvEntregasReport";
            this.dgvEntregasReport.RowHeadersWidth = 51;
            this.dgvEntregasReport.RowTemplate.Height = 24;
            this.dgvEntregasReport.Size = new System.Drawing.Size(945, 150);
            this.dgvEntregasReport.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(386, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Datos Entrega";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Registros:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(217, 506);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(40, 25);
            this.lblTotalRegistros.TabIndex = 19;
            this.lblTotalRegistros.Text = "    ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 42);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizarDatosReporte
            // 
            this.btnActualizarDatosReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarDatosReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarDatosReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarDatosReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarDatosReporte.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDatosReporte.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDatosReporte.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnActualizarDatosReporte.IconColor = System.Drawing.Color.White;
            this.btnActualizarDatosReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarDatosReporte.IconSize = 30;
            this.btnActualizarDatosReporte.Location = new System.Drawing.Point(391, 149);
            this.btnActualizarDatosReporte.Name = "btnActualizarDatosReporte";
            this.btnActualizarDatosReporte.Size = new System.Drawing.Size(196, 54);
            this.btnActualizarDatosReporte.TabIndex = 22;
            this.btnActualizarDatosReporte.Text = " Actualizar Datos";
            this.btnActualizarDatosReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarDatosReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizarDatosReporte.UseVisualStyleBackColor = false;
            this.btnActualizarDatosReporte.Click += new System.EventHandler(this.btnActualizarDatosReporte_Click);
            // 
            // btnExcelData
            // 
            this.btnExcelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelData.BackColor = System.Drawing.Color.Green;
            this.btnExcelData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcelData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelData.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelData.ForeColor = System.Drawing.Color.White;
            this.btnExcelData.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnExcelData.IconColor = System.Drawing.Color.White;
            this.btnExcelData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcelData.IconSize = 30;
            this.btnExcelData.Location = new System.Drawing.Point(776, 494);
            this.btnExcelData.Name = "btnExcelData";
            this.btnExcelData.Size = new System.Drawing.Size(196, 54);
            this.btnExcelData.TabIndex = 23;
            this.btnExcelData.Text = " Exportar Excel";
            this.btnExcelData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcelData.UseVisualStyleBackColor = false;
            this.btnExcelData.Click += new System.EventHandler(this.btnExcelData_Click);
            // 
            // ReporteEntregas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.btnExcelData);
            this.Controls.Add(this.btnActualizarDatosReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEntregasReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteEntregas";
            this.Text = "ReporteEntregas";
            this.Load += new System.EventHandler(this.ReporteEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEntregasReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRegistros;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnActualizarDatosReporte;
        private FontAwesome.Sharp.IconButton btnExcelData;
    }
}