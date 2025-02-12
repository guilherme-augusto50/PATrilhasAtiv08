using System;
class Program
{
	
	static int NUMEROint (int numero){
		if (numero % 2 ==0) {
			Console.WriteLine("O número e PAR ");
		} else {
			Console.WriteLine("O número e IMPAR");
		}
	
		return numero;
	}
	static void Main(string[] args){
		Console.WriteLine("Digite um número:");
		int num = int.Parse(Console.ReadLine());
		
		int resultado = NUMEROint(num);
		
		Console.WriteLine(resultado);
		
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
