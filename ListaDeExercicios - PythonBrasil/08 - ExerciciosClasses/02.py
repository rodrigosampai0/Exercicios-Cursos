# Classe Quadrado: Crie uma classe que modele um quadrado:
#   a. Atributos: Tamanho do lado
#   b. Métodos: Mudar valor do Lado, Retornar valor do Lado e calcular Área;


class Quadrado:

    def __init__(self, tamanho_lado = 0):
        self.tamanho_lado = tamanho_lado

    def mudarLado(self):
        self.tamanho_lado = int(input('Digite o valor do lado: '))
        return self.tamanho_lado
    
    def areaQuadro(self):
        area = (self.tamanho_lado * self.tamanho_lado)
        return print(f'Com cada lado medindo {self.tamanho_lado}, a area do quandodo é {area}')


if __name__ == '__main__':
    quadrado = Quadrado()
    quadrado.mudarLado()
    quadrado.areaQuadro()