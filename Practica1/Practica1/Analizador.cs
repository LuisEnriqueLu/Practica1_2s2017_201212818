using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Analizador
    {
        public static void AnalizarJSON(string cadena)
        {
            int inicioestado = 0;
            int estadoprincipal = 0;
            char cadenaconcatenar;
            string ip = "";
            string mascara = "";
            string ipcambiar = "";
            string mascaracambiar = "";

            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                switch (estadoprincipal)
                {
                    case 0:
                        switch (cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoprincipal = 0;
                                break;

                            case '{':
                                estadoprincipal = 0;
                                break;

                            case '}':
                                estadoprincipal = 6;
                                inicioestado = inicioestado - 1;
                                break;                            

                            case '"':
                                estadoprincipal = 1;
                                break;
                        }
                        break;

                    case 1: //IP a Cambiar
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals(':') || cadenaconcatenar.Equals('"') || cadenaconcatenar.Equals('{'))
                        {
                            estadoprincipal = 1;
                        }                        
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            ipcambiar += cadenaconcatenar;
                            estadoprincipal = 1;
                        }
                        else if (cadenaconcatenar.Equals(',')) 
                        {
                            Globales.ipCambiar = ipcambiar;                        
                            estadoprincipal = 2;
                        }                        
                        break;

                    case 2: //Mascara
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals(':') || cadenaconcatenar.Equals('"'))
                        {
                            estadoprincipal = 2;
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            mascaracambiar += cadenaconcatenar;
                            estadoprincipal = 2;
                        }
                        else if (cadenaconcatenar.Equals(','))
                        {
                            estadoprincipal = 3;
                        }
                        break;

                    case 3://IP
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals(':') || cadenaconcatenar.Equals('"') || cadenaconcatenar.Equals('[') || cadenaconcatenar.Equals('{'))
                        {
                            estadoprincipal = 3;
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            ip += cadenaconcatenar;
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar.Equals(','))
                        {
                            estadoprincipal = 4;
                        }
                        break;

                    case 4://Mascara
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals(':') || cadenaconcatenar.Equals('"') || cadenaconcatenar.Equals('}'))
                        {
                            estadoprincipal = 4;
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            mascara += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        else if (cadenaconcatenar.Equals(','))
                        {
                            estadoprincipal = 5;
                        }
                        else if (cadenaconcatenar.Equals(']'))
                        {
                            estadoprincipal = 6;
                        }
                        break;


                    case 5://Enviar a la Lista
                        Dashboard.AgregarDatosListaSimple("Vacio", ip, mascara);
                        ip = "";
                        mascara = "";                        
                        estadoprincipal = 3;
                        break;

                    case 6://Termina ] } }
                        if (ip != "" && mascara != "")
                        {
                            Dashboard.AgregarDatosListaSimple("Vacio", ip, mascara);
                        }
                        ip = "";
                        mascara = "";
                        Dashboard.CambiarIpComputadora(ipcambiar, mascaracambiar);
                        Console.WriteLine("IP a Cambiar " + ipcambiar);
                        Console.WriteLine("Mascara de Red " + mascaracambiar);
                        Globales.ipCambiar = ipcambiar;
                        estadoprincipal = 0;
                        break;

                }
            }
        }

        public static void AnalizarXML(string cadena)
        {
            int inicioestado = 0;
            int estadoprincipal = 0;
            char cadenaconcatenar;
            string ip = "";
            string mensaje = "";

            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                switch (estadoprincipal)
                {
                    case 0:
                        switch (cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoprincipal = 0;
                                break;

                            case '<':
                                estadoprincipal = 1;
                                break;                            
                        }
                        break;

                    case 1: //Mensaje Nodo
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            if (cadenaconcatenar.Equals('I'))
                            { 
                                estadoprincipal = 2; 
                            }
                            else
                            {
                                estadoprincipal = 1;
                            }
                        }
                        break;

                    case 2://Ip - Numeros
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>'))
                        {
                            if (cadenaconcatenar.Equals('t'))
                            {
                                estadoprincipal = 3;
                            }
                            else
                            {
                                estadoprincipal = 2;
                            }
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            ip += cadenaconcatenar;
                            estadoprincipal = 2;
                        }
                        else if (cadenaconcatenar.Equals('/'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                EnviarMensajes.AgregarDatosCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 2;
                        }                        
                        break;

                    case 3: //texto
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>'))
                        {
                            estadoprincipal = 3;                      
                        }
                        else if (cadenaconcatenar.Equals('('))
                        {
                            mensaje += cadenaconcatenar;                            
                            estadoprincipal = 4;
                        }                   
                        break;

                    case 4: //TextoMensaje
                        if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('+') || cadenaconcatenar.Equals('/') || cadenaconcatenar.Equals('-') || cadenaconcatenar.Equals('*') || cadenaconcatenar.Equals('(') || cadenaconcatenar.Equals(')'))
                        {
                            mensaje += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                EnviarMensajes.AgregarDatosCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 5;
                        }                        
                        break;

                    case 5: //Mensajes
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            estadoprincipal = 5;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            estadoprincipal = 1;
                        }
                        break;
                }
            }
        }

    }
}
