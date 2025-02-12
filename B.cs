using System;

class Program
{
	
	static int texto(string caraceres){
		return caraceres.Length;
	}
	
	static void Main(string[] args){
    	
		Console.WriteLine("Digite uma palavra");
		string tex =(Console.ReadLine());
		
		int resultado = texto(tex);
		
		Console.WriteLine("A string '{0}' tem: {1} caracteres ", tex, resultado);
    	
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
