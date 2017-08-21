from Lista import Lista
from NodoL import NodoL
from Cola import Cola
from NodoCola import NodoCola
from Pila import Pila
from NodoPila import NodoPila
from ListaDoble import ListaDoble
from NodoLD import NodoLD
from flask import Flask, request, Response

lista = Lista()
listaDoble = ListaDoble()
cola = Cola()
pilaSignos = Pila()
pilaNumero = Pila()

app = Flask("Servidor_Python")

class Servidor():
	
	#Agregar a Lista Simple
	@app.route('/AgregarIPCarnetListaSimple',methods=['POST']) 
	def agregarLista():
		carnet = str(request.form['carnet'])
		ip = str(request.form['ip'])
		estado = str(request.form['estado'])
		mascara = str(request.form['mascara'])		
		lista.insertar(carnet, ip, estado, mascara)
		return "Dato Insertado -> " + carnet + " " + ip 

	#Actualizar Lista Simple
	@app.route('/ActualizarCarnetListaSimple',methods=['POST']) 
	def actualizarLista():
		carnet = str(request.form['carnet'])
		ip = str(request.form['ip'])
		estado = str(request.form['estado'])
		mascara = str(request.form['mascara'])		
		lista.ActualizarDatos(carnet, ip, estado)
		return "Dato Actualizado -> " + carnet + " " + ip 	


	#Imprimir Lista Simple
	@app.route("/consultarListaSimple")
	def ConsultarLista():
		respuesta = lista.consultar()
		return respuesta


	#Metodo Ip Conectado
	@app.route("/conectado")
	def metodoGet():
		return "201212818"
	
	
	#Metodo Respuesta Lista Doble
	@app.route('/respuesta',methods=['POST']) 
	def respuesta():
		inorden = str(request.form['inorden'])
		postorden = str(request.form['postorden'])
		resultado = str(request.form['resultado'])
		ipRecup = str(request.environ['REMOTE_ADDR'])
		carnet = str(lista.consultarCarnet(ipRecup))
		listaDoble.insertar(carnet, ipRecup, inorden, postorden, resultado)
		return "true"
	
	
	#Imprimir Lista Doble
	@app.route("/consultarListaDoble")
	def ConsultarListaDoble():
		respuesta = listaDoble.consultar()
		return respuesta
	
	
	#Metodo Mensaje en Cola
	@app.route('/mensaje',methods=['POST']) 
	def respuestaMensaje():
		mensaje = str(request.form['inorden'])
		ipRecup = str(request.environ['REMOTE_ADDR'])
		cola.Encolar(mensaje, ipRecup)	
		return "true"	


	#Imprimir Cola
	@app.route("/consultarCola")
	def ConsultarCola():
		respuesta = cola.mostrarCola()
		return respuesta
	
	
	#Contar Cola
	@app.route("/ContarCola")
	def ContarCola():
		respuesta = cola.ContarCola()
		return respuesta
	
	#Graficar Cola
	@app.route("/GraficarCola")
	def GraficarCola():
		cola.crearArchivo()
		respuesta = cola.GraficarCola()
		return respuesta	
	

	#Operar Expresion en Pila
	@app.route('/operar')
	def ResolverExpresion():
		todaCadena = str(cola.Desencolar())
		cadena,ip = todaCadena.split(";") 
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
		r = str(respuesta) + ";" + ip + ";" + cadena			
		return r	
	
	@app.route('/operarExpresion')
	def operar():
		pilaNumero = Pila()
		pilaOperador = Pila()
		resultado = ""
		postorden = ""
		numero = ""
		colaEjecucion = ""
		todaCadena = str(cola.Desencolar())
		nodo,ip = todaCadena.split(";") 		
		if nodo != None:
			operacion = nodo			
			for x in str(operacion):
				print (x)
				if x in (' ', '('):
					print ("")
				elif x == ")": 
					if numero != "":
						pilaNumero.agregarPila(numero)
						colaEjecucion += "push(" + numero +")\n"
						postorden = postorden  + numero + " "
						numero=""
	
					var1 = pilaNumero.sacarPila()
					var2 = pilaNumero.sacarPila()
					op = pilaOperador.sacarPila()
					colaEjecucion += "pop()\npop()\n"
					postorden = postorden + str(op) + " "                          
					if op == "+":
						var3 = int(var1) + int(var2)
						pilaNumero.agregarPila(var3)
						colaEjecucion += str(var1)+"+"+str(var2) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "-":
						var3 = int(var2) - int(var1)
						pilaNumero.agregarPila(var3)
						colaEjecucion += str(var2)+"-"+str(var1) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "*":
						var3 = int(var1) * int(var2)
						pilaNumero.agregarPila(var3)
						colaEjecucion += str(var1)+"*"+str(var2) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "/":
						var3 = int(var2) / int(var1)               
						pilaNumero.agregarPila(var3)
						colaEjecucion += str(var2)+"/"+str(var1) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
	
				elif x  in ('/', '*', '-', '+'):
					pilaOperador.agregarPila(x)                
					if numero != "" :
						postorden = postorden  + numero + " "
						pilaNumero.agregarPila(numero)
						colaEjecucion += "push(" + numero +")\n"
						numero=""
				else:
					numero = numero + x                					
	
			resultado = pilaNumero.sacarPila()
			try:				
				r = str(resultado) + ";" + ip + ";" + nodo + ";" + postorden + ";" + colaEjecucion 
				return r
			except requests.exceptions.RequestException as e : 
				print (e)    
				return "Error"            
		else:
			return "Ya no hay Datos"
	
	
	
	if __name__ == "__main__":
		app.run(debug=True, host='127.0.0.1')