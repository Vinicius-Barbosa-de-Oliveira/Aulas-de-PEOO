using System;

class Program {
	public static void Main() {

		Console.WriteLine("Digite uma Palavra");
		int qtd = 0;
		int p = 1;

		string v = Console.ReadLine();
		//string x = k + i;

		foreach (char d in v){
			qtd += 1;
		}
		
		while (p <= qtd){
			string k = v.Substring(1);
			String i = v.Substring(0, 1);
			Console.WriteLine(k + i);
			v = k + i;
			p++;
		}
	}
}