using System;
class aula06{

    static void Main(){

        // int n1, n2, n3;

        // n1 = 10; n2 = 20; n3 = 30;

        // Console.WriteLine(n1 + ", " + n2 + ", " + n3);
        // Console.WriteLine("{0}, {1}, {2}",n1,n2,n3);
        // Console.WriteLine("\n\t{0}\n\t\t{1}\n\t\t\t{2}\n",n1,n2,n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro= 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto........:{0,14}", produto);
        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra); // c = R$
        Console.WriteLine("Lucro..........:{0,14:p}", lucro); // p = %
        Console.WriteLine("Val.Venda......:{0,15:c}", valorVenda); // c = R$
    }
}