using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ProyectoFinalPooJA.Formularios;

namespace ProyectoFinalPooJA.Formularios.MenuPrincipal
{
    public partial class MenuPrincipalForm : Form
    {
        private int BorderSize = 2;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public MenuPrincipalForm()
        {
            InitializeComponent();
            customizedDesing();
            CollapseMenu();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuPrincipal.Controls.Add(leftBorderBtn);
            this.Padding = new Padding(BorderSize);
            this.BackColor = Color.FromArgb(0, 0, 192);
            this.Text = string.Empty;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void customizedDesing() 
        {
            panelSubMenuMantenimiento.Visible = false;
           // panelSubMenuReporte.Visible = false;

        }

        private void hideSubMenu() 
        {
            if (panelSubMenuMantenimiento.Visible == true) 
                panelSubMenuMantenimiento.Visible = false;
            //if (panelSubMenuReporte.Visible == true)
            //    panelSubMenuReporte.Visible = false;

        }

        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        //Drap Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTituloMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != BorderSize)
                        this.Padding = new Padding(BorderSize);
                    break;
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();

        }
        private void CollapseMenu()
        {
            if (this.panelMenuPrincipal.Width > 200)
            {
                
                panelMenuPrincipal.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;

                foreach (Button menuBtn in panelMenuPrincipal.Controls.OfType<Button>())
                {
                    menuBtn.Text = "";
                    customizedDesing();
                    menuBtn.ImageAlign = ContentAlignment.MiddleCenter;
                    menuBtn.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenuPrincipal.Width = 262;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;

                foreach (Button menuBtn in panelMenuPrincipal.Controls.OfType<Button>())
                {
                    menuBtn.Text = "  " + menuBtn.Tag.ToString();
                    menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
                    menuBtn.Padding = new Padding(10, 0, 0, 0);
                }

            }

        }

        private struct RBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(235, 102, 66);
            public static Color color5 = Color.FromArgb(249, 88, 155);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.Padding = new Padding(0, 0, 10, 0);
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconFormActual.IconChar = currentBtn.IconChar;
                iconFormActual.IconColor = color;
                lblTituloActual.Text = currentBtn.Tag.ToString();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 5, 212);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.Padding = new Padding(10, 0, 0, 0);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;


            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBColors.color1);
        }

        private void iconMantenimiento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBColors.color2);
            showSubMenu(panelSubMenuMantenimiento);
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBColors.color3);
        }

        private void btnIncidencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBColors.color4);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBColors.color5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset() 
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconFormActual.IconChar = IconChar.Home;
            iconFormActual.IconColor = Color.White;
            lblTituloActual.Text = "Inicio";

        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea salir del sistema?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) 
            {
                Application.Exit();

            }
        }

        private void fntimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnEntrega_Click_1(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RBColors.color3);
            hideSubMenu();
        }

        private void btnIncidencia_Click_1(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RBColors.color4);
            hideSubMenu();

        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {

            openSubMenuForm(new ReportesUI.ReporteEntregas());

        }
        public void openSubMenuForm(object formSM)
        {
            if (panelDesktop.Controls.Count > 0)
                this.pictureDesktop.Visible = false;

            else
                this.panelDesktop.Visible = true;

            Form childForm = formSM as Form;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.Show();

        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            openSubMenuForm(new CargoUI.CargoViewForm());
        }

        private void datetimeFn_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openSubMenuForm(new ClienteUI.ClienteViewForm());
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            openSubMenuForm(new ColorUI.ColorViewForm());
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            openSubMenuForm(new DepartamentoUI.DepartamentoViewForm());

        }
    }
}
