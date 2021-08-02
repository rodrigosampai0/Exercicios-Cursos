# Encontrar números primos é uma tarefa difícil. Faça um programa que gera uma lista 
# dos números primos existentes entre 1 e um número inteiro informado pelo usuário.


def lista_primos(numero = 0):
    for i in range(1, numero + 1):
        if (i % 2 == 1 and i > 1) or i == 2:
            print(i, end=' ')
    print()


if __name__ == '__main__':
    while True:
        numero = int(input('Digite um número: '))
        lista_primos(numero)
        continuar = str(input('Deseja continuar? [S/N] '))
        if continuar in 'Nn':
            break
