from NodoCola import NodoCola

class Cola:
         
    def __init__(self):
        self.Cabeza = None
        self.Cola = None
        self.inicio = None
        
    def Encolar(self, mensaje, ip):
        if self.inicio != None:
            temp = self.inicio
            while temp.siguiente != None:
                temp = temp.siguiente
            temp.siguiente = NodoCola(mensaje, ip)

        else:
            self.inicio = NodoCola(mensaje, ip)
    
    '''def Desencolar(self, numero):
        aux = self.Cabeza
        if aux == None:
            print("Cola vacia")
        else:
            data = self.Cabeza.getDato()
            print("El dato a desencolar es: " + str(data))
            self.Cabeza = aux.Sig
            aux = None'''
    
    def Desencolar(self):
        if self.inicio != None:
            temp = self.inicio
            self.inicio = temp.siguiente
            return temp.mensaje + ";" + temp.ip   
    
    def mostrarCola(self):
        datoCola = ""
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                datoCola += (str(temp.ip)) + "," + (str(temp.mensaje)) + ";"
                temp = temp.siguiente        
            return str(datoCola)
        
    
    def ContarCola(self):
        longitudCola = 0
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                longitudCola += 1
                temp = temp.siguiente        
            return str(longitudCola)
        else:
            return "0" 
    
    
    def GraficarCola(self):
        dato = ""
        cont1 = 0
        if self.inicio != None:
            temp = self.inicio
            while temp!=None:
                dato += "\""+str(temp.ip) + "_nodo_" + str(cont1)+ "\"" + " [label=\""+str(temp.ip)+ "\n" +str(temp.mensaje)+"\"];\n"
                cont1=cont1+1
                temp = temp.siguiente
            cont1 = 0
            cont2 = cont1+1
            temp = self.inicio               
            while temp != None:
                if temp.siguiente!=None:
                    dato += "\""+str(temp.ip)+"_nodo_"+str(cont1)+"\""+"->"+ "\"" + str(temp.siguiente.ip)+"_nodo_"+str(cont2)+"\""+";\n"
                    cont1=cont1+1
                    cont2=cont2+1                    
                temp = temp.siguiente        
            return str(dato)