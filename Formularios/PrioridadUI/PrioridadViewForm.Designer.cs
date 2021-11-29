
namespace ProyectoFinalPooJA.Formularios.PrioridadUI
{
    partial class PrioridadViewForm
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
            this.dgvPrioridad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(237, 64);
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.Text = "Mantenimiento - Prioridades";
            // 
            // dgvPrioridad
            // 
            this.dgvPrioridad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrioridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrioridad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrioridad.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrioridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrioridad.Location = new System.Drawing.Point(34, 256);
            this.dgvPrioridad.Name = "dgvPrioridad";
            this.dgvPrioridad.RowHeadersWidth = 51;
            this.dgvPrioridad.RowTemplate.Height = 24;
            this.dgvPrioridad.Size = new System.Drawing.Size(922, 289);
            this.dgvPrioridad.TabIndex = 8;
            this.dgvPrioridad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrioridad_CellClick);
            // 
            // PrioridadViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.dgvPrioridad);
            this.Name = "PrioridadViewForm";
            this.Text = "PrioridadViewForm";
            this.Load += new System.EventHandler(this.PrioridadViewForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvPrioridad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrioridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrioridad;
    }
}