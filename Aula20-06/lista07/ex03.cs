using System;

class Program {
	public static string Iniciais(string nome, string y) {

		string y = "";

		string[] x = nome.ToLower().Split();
		
		foreach (string k in x) {

			if (k != "")
				y = k.Substring(0, 1).ToUpper();		
		}
		return y;
		
	}
	public static void Main (string[] args){
		string nome = Console.ReadLine();

		Console.WriteLine(Iniciais(y));
		
	}
}