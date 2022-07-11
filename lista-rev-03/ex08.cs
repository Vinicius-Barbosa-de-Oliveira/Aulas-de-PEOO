using System;

class Program {
	public static void Main() {

		Console.WriteLine("Coloque a frase:");
		string x = Console.ReadLine();

		int s1;
		int s2;

    s1 = x.IndexOf(' ');
		s2 = s1 - 1;
		while (s1 != -1) {
			string k = x.Substring(s2, 1);
			Console.Write(k);
			x = x.Substring(s1 + 1);
			s1 = x.IndexOf(' ');
			s2 = s1 - 1;
		}
	}
}