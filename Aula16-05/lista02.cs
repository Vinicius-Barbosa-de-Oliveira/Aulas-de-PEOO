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
		int s = ((m + n) / 5);
			
		Console.WriteLine($"Media parcial = {s}");
		Console.WriteLine("-----------------------");

		Console.WriteLine("Digite a base e a altura do retângulo:");
		double b = double.Parse(Console.ReadLine());
		double h = double.Parse(Console.ReadLine());

		double area = (b * h);
		double perimetro = ((b * 2) + (h * 2));
		double raiz = (b * b) + (h * h);
		double diagonal = Math.Sqrt(raiz);

		Console.WriteLine($"Área = {area:0.00}");
		Console.WriteLine($"Perímetro = {perimetro:0.00}");
		Console.WriteLine($"Diametro = {diagonal:0.00}");

	}
}