using System;

class program {
	public static void Main() {

		Console.WriteLine("Digite o texto:");
		string v = Console.ReadLine();
		Console.WriteLine("Digite a possição");
		int x = int.Parse(Console.ReadLine());

		Console.WriteLine(Palavra(v, x));
	}
	public static string Palavra(string texto, int pos) {

		//texto = texto.Substring(pos);
		string s3 = texto;
		string s4 = s3.Substring(pos, 1);

		int s1 = s4.IndexOf(' ');

		string s2 = texto.Substring(pos, s1);

		return s2;
	}
}