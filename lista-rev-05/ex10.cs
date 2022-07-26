using System;

class Program {
	public static void Main() {

		Console.WriteLine("Digite a frase que deseja coletar as vogais:");

		string v = Console.ReadLine();

		Console.WriteLine(Vogais(v));
	}
	public static string Vogais(string s) {

		string s1 = "";

		foreach (char x in s) {
			switch (x) {
				case 'a': s1 += "a "; break;
				case 'e': s1 += "e "; break;
				case 'i': s1 += "i "; break;
				case 'o': s1 += "o "; break;
				case 'u': s1 += "u "; break;
			}
		}
		return s1;
	}
}