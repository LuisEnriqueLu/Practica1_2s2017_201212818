using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class RespuestasMensajes : Form
    {
        string ip = "";
        string carnet = "";
        string resultado = "";
        string iorden = "";
        string postorden = "";
        public RespuestasMensajes()
        {
            InitializeComponent();
            dgvDatos.AllowUserToAddRows = false;
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnAntiguos_Click(object sender, EventArgs e)
        {
            ConsultarListaSimple();
            resutaldoMasRecientes();
        }

        public void resutaldoMasRecientes()
        {
            int contadorDataGrid = 1;            
            dgvDatos.Rows.Clear();
            
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://127.0.0.1:5000/consultarListaDoble");
                    Console.WriteLine(respuestaConvertidaString);

                    string[] variablesCadena = respuestaConvertidaString.Split(';');

                    for (int i = 0; i < variablesCadena.Length-1; i++)
                    {
                        string[] variables = variablesCadena[i].Split(',');
                        carnet = variables[0].ToString();
                        ip = variables[1].ToString();
                        iorden = variables[2].ToString();
                        postorden = variables[3].ToString();
                        resultado = variables[4].ToString();

                        contadorDataGrid = dgvDatos.Rows.Add();
                        dgvDatos.Rows[contadorDataGrid].Cells["Carnet"].Value = carnet;
                        dgvDatos.Rows[contadorDataGrid].Cells["IP"].Value = ip;
                        dgvDatos.Rows[contadorDataGrid].Cells["Inorden"].Value = iorden;
                        dgvDatos.Rows[contadorDataGrid].Cells["Postorden"].Value = postorden;
                        dgvDatos.Rows[contadorDataGrid].Cells["Resultado"].Value = resultado;

                        contadorDataGrid++;
                    }
                    dgvDatos.ClearSelection();
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }


        public void resutaldoMasAntiguos()
        {
            int contador=0;
            int contadorDataGrid = 1;
            dgvDatos.Rows.Clear();

            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://127.0.0.1:5000/consultarListaDoble");
                    Console.WriteLine(respuestaConvertidaString);

                    string[] variablesCadena = respuestaConvertidaString.Split(';');
                    string[] vueltaVariables;
                    vueltaVariables = new string[variablesCadena.Length - 1];

                    foreach (string i in variablesCadena)
                    {                        
                        if ( i != "") 
                        {
                            vueltaVariables[contador] =  variablesCadena[contador];
                        }
                        contador++;
                    }

                    int cont2 = 0;
                    cont2 = vueltaVariables.Length;

                    for (int i=0; i <= vueltaVariables.Length-1; i++)
                    {
                        string[] variables = vueltaVariables[cont2-1].Split(',');
                        carnet = variables[0].ToString();
                        ip = variables[1].ToString();
                        iorden = variables[2].ToString();
                        postorden = variables[3].ToString();
                        resultado = variables[4].ToString();

                        contadorDataGrid = dgvDatos.Rows.Add();
                        dgvDatos.Rows[contadorDataGrid].Cells["Carnet"].Value = carnet;
                        dgvDatos.Rows[contadorDataGrid].Cells["IP"].Value = ip;
                        dgvDatos.Rows[contadorDataGrid].Cells["Inorden"].Value = iorden;
                        dgvDatos.Rows[contadorDataGrid].Cells["Postorden"].Value = postorden;
                        dgvDatos.Rows[contadorDataGrid].Cells["Resultado"].Value = resultado;

                        contadorDataGrid++;
                        cont2--;
                    }
                    dgvDatos.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void ConsultarListaSimple()
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://127.0.0.1:5000/consultarListaSimple");
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void btnRecientes_Click(object sender, EventArgs e)
        {
            ConsultarListaSimple();
            resutaldoMasAntiguos();
        }
    }
}
