using System;
class Program {
	public static void Main () {
		Console.WriteLine("Digite Seu Primeiro Nome:");
		string x = Console.ReadLine();
		Console.WriteLine($"Bem Vindo ao C#, {x}");
    Console.WriteLine("-----------------------");

		Console.WriteLine("Digite seu nome completo:");
		string y = Console.ReadLine();
		string[] v = y.Split();
		Console.WriteLine($"Bem Vindo ao C#, {v[0]}");
		Console.WriteLine("-----------------------");

		Console.WriteLine("Digite a nota do primeiro bimestre da diciplina");
		int i = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a nota do segundo bimestre da diciplina");
		int k = int.Parse(Console.ReadLine());

		int m = (i * 2);
		int n = (k * 3);
		int s = (i + k / 2);
			
		Console.WriteLine($"Media parcial = {s}");

	}
}