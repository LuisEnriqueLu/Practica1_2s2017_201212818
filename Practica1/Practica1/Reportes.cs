using System;
using System.Collections.Generic;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoverPanel.ReleaseCapture();
            MoverPanel.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void GenerateGraph()
        {
            //string variable = "digraph G { " + cadena + "}"; 
            //var fileName = "C:\\Users\\l_enr\\Desktop\\graficaCola.txt";
            //SaveToFile(variable, fileName); 

            try
            {
                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C dot -Tjpg C:\\Users\\l_enr\\Desktop\\graficaCola.txt -o C:\\Users\\l_enr\\Desktop\\graficaCola.jpg");
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
        }
        
        private void SaveToFile(string variable, string fileName)
        {
            TextWriter tw = new StreamWriter(fileName);
            tw.WriteLine(variable);
            tw.Close();
        }

        private void btnGraficarCola_Click(object sender, EventArgs e)
        {
            /*
            string variable = "digraph G { hola }"; 
            var fileName = "C:\\Users\\l_enr\\Desktop\\graficaCola.txt";
            SaveToFile(variable, fileName); */
            GraficarCola();            
        }
                    

        public string GraficarCola()
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://"+ Globales.ipCambiar +":5000/GraficarCola");
                    Console.WriteLine(respuestaConvertidaString);
                    return respuestaConvertidaString.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (Globales.contador != 0)
            {
                GenerateGraph();
                ptbImagen.Image = Image.FromFile(@"C:\Users\l_enr\Desktop\graficaCola.jpg");
            }
            else 
            {
                ptbImagen.Image = null;
            }
        }
    }
}
