from NodoCola import NodoCola

class Cola:
    longitud = 0 #Longitud de la Cola
    
    def __init__(self):
        self.Cabeza = None
        self.Cola = None
        
        
    def Encolar(self, dato):
        Nuevo = NodoCola(dato)
        aux = self.Cabeza
        if self.Cabeza == None:
            self.Cabeza = Nuevo
            self.Cola = Nuevo
        else:
            self.Cola.Sig = Nuevo
            self.Cola = self.Cola.Sig
    
    def Desencolar(self, numero):
        aux = self.Cabeza
        if aux == None:
            print("Cola vacia")
        else:
            data = self.Cabeza.getDato()
            print("El dato a desencolar es: " + str(data))
            self.Cabeza = aux.Sig
            aux = None       
                 
    def getLongitud(self):
        return self.longitud
    
    def setLongitud(self, Longitud):
        self.longitud = Longitud