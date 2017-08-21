using System;
using System.Collections.Generic;
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
    public partial class EnviarMensajes : Form
    {
        public static List<NodoCola> listaCola;
        static int contadorNodosCola;
        public EnviarMensajes()
        {
            InitializeComponent();
        }

        private void btnEnviarM_Click(object sender, EventArgs e)
        {
            enviarMensajes_A_Mano();
            ConsultarCola();
            txtMensaje.Text = "";
            txtIP.Text = "";            
        }

        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            AbrirArchivoXML();
            enviarMensajes();
            ConsultarCola();
        }

        public void AbrirArchivoXML()
        {
            listaCola = new List<NodoCola>();
            contadorNodosCola = 1;

            opd.Filter = "Arhivos de Texto(*.txt) | *.txt";
            opd.InitialDirectory = "Escritorio";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Analizador.AnalizarXML(File.ReadAllText(opd.FileName));
            }
            else
            {
                MessageBox.Show("Hubo un Error al Abrir el Archivo", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AgregarDatosCola(string ip, string mensaje)
        {
            NodoCola nodo = new NodoCola();
            nodo.ip = ip;
            nodo.mensaje = mensaje;

            if (mensaje != "")
            {
                foreach (var cola in listaCola)
                {
                    if (cola.mensaje == "")
                    {
                        cola.mensaje = mensaje;
                    }
                }
            }
            else
            {
                listaCola.Add(nodo);
                contadorNodosCola++;
            }
        }

        public void ConsultarCola()
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://" + Globales.ipCambiar + ":5000/consultarCola");
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void enviarMensajes()
        {
            try
            {
                foreach (var nod in listaCola)
                {
                    using (var cliente = new WebClient())
                    {
                        var variablesEnviar = new NameValueCollection();
                        variablesEnviar["inorden"] = nod.mensaje;

                        var respuestaMetodo = cliente.UploadValues("http://" + nod.ip + ":5000/mensaje", variablesEnviar);
                        var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                        Console.WriteLine(respuestaConvertidaString);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void enviarMensajes_A_Mano() 
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var variablesEnviar = new NameValueCollection();
                    variablesEnviar["inorden"] = txtMensaje.Text;

                    var respuestaMetodo = cliente.UploadValues("http://" + txtIP.Text + ":5000/mensaje", variablesEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }

    public class NodoCola
    {
        public string ip { get; set; }
        public string mensaje { get; set; }
    }
}
