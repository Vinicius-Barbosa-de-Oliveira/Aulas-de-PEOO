using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite os valores");
		int a1 = int.Parse(Console.ReadLine());
		int a2 = int.Parse(Console.ReadLine());

		Console.WriteLine("numero maior ou igual");
			
		if (a1 > a2) Console.WriteLine(a1);
		if (a2 > a1) Console.WriteLine(a2);
		if (a1 == a2) Console.WriteLine("sao numeros iguais");
	}
}