
namespace ProyectoFinalPooJA.Formularios.VehiculoUI
{
    partial class VehiculoActualizarForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.gbVehiculo = new System.Windows.Forms.GroupBox();
            this.cbxTipo_Vehiculo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCombustible = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTransmision = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAdicional = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.checkMantenimiento = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gbVehiculo.SuspendLayout();
            this.gbAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.gbVehiculo);
            this.panel2.Controls.Add(this.gbAdicional);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 648);
            this.panel2.TabIndex = 24;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 30;
            this.btnEditar.Location = new System.Drawing.Point(679, 567);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 47);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = " Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.Location = new System.Drawing.Point(517, 567);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 47);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = " Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(356, 567);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 47);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = " Cancelar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbVehiculo
            // 
            this.gbVehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVehiculo.Controls.Add(this.cbxTipo_Vehiculo);
            this.gbVehiculo.Controls.Add(this.label7);
            this.gbVehiculo.Controls.Add(this.label3);
            this.gbVehiculo.Controls.Add(this.cbxColor);
            this.gbVehiculo.Controls.Add(this.label4);
            this.gbVehiculo.Controls.Add(this.cbxModelo);
            this.gbVehiculo.Controls.Add(this.label2);
            this.gbVehiculo.Controls.Add(this.cbxCombustible);
            this.gbVehiculo.Controls.Add(this.txtPlaca);
            this.gbVehiculo.Controls.Add(this.label1);
            this.gbVehiculo.Controls.Add(this.label5);
            this.gbVehiculo.Controls.Add(this.cbxTransmision);
            this.gbVehiculo.Controls.Add(this.txtAno);
            this.gbVehiculo.Controls.Add(this.label6);
            this.gbVehiculo.Controls.Add(this.txtChasis);
            this.gbVehiculo.Controls.Add(this.label8);
            this.gbVehiculo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbVehiculo.ForeColor = System.Drawing.Color.Green;
            this.gbVehiculo.Location = new System.Drawing.Point(37, 100);
            this.gbVehiculo.Name = "gbVehiculo";
            this.gbVehiculo.Size = new System.Drawing.Size(784, 290);
            this.gbVehiculo.TabIndex = 36;
            this.gbVehiculo.TabStop = false;
            this.gbVehiculo.Text = "Vehículo";
            // 
            // cbxTipo_Vehiculo
            // 
            this.cbxTipo_Vehiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipo_Vehiculo.FormattingEnabled = true;
            this.cbxTipo_Vehiculo.Items.AddRange(new object[] {
            "Cédula",
            "RNC"});
            this.cbxTipo_Vehiculo.Location = new System.Drawing.Point(201, 216);
            this.cbxTipo_Vehiculo.Name = "cbxTipo_Vehiculo";
            this.cbxTipo_Vehiculo.Size = new System.Drawing.Size(252, 28);
            this.cbxTipo_Vehiculo.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(27, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Tipo de Vehículo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(394, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Color";
            // 
            // cbxColor
            // 
            this.cbxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Cédula",
            "RNC"});
            this.cbxColor.Location = new System.Drawing.Point(482, 106);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(275, 28);
            this.cbxColor.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Modelo";
            // 
            // cbxModelo
            // 
            this.cbxModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Items.AddRange(new object[] {
            "Cédula",
            "RNC"});
            this.cbxModelo.Location = new System.Drawing.Point(128, 106);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(239, 28);
            this.cbxModelo.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(394, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Combustible";
            // 
            // cbxCombustible
            // 
            this.cbxCombustible.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCombustible.FormattingEnabled = true;
            this.cbxCombustible.Items.AddRange(new object[] {
            "Disel",
            "Gasolina"});
            this.cbxCombustible.Location = new System.Drawing.Point(549, 162);
            this.cbxCombustible.Name = "cbxCombustible";
            this.cbxCombustible.Size = new System.Drawing.Size(208, 28);
            this.cbxCombustible.TabIndex = 74;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPlaca.Location = new System.Drawing.Point(482, 46);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(273, 28);
            this.txtPlaca.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(395, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Placa";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Transmisión";
            // 
            // cbxTransmision
            // 
            this.cbxTransmision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTransmision.FormattingEnabled = true;
            this.cbxTransmision.Items.AddRange(new object[] {
            "Manual",
            "Automática",
            "Mixta"});
            this.cbxTransmision.Location = new System.Drawing.Point(159, 162);
            this.cbxTransmision.Name = "cbxTransmision";
            this.cbxTransmision.Size = new System.Drawing.Size(208, 28);
            this.cbxTransmision.TabIndex = 70;
            // 
            // txtAno
            // 
            this.txtAno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAno.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAno.Location = new System.Drawing.Point(549, 213);
            this.txtAno.Multiline = true;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(208, 28);
            this.txtAno.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(476, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Año";
            // 
            // txtChasis
            // 
            this.txtChasis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChasis.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtChasis.Location = new System.Drawing.Point(128, 46);
            this.txtChasis.Multiline = true;
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(237, 28);
            this.txtChasis.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Chasis";
            // 
            // gbAdicional
            // 
            this.gbAdicional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAdicional.Controls.Add(this.label10);
            this.gbAdicional.Controls.Add(this.cbxEmpleado);
            this.gbAdicional.Controls.Add(this.checkMantenimiento);
            this.gbAdicional.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbAdicional.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbAdicional.Location = new System.Drawing.Point(37, 431);
            this.gbAdicional.Name = "gbAdicional";
            this.gbAdicional.Size = new System.Drawing.Size(784, 87);
            this.gbAdicional.TabIndex = 35;
            this.gbAdicional.TabStop = false;
            this.gbAdicional.Text = "Información Adicional";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Empleado";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Items.AddRange(new object[] {
            "Cédula",
            "RNC"});
            this.cbxEmpleado.Location = new System.Drawing.Point(154, 41);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(298, 28);
            this.cbxEmpleado.TabIndex = 36;
            // 
            // checkMantenimiento
            // 
            this.checkMantenimiento.AutoSize = true;
            this.checkMantenimiento.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkMantenimiento.ForeColor = System.Drawing.Color.Black;
            this.checkMantenimiento.Location = new System.Drawing.Point(522, 43);
            this.checkMantenimiento.Name = "checkMantenimiento";
            this.checkMantenimiento.Size = new System.Drawing.Size(174, 24);
            this.checkMantenimiento.TabIndex = 35;
            this.checkMantenimiento.Text = "Mantenimiento";
            this.checkMantenimiento.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(354, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Formulario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VehiculoActualizarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 648);
            this.Controls.Add(this.panel2);
            this.Name = "VehiculoActualizarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículo - Actualizar";
            this.Load += new System.EventHandler(this.VehiculoActualizarForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbVehiculo.ResumeLayout(false);
            this.gbVehiculo.PerformLayout();
            this.gbAdicional.ResumeLayout(false);
            this.gbAdicional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbVehiculo;
        private System.Windows.Forms.ComboBox cbxTipo_Vehiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCombustible;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTransmision;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbAdicional;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.CheckBox checkMantenimiento;
        public System.Windows.Forms.Label label9;
        public FontAwesome.Sharp.IconButton btnEditar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        public FontAwesome.Sharp.IconButton btnSalir;
    }
}