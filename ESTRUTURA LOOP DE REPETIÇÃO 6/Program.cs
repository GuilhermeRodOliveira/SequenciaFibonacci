using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Os primeiros 10 números da sequência de Fibonacci:");

        int a = 0, b = 1;
        int count = 0;
        
        //Colocar para o usuario digitar o limite de contagem

        // Imprimir os primeiros 10 números da sequência de Fibonacci
        while (count < 10)
        {
            Console.Write(a + " ");

            int temporario = a;
            a = b;
            b = temporario + b;

            count++;
            
        }

        Console.WriteLine();
    }
}
