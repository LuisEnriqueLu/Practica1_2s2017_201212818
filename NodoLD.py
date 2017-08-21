class NodoLD:
	def __init__(self, carnet=None, ip=None, inorden=None, postorden=None, resultado=None, index=None, siguiente=None):
		self.carnet = carnet
		self.ip = ip
		self.inorden = inorden
		self.postorden = postorden
		self.resultado = resultado
		self.index = index
		self.siguiente = siguiente
		#self.anterior = anterior