using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPanel.ReleaseCapture();
            MoverPanel.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard verpanel = new Dashboard();
            verpanel.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminMensajes verpanel = new AdminMensajes();
            verpanel.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes verPanel = new Reportes();
            verPanel.ShowDialog();
        }
    }
}
