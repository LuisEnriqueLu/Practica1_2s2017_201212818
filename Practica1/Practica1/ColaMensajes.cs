﻿using System;
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
    public partial class ColaMensajes : Form
    {
        string ip = "";
        string carnet = "";
        string resultado = "";
        string iorden = "";
        string postorden = "";
        string textoImprimir = "";
        public ColaMensajes()
        {
            InitializeComponent();
            ContarCola();
            if (lbOp.Text == "Operaciones en Cola: 0")
            {
                btnOperar.Enabled = false;
                Globales.contador = 0;
            }else
            {
                btnOperar.Enabled = true;
                Globales.contador = 1;
            }            
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

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            OperacionEnCola();
            ContarCola();
            EnviarRespuestaOperacion();
        }

        public void operacionPost()
        {
            string variable = "((2 + 8 ) * (7 + (7 / (6 / 1))))";

            try
            {
                using (var cliente = new WebClient())
                {
                    var variablesEnviar = new NameValueCollection();
                    variablesEnviar["inorden"] = variable;

                    var respuestaMetodo = cliente.UploadValues("http://" + Globales.ipCambiar + ":5000/operarExpresion", variablesEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ContarCola()
        {
            try
            {
                if (lbOp.Text != "Operaciones en Cola: 1")
                {
                    using (var cliente = new WebClient())
                    {
                        var respuestaConvertidaString = cliente.DownloadString("http://" + Globales.ipCambiar + ":5000/ContarCola");
                        Console.WriteLine("Mensajes en Cola " + respuestaConvertidaString);
                        lbOp.Text = "Operaciones en Cola: " + respuestaConvertidaString;
                        Globales.contador = 1;
                    }
                }
                else
                {
                    lbOp.Text = "Operaciones en Cola: 0";
                    btnOperar.Enabled = false;
                    Globales.contador = 0;
                }
            }
            catch (Exception e)
            {
                lbOp.Text = "Operaciones en Cola: 0";
                btnOperar.Enabled = false;
                Globales.contador = 0;
                Console.WriteLine(e);
            }
        }

        public void OperacionEnCola() 
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var respuestaConvertidaString = cliente.DownloadString("http://" + Globales.ipCambiar + ":5000/operarExpresion");
                    Console.WriteLine("Respuesta: " + respuestaConvertidaString);
                    
                    string[] variables = respuestaConvertidaString.Split(';');

                    resultado = variables[0].ToString();
                    ip = variables[1].ToString();
                    iorden = variables[2].ToString();
                    postorden = variables[3].ToString();
                    textoImprimir = variables[4].ToString();

                    foreach (var nodo in Dashboard.ListaSimple) 
                    {
                        if (ip == nodo.ip) 
                        {
                            carnet = nodo.carnet; 
                        }
                    }

                    txtCarnet.Text = carnet;
                    txtInorden.Text = iorden;
                    txtPostorden.Text = postorden;
                    txtIp.Text = ip;
                    txtOperacion.Text = resultado;
                    txtArea.Text = textoImprimir;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }        
        }

        public void EnviarRespuestaOperacion() 
        {
            try
            {
                using (var cliente = new WebClient())
                {
                    var variablesEnviar = new NameValueCollection();
                    variablesEnviar["inorden"] = iorden;
                    variablesEnviar["postorden"] = postorden;
                    variablesEnviar["resultado"] = resultado;

                    var respuestaMetodo = cliente.UploadValues("http://" + ip + ":5000/respuesta", variablesEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    Console.WriteLine(respuestaConvertidaString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            } 
        }
    }
}
