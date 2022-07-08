using System;

class Program {
	public static string Iniciais(string nome) {

		string b;

		string[] x = nome.ToLower().Split();
		
		foreach (string k in x) {

			if (k != "")
			b = k.Substring(0, 1).ToUpper();		
		}
		return b;
		
	}
	public static void Main (string[] args){
		
		string nome = Console.ReadLine();
//	Iniciais(nome);
		Console.WriteLine(Iniciais(b));
		
	}
}