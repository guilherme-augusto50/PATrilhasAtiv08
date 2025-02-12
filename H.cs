using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
	
	static double numeros(List<int> num){
		
		double soma  = num.Sum();
		double media = soma / num.Count;
	
		return media;
	}
	static void Main(string[] args){
		List<int> num = new List<int>{ 10,20,30,40,50 };
		
		double media = numeros(num);
		
		Console.WriteLine("A média dos números  é:"+media);
		
		
    	
    Console.WriteLine("Presione algo para sair . . . ");
	Console.ReadKey(true);
    }
}
