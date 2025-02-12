using System;

class Program
{
	
	static int Somar(int num1, int num2){
		return num1 + num2;
	}
	
	static void Main(string[] args){
    	
		Console.WriteLine("Digite um número");
		int numero1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Digite um outro número");
		int numero2 = int.Parse(Console.ReadLine());
		
		
		int resultado = Somar(numero1,numero2);
		
		Console.WriteLine("A soma de {0} e {1} é: {2} ",numero1, numero2 , resultado);
    	
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
