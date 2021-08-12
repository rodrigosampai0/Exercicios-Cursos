using System;
class aula08{
    static void Main(){
        int v1, v2, result;
        string nome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        
        Console.Write("Digite a distancia percorrida: ");
        v1 = int.Parse(Console.ReadLine()); // Primeiro metodo de conversão
        
        Console.Write("Digite a distancia total: ");
        v2 = Convert.ToInt32(Console.ReadLine()); // Segundo metodo de conversão

        result = v2 - v1;

        Console.WriteLine("Olá {0}, ainda falta {1} KM para percorrer.", nome, result);
    }
}