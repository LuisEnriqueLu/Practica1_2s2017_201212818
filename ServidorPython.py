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
		respuesta = cola.GraficarCola()
		return respuesta	
	

	#Operar Expresion en Pila
	@app.route('/operarExpresion')
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
	
	@app.route('/operar', methods = ['GET'])
	def operar():
		pilaNumero = Pila()
		pilaOperador = Pila()
		resultado = ""
		postorden = ""
		numero = ""
		colaEjecucion = ""
		#nodo = cola.Desencolar()
		#print (nodo)
		if nodo != None:
			#operacion = nodo["mensaje"]
			operacion = str(request.form['inorden'])
			#ipRecup = nodo["ip"]
			ipRecup = str(request.environ['REMOTE_ADDR'])
			for x in str(operacion):
				print (x)
				if x in (' ', '('):
					print ("")
				elif x == ")": 
					if numero != "":
						pilaNumero.push(numero)
						colaEjecucion += "push(" + numero +")\n"
						postorden = postorden  + numero + " "
						numero=""
	
					var1 = pilaNumero.pop()
					var2 = pilaNumero.pop()
					op = pilaOperador.pop()
					colaEjecucion += "pop()\npop()\n"
					postorden = postorden + str(op) + " "                          
					if op == "+":
						var3 = int(var1) + int(var2)
						pilaNumero.push(var3)
						colaEjecucion += str(var1)+"+"+str(var2) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "-":
						var3 = int(var2) - int(var1)
						pilaNumero.push(var3)
						colaEjecucion += str(var2)+"-"+str(var1) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "*":
						var3 = int(var1) * int(var2)
						pilaNumero.push(var3)
						colaEjecucion += str(var1)+"*"+str(var2) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
					elif op == "/":
						var3 = int(var2) / int(var1)               
						pilaNumero.push(var3)
						colaEjecucion += str(var2)+"/"+str(var1) + "=" + str(var3) + "\n"
						colaEjecucion += "push(" + str(var3) +")\n"
						#print var3
	
				elif x  in ('/', '*', '-', '+'):
					pilaOperador.push(x)                
					if numero != "" :
						postorden = postorden  + numero + " "
						pilaNumero.push(numero)
						colaEjecucion += "push(" + numero +")\n"
						numero=""
				else:
					#pilaNumero.push(x)
					numero = numero + x                
					#postorden = postorden + " " + str(x) 
	
			resultado = pilaNumero.pop()
			nodo = {'resultado': resultado ,'postorden': postorden , 'inorden' : operacion , 'carnet':'201212919'}
			#return "true de prueba" + str(resultado)+ "POST"+ str(postorden)
			try:
				#r = requests.post("http://"+ipRecup+":5000/respuesta", data = nodo)
				#r = requests.post("http://192.168.1.5:5000/respuesta", data = nodo)
				#if r.status_code == 200:
				respuestaLocal = {'resultado': resultado ,'postorden': postorden , 'inorden' : operacion ,'ipRecup': ipRecup , 'enviado' : "true" , 'colaEjecucion': colaEjecucion}
				return json.dumps(respuestaLocal, default = jsonDefault)
			except requests.exceptions.RequestException as e : 
				print (e)    
				return "No se pudo enviar el resultado"            
		else:
			return "la cola esta vacia"
	
	
	
	
	if __name__ == "__main__":
		app.run(debug=True, host='127.0.0.1')