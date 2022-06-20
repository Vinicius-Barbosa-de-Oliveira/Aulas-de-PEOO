using System;

class Program {
	public static void Main (string[] args) {

		int i = 1;
		while (i <= 10) {
			Console.WriteLine(i);
			i++;
		}
		//Console.WriteLine("escreva o i após a repetição");
		//Console.WriteLine(i);
		//---------------------------------
		Console.WriteLine("testando o dowhile");
		i = 1;
		do {
			Console.WriteLine(i);
			i++;
		}while (i <= 10);
		//---------------------------------
		Console.WriteLine("testendo com o for");
		for (i = 1; i <= 10; i++) {
			Console.WriteLine(i);
		}
		//---------------------------------
		Console.WriteLine("testando com o foreach (int)");
		int[] v = { 5, 9, 2, 1, 7};
		foreach (int x in v) {
			Console.WriteLine(x);
			//Console.WriteLine("Maria Cândida");
		}
		Console.WriteLine("testando com o foreach (string)");
		string[] y = { "5", "9", "2", "1", "7"};
		foreach (string c in y)
			Console.WriteLine(c);
		//---------------------------------
		Console.WriteLine("testando com o foreach (char)");
		string d = "informatica para internet";
		foreach (char p in d)
			Console.WriteLine(p);
	}
}