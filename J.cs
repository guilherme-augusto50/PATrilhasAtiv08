using System;
using System.Collections.Generic;

class Program
{
	
	static int Maior(List<int> num){
		 int Mei = num[0];
		 foreach (int numero in num) {
		 	if (numero < Mei ) {
		 		Mei = numero;
		 	}
		 } 
		 return Mei;
	}
	
	static void Main(string[] args){
    	
		List<int> numeros = new List<int> {12,20,35,45,80,9,1};
		
		int maior = Maior(numeros);
		
		Console.WriteLine("O maior número  da lista é:{0}", maior);
    	
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
