# Os números primos possuem várias aplicações dentro da Computação, por exemplo na Criptografia.
# Um número primo é aquele que é divisível apenas por um e por ele mesmo. Faça um programa que 
# peça um número inteiro e determine se ele é ou não um número primo.


def primo(numero = 0):
    if (numero % 2 == 1 and numero > 1) or numero == 2:
        print('Primo')
    else:
        print('Não é primo')

if __name__ == "__main__":
    while True:
        numero = int(input('Digite um número: '))
        primo(numero)
        continuar = str(input('Deseja continuar? [S/N] '))
        if continuar in 'Nn':
            break
