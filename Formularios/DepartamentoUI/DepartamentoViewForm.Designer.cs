
namespace ProyectoFinalPooJA.Formularios.DepartamentoUI
{
    partial class DepartamentoViewForm
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
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(216, 64);
            this.label1.Size = new System.Drawing.Size(449, 29);
            this.label1.Text = "Mantenimiento - Departamentos";
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.Location = new System.Drawing.Point(34, 256);
            this.dgvDepartamento.Name = "dgvDepartamento";
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(922, 289);
            this.dgvDepartamento.TabIndex = 7;
            this.dgvDepartamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellClick);
            // 
            // DepartamentoViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.dgvDepartamento);
            this.Name = "DepartamentoViewForm";
            this.Text = "DepartamentoViewForm";
            this.Load += new System.EventHandler(this.DepartamentoViewForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvDepartamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartamento;
    }
}