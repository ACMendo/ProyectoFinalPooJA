
namespace ProyectoFinalPooJA.Formularios.EntregaUI
{
    partial class EntregaViewForm
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
            this.dgvEntrega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).BeginInit();
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(394, 54);
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.Text = "Entrega";
            // 
            // dgvEntrega
            // 
            this.dgvEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrega.Location = new System.Drawing.Point(34, 256);
            this.dgvEntrega.Name = "dgvEntrega";
            this.dgvEntrega.RowHeadersWidth = 51;
            this.dgvEntrega.RowTemplate.Height = 24;
            this.dgvEntrega.Size = new System.Drawing.Size(922, 289);
            this.dgvEntrega.TabIndex = 9;
            this.dgvEntrega.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrega_CellClick);
            // 
            // EntregaViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.dgvEntrega);
            this.Name = "EntregaViewForm";
            this.Text = "EntregaViewForm";
            this.Load += new System.EventHandler(this.EntregaViewForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvEntrega, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntrega;
    }
}