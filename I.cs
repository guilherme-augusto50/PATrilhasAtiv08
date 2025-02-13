using System;

class Program
{
    static void Main()
    {
        int numero; 
        
        Console.WriteLine("Digite um número:");
        numero = int.Parse(Console.ReadLine());
        
        bool resultado = EhPrimo(numero);
        
        Console.WriteLine("O número {0} é primo? {1}",numero,resultado);
        
        Console.WriteLine("Precione algo para sair . . .");
        Console.ReadKey(true);
    }

    
    static bool EhPrimo(int numero)
    {
        
        if (numero <= 1)
            return false;

        
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
