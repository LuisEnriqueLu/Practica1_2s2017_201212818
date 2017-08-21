using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Net.Sockets;
using System.Management;

namespace Practica1
{
    public partial class Dashboard : Form
    {
        public static List<NodoListaSimple> ListaSimple;
        static int ContadorNodosListaSimple;
        public Dashboard()
        {
            InitializeComponent();
            dgvNodos.AllowUserToAddRows = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPanel.ReleaseCapture();
            MoverPanel.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            abrirArchivoJSON();
            EnviarDatosListaSimple();
            ConsultarListaSimple();
            CambiarIpComputadora(Globales.ipCambiar, "255.0.0.0");
            timer1.Start();
        }

        public void abrirArchivoJSON() 
        {
            ListaSimple = new List<NodoListaSimple>();
            ContadorNodosListaSimple = 1;

            opd.Filter = "Arhivos de Texto(*.txt) | *.txt";
            opd.InitialDirectory = "Escritorio";

            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Analizador.AnalizarJSON(File.ReadAllText(opd.FileName));                
            }
            else
            {
                MessageBox.Show("Hubo un Error al Abrir el Archivo", "EDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            MostrarListaSimpleGridView();            
        }        

        public static void AgregarDatosListaSimple(string carnet, string ip, string mascara)
        {
            NodoListaSimple nodo = new NodoListaSimple();
            nodo.carnet = carnet;
            nodo.ip = ip;
            nodo.nodo = "Nodo" + ContadorNodosListaSimple;
            nodo.mascara = mascara;
            nodo.id = ContadorNodosListaSimple;
            nodo.estado = "No";
            
            ListaSimple.Add(nodo);
            ContadorNodosListaSimple++;
        }

        public void MostrarListaSimpleGridView()
        {
            int contador = 1;
            dgvNodos.Rows.Clear();
            
            foreach (var nod in ListaSimple)
            {
                contador = dgvNodos.Rows.Add();
                dgvNodos.Rows[contador].Cells["Nodo"].Value = nod.nodo;
                dgvNodos.Rows[contador].Cells["Carnet"].Value = nod.carnet;
                dgvNodos.Rows[contador].Cells["IP"].Value = nod.ip;
                dgvNodos.Rows[contador].Cells["Mascara"].Value = nod.mascara;
                dgvNodos.Rows[contador].Cells["Estado"].Value = Image.FromFile(@"C:\Users\l_enr\Pictures\No.png");                                                 

                contador++;
            }
            dgvNodos.ClearSelection();
            lblNodo.Text = "Este Nodo: ";
        }

        private void dgvNodos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblNodo.Text = "Este Nodo: " + dgvNodos.Rows[e.RowIndex].Cells[2].Value.ToString() + " - " + dgvNodos.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void EnviarDatosListaSimple()
        {
            try
            {
                foreach (var nod in ListaSimple)
                {
                    using (var cliente = new WebClient())
                    {
                        var variablesEnviar = new NameValueCollection();
                        variablesEnviar["carnet"] = nod.carnet;
                        variablesEnviar["ip"] = nod.ip;
                        variablesEnviar["mascara"] = nod.mascara;
                        if (nod.carnet != "" && nod.carnet != "Vacio")
                        {
                            variablesEnviar["estado"] = "Si";
                        }
                        else
                        {
                            variablesEnviar["estado"] = "No";
                        }

                        var respuestaMetodo = cliente.UploadValues("http://" + Globales.ipCambiar + ":5000/AgregarIPCarnetListaSimple", variablesEnviar);
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

        public void ActualizarListaSimple()
        {
            try
            {
                foreach (var nod in ListaSimple)
                {
                    using (var cliente = new WebClient())
                    {
                        var variablesEnviar = new NameValueCollection();
                        variablesEnviar["carnet"] = nod.carnet;
                        variablesEnviar["ip"] = nod.ip;
                        variablesEnviar["mascara"] = nod.mascara;
                        if (nod.carnet != "" && nod.carnet != "Vacio")
                        {
                            variablesEnviar["estado"] = "Si";
                        }
                        else
                        {
                            variablesEnviar["estado"] = "No";
                        }

                        var respuestaMetodo = cliente.UploadValues("http://" + Globales.ipCambiar + ":5000/ActualizarCarnetListaSimple", variablesEnviar);
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


        public string CarnetConectados(string ipCarnet)
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://" + Globales.ipCambiar + ":5000/conectado");
                    Console.WriteLine("Carnet Conectado: " + respuestaConvertidaString);
                    return respuestaConvertidaString;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        public void ConsultarListaSimple()
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://" + Globales.ipCambiar + ":5000/consultarListaSimple");
                    Console.WriteLine(respuestaConvertidaString);                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }
        }

        public void RecargarDatos(List<string> listaRedIp)
        {
            int contador = 1;
            dgvNodos.Rows.Clear();
            string Carnet = "";

            foreach (var nod in ListaSimple)
            {
                Carnet = CarnetConectados(nod.ip);
                nod.carnet = Carnet;
            }            

            foreach (var nod in ListaSimple)
            {
                contador = dgvNodos.Rows.Add();
                dgvNodos.Rows[contador].Cells["Nodo"].Value = nod.nodo;
                dgvNodos.Rows[contador].Cells["Carnet"].Value = nod.carnet;
                dgvNodos.Rows[contador].Cells["IP"].Value = nod.ip;
                dgvNodos.Rows[contador].Cells["Mascara"].Value = nod.mascara;
                if (nod.carnet != "")
                {
                    dgvNodos.Rows[contador].Cells["Estado"].Value = Image.FromFile(@"C:\Users\l_enr\Pictures\Si.png");
                }
                else
                {
                    dgvNodos.Rows[contador].Cells["Estado"].Value = Image.FromFile(@"C:\Users\l_enr\Pictures\No.png");
                }

                contador++;
            }
            dgvNodos.ClearSelection();
            lblNodo.Text = "Este Nodo: ";
        }

        public List<string> CargarIpConectadas() 
        {
            try
            {
                List<string> listaRed = new List<string>();
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress addr in localIPs)
                {
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        listaRed.Add(addr.ToString());
                        Console.WriteLine("Ip Conectada: " + addr);
                    }
                }
                return listaRed;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }            
        }

        public static void CambiarIpComputadora(string ipCambiar, string mascarCambiar)
        {
            try
            {
                ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMC.GetInstances();
                foreach (ManagementObject objMO in objMOC)
                {
                    if ((bool)objMO["IPEnabled"])
                    {
                        try
                        {
                            ManagementBaseObject setIP;
                            ManagementBaseObject newIP = objMO.GetMethodParameters("EnableStatic");
                            newIP["IPAddress"] = new string[] { ipCambiar };
                            newIP["SubnetMask"] = new string[] { mascarCambiar };
                            setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                        }
                        catch (Exception) { throw; }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RecargarDatos(CargarIpConectadas());
            ActualizarListaSimple();
            ConsultarListaSimple();
            Console.WriteLine("Cada 20 Segundos");
        }

        private void ptbDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.WriteLine("Timer Detenido");
        }

        private void ptbIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Console.WriteLine("Timer Reiniciado");
        }      
    }    

    public class NodoListaSimple {
        public string nodo { get; set; }
        public string ip { get; set; }
        public string carnet { get; set; }
        public string mascara { get; set; }
        public string estado { get; set; }
        public int id { get; set; }
    }    
}