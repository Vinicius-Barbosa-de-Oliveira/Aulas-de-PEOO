using System;
class Program{
	public static void Main (string[] args) {
		
		Console.WriteLine("Digite os Valores para teste");
		string[] v = Console.ReadLine().Split();
		int a = int.Parse(v[0]);
		int b = int.Parse(v[1]);

		if ((b % a) == 0) Console.WriteLine("Sao Multiplos");
		else Console.WriteLine("Nao sao Multiplos");
	}
}