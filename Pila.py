from NodoPila import NodoPila

class Pila():
    def __init__ (self):
        self.inicio = None
        self.ultimo = None        
   
    def agregarPila(self, dato):
        if self.ultimo != None:
            temp = self.ultimo
            self.ultimo = NodoPila(dato)
            self.ultimo.siguiente = temp
        else:
            self.ultimo = NodoPila(dato)
            
    def sacarPila(self):
        if self.ultimo != None:
            temp = self.ultimo
            self.ultimo = temp.siguiente
            return temp.dato
        
    def mostrarPila(self):
        if self.ultimo != None:
            temp = self.ultimo
            print ("\nLos datos de la pila son: ")
            while temp != None:
                print (str(temp.dato))
                temp = temp.siguiente
            
                