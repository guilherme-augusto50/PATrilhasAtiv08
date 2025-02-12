using System;

class Program
{
	
	static int quadrado(int numero){
		return numero * numero;
	}
	
	static void Main(string[] args){
    	
		Console.WriteLine("Escreva eum número:");
		int num = int.Parse(Console.ReadLine());
		
		int resultado = quadrado(num);
		
		Console.WriteLine("O qudrado  de {0} é: {1}", num, resultado);
    	
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
