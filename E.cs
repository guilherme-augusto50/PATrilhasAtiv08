using System;
using System.Collections.Generic;

class Program
{
	
	static string Maior(List<string> palavra){
		string resultado = string.Join("",palavra);
		 return resultado;
	}
	
	static void Main(string[] args){
    	
		List<string> palavras  = new List<string> {"Cristian"," " ,"Joao"," ", "Caio"};
		
		
		string resultados = Maior(palavras );
		Console.WriteLine(resultados);
		
		Console.WriteLine(resultados);
    	
    Console.WriteLine("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
