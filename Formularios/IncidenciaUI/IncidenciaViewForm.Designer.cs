﻿
namespace ProyectoFinalPooJA.Formularios.IncidenciaUI
{
    partial class IncidenciaViewForm
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
            this.dgvIncidencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(383, 64);
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.Text = "Incidencia";
            // 
            // dgvIncidencia
            // 
            this.dgvIncidencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencia.Location = new System.Drawing.Point(34, 256);
            this.dgvIncidencia.Name = "dgvIncidencia";
            this.dgvIncidencia.RowHeadersWidth = 51;
            this.dgvIncidencia.RowTemplate.Height = 24;
            this.dgvIncidencia.Size = new System.Drawing.Size(922, 289);
            this.dgvIncidencia.TabIndex = 9;
            // 
            // IncidenciaViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.dgvIncidencia);
            this.Name = "IncidenciaViewForm";
            this.Text = "IncidenciaViewForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvIncidencia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencia;
    }
}