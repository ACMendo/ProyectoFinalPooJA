
namespace ProyectoFinalPooJA.Formularios.MenuPrincipal
{
    partial class Inicio
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
            this.pictureDesktop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDesktop
            // 
            this.pictureDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureDesktop.BackColor = System.Drawing.Color.Transparent;
            this.pictureDesktop.Image = global::ProyectoFinalPooJA.Properties.Resources.Logo_Principal;
            this.pictureDesktop.Location = new System.Drawing.Point(219, 176);
            this.pictureDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureDesktop.Name = "pictureDesktop";
            this.pictureDesktop.Size = new System.Drawing.Size(645, 283);
            this.pictureDesktop.TabIndex = 10;
            this.pictureDesktop.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(999, 572);
            this.Controls.Add(this.pictureDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureDesktop;
    }
}