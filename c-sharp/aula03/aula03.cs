using System;
class Aula03{
    static void Main(){
        int num = 0;
        byte num1 = 10; // 0 a 255
        char letra = 'a';
        float valor = 0.1f;
        string nome = "Aula03";

        var aux = 10;
        // var aux = nome;

        Console.WriteLine("Assistindo " + nome + " nota " + num1);

        int num01, num02, res;

        num01 = 10;
        num02 = 5;
        res = num01 + num02;
        
        Console.WriteLine("A soma de " + num01 + " + " + num02 + " = " + res);

        int num03 = 10, num04 = 4, res2 = num03 * num04;

        Console.WriteLine("A multiplicação de " + num03 + " * " + num04 + " = " + res2);

    }
}