using System;
class Program
{
	
	static string Posiçao (string text){
		string resultados = "";
		
		for (int i = 0; i < text.Length; i+=2) {
			resultados +=text[i];
		}
		return resultados;
	}
	static void Main(string[] args){
		Console.WriteLine("Digite uma palavra:");
		string texto = Console.ReadLine();
		
		string resultado = Posiçao(texto);
		Console.WriteLine(resultado);
		
		
		
    	
    Console.WriteLine("Presione algo para sair . . . ");
	  Console.ReadKey(true);
    }
}
