from Lista import Lista
from NodoL import NodoL
from Cola import Cola
from NodoCola import NodoCola
from Pila import Pila
from NodoPila import NodoPila
from flask import Flask, request, Response

lista = Lista()
cola = Cola()
pilaSignos = Pila()
pilaNumero = Pila()

app = Flask("Servidor_Python")

class Servidor():
	
	#Agregar a Lista Simple
	@app.route('/AgregarIPCarnetListaSimple',methods=['POST']) 
	def agregarLista():
		listasimple = Lista()
		carnet = str(request.form['carnet'])
		ip = str(request.form['ip'])
		estado = str(request.form['estado'])
		mascara = str(request.form['mascara'])		
		listasimple.insertar(carnet, ip, estado, mascara)
		return "Dato Insertado -> " + carnet + " " + ip 


	#Imprimir Lista Simple
	@app.route("/consultarListaSimple")
	def ConsultarLista():
		respuesta = lista.consultar()
		return respuesta


	#Metodo Ip Conectado
	@app.route("/conectado")
	def metodoGet():
		return "201212818"
	
	
	#Metodo Respuesta
	@app.route('/respuesta',methods=['POST']) 
	def respuesta():
		inorden = str(request.form['inorden'])
		postorden = str(request.form['postorden'])
		resultado = str(request.form['resultado'])
		ipRecup = str(request.environ['REMOTE_ADDR'])
		#Enviar a Lista Doble
		return "true"
	
	
	#Metodo Mensaje en Cola
	@app.route('/mensaje',methods=['POST']) 
	def respuestaMensaje():
		mensaje = str(request.form['inorden'])
		ipRecup = str(request.environ['REMOTE_ADDR'])
		cola.Encolar(mensaje);	
		return "true"	

	#Operar Expresion en Pila
	@app.route('/operarExpresion',methods=['POST'])
	def ResolverExpresion():
		cadena = str(request.form['inorden'])
		caracter = ""
		valor = ""
		numero1 = ""
		numero2 = ""
		signo = ""
		cantidad = len(cadena)
		for i in range(cantidad):
			caracter = cadena[i]
			if caracter in ('/', '*', '-', '+'):
				pilaSignos.agregarPila(caracter)
				pilaNumero.agregarPila(valor)
				valor = ""
			elif caracter in (' ', '('):
				nada = "Aqui no hace nada xD xD xD"
			elif caracter == ')':
				pilaNumero.agregarPila(valor)
				valor = ""             
	
				numero2 = pilaNumero.sacarPila()
				numero1 = pilaNumero.sacarPila()
				signo = pilaSignos.sacarPila()
				if signo == '-':
					valor = int(numero1) - int(numero2)
				elif signo == '+':
					valor = int(numero1) + int(numero2)
				elif signo == '*':
					valor = int(numero1) * int(numero2)
				elif signo == '/':
					valor = int(numero1) / int(numero2)
			else:
				valor = valor + caracter					
		pilaNumero.agregarPila(valor)        
		respuesta = pilaNumero.sacarPila()
		r = str(respuesta)			
		return r	
	
	
	if __name__ == "__main__":
		app.run(debug=True, host='192.168.0.6')