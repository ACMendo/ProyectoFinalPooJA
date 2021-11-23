
namespace ProyectoFinalPooJA.Formularios.General
{
    partial class GeneralSearchForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(34, 247);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(922, 294);
            this.dataGrid.TabIndex = 0;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.textBox1);
            this.gbBusqueda.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(34, 140);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(554, 91);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(366, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 46);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = " Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 28);
            this.textBox1.TabIndex = 2;
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
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(752, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(26, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = " Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Green;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAñadir.IconColor = System.Drawing.Color.White;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 30;
            this.btnAñadir.Location = new System.Drawing.Point(26, 40);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(153, 46);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.Text = " Añadir";
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 30;
            this.btnEditar.Location = new System.Drawing.Point(26, 92);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(153, 46);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = " Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // GeneralSearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSearchForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Búsqueda General";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        public FontAwesome.Sharp.IconButton btnAñadir;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnEliminar;
        public FontAwesome.Sharp.IconButton btnEditar;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGrid;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}