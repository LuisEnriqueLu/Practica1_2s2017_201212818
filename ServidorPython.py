from Lista import Lista
from NodoL import NodoL
from Cola import Cola
from NodoCola import NodoCola
from Pila import Pila
from NodoPila import NodoPila
from flask import Flask, request, Response
app = Flask("Servidor")

lista = Lista()
cola = Cola()
pilaSignos = Pila()
pilaNumero = Pila()

class Servidor():	
	@app.route('/AgregarListaIPCarnet',methods=['POST']) 
	def agregarLista():
		carnet = str(request.form['carnet'])
		ip = str(request.form['ip'])
		estado = str(request.form['estado'])
		mascara = str(request.form['mascara'])
		lista.insertar(carnet, ip, estado, mascara)
		return "DATO INGRESADO"

	@app.route("/consultar")
	def ConsultarLista():
		respuesta = lista.consultar()
		return respuesta

	@app.route("/conectado")
	def metodoGet():
		return "201212818"
	
	@app.route('/respuesta',methods=['POST']) 
	def respuesta():
		textoenviar = str(request.data)
		textoenviar = str(request.data)
		textoenviar = str(request.data)
		ipRecup = str(request.environ['REMOTE_ADDR'])
		return "true"
	

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
		return cadena


	@app.route('/mensaje',methods=['POST']) 
	def respuestaMensaje():
		mensaje = str(request.form['inorden'])
		ipRecup = str(request.environ['REMOTE_ADDR'])
		cola.Encolar(mensaje);	
		return "true"	
	

	if __name__ == "__main__":
		app.run(debug=True, host='192.168.0.30')