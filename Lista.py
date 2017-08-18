from NodoL import NodoL

class Lista:
	def __init__(self):#constructor
		self.raiz = None
		self.indiceLista = 0

	def insertar(self, carnet, ip, estado, mascara):
		if self.raiz == None:			
			nodo = NodoL(carnet, ip, estado, mascara, self.indiceLista)
			self.raiz = nodo
			self.indiceLista = self.indiceLista + 1
		else :
			aux = self.raiz
			while aux.siguiente != None:
				aux = aux.siguiente
			nodo = NodoL(carnet, ip, estado, mascara, self.indiceLista)
			self.indiceLista = self.indiceLista + 1
			aux.siguiente = nodo
				
	
	def consultar(self):
		aux = self.raiz
		dato = ""
		if aux == None:			
			return "LISTA VACIA"			
		else :
			while aux != None:
				if aux.index != None:
					dato += aux.carnet + " " + aux.ip + " " + aux.estado + "; "										
				aux = aux.siguiente
			return str(dato) 
			
			
			
	
	def eliminar(self, dato):
		aux = self.raiz
		aux2 = self.raiz
		if aux == None:
			return "NO HAY ELEMENTOS PARA ELIMINAR " + str(dato)
		else:
			if str(aux.index) == str(dato):
				if aux.siguiente == None:
					self.raiz = NodoL()
					return "DATO ELIMINADO -> " + str(dato)
				else:
					self.raiz = aux.siguiente
					return "DATO ELIMINADO -> " + str(dato)
			else:
				t = True
				while aux.siguiente != None:
					aux = aux.siguiente
					if str(aux.index) == str(dato):
						aux2.siguiente = aux.siguiente
						aux = None
						t = False
						return "DATO ELIMINADO -> " + str(dato)
						#break
					aux2 = aux2.siguiente
				if t==True:
					return "VALOR NO ENCONTRADO"	
				
	def crearArchivo(self):
		archivo=open('relacionLista.txt','w')
		archivo.close()
	
	def grabarArchivo(self):
		temp = self.raiz
		cont1 = 0
		archivo=open('relacionLista.txt','a')
		archivo.write('digraph G{\n')
		while temp!=None:
			archivo.write(str(temp.carnet) + "_nodo_" + str(cont1) + " [label="+str(temp.carnet)+"]\n")
			cont1=cont1+1
			temp = temp.siguiente
		cont1 = 0
		cont2 = cont1+1
		temp = self.raiz
		while temp!=None:
			if temp.siguiente!=None:
				archivo.write(str(temp.carnet)+"_nodo_"+str(cont1)+"->"+str(temp.siguiente.carnet)+"_nodo_"+str(cont2)+"\n")
				cont1=cont1+1
				cont2=cont2+1
			temp = temp.siguiente
		archivo.write('}')
		archivo.close()
		return "relacionLista"	