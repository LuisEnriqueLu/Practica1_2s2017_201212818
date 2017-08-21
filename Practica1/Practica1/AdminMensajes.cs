using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class AdminMensajes : Form
    {       
        public AdminMensajes()
        {
            InitializeComponent();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPanel.ReleaseCapture();
            MoverPanel.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarMensajes verForm = new EnviarMensajes();
            verForm.ShowDialog();
        }
        
        private void btnCola_Click(object sender, EventArgs e)
        {
            ColaMensajes verPanel = new ColaMensajes();
            verPanel.ShowDialog();            
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            RespuestasMensajes verPanel = new RespuestasMensajes();
            verPanel.ShowDialog();
        }        
    }
}
