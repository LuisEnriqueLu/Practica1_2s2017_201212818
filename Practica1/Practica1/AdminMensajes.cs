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
        static List<NodoCola> listaCola;
        static int contadorNodosCola;
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
            MostrarCola();
            enviarMensajes();
        }

        public static void AgregaraCola(string ip, string mensaje) 
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
            else {
                listaCola.Add(nodo);
                contadorNodosCola++;
            }            
        }

        public void MostrarCola() 
        {
            foreach(var i in listaCola)
            {
                Console.WriteLine(i.ip + " " + i.mensaje);
            }

        }

        public void MetodoPost()
        {
            using (var cliente = new WebClient())
            {
                var variablesEnviar = new NameValueCollection();
                variablesEnviar["nombre"] = "Luis";

                var respuestaMetodo = cliente.UploadValues("http://127.0.0.5:5000/agregarLista", variablesEnviar);
                var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                Console.WriteLine(respuestaConvertidaString);
            }
        }

        public void MetodoGet()
        {
            using (var cliente = new WebClient())
            {
                var respuestaConvertidaString = cliente.DownloadString("http://127.0.0.5:5000/MetodoGet");
                Console.WriteLine(respuestaConvertidaString);
            }
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            /*ColaMensajes verPanel = new ColaMensajes();
            verPanel.ShowDialog();*/

            string variable = "((2 + 8 ) * (7 + (7 / (6 / 1))))";

            try
            {
                using (var cliente = new WebClient())
                {
                    var variablesEnviar = new NameValueCollection();
                    variablesEnviar["inorden"] = variable;

                    var respuestaMetodo = cliente.UploadValues("http://192.168.0.6:5000/operarExpresion", variablesEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            RespuestasMensajes verPanel = new RespuestasMensajes();
            verPanel.ShowDialog();
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
    }

    public class NodoCola
    {
        public string ip { get; set; }
        public string mensaje { get; set; }
    }
}
