using System;

class Program {
	public static void Main () {

		Console.WriteLine("digite o primeiro valor:");

		int x1 = int.Parse(Console.ReadLine());
		int x2 = int.Parse(Console.ReadLine());
		int x3 = int.Parse(Console.ReadLine());

		int k1 = Math.Min(x1, x2);
		int k2 = Math.Min(k1, x3);

		Console.WriteLine($"Soma dos Maiores = {(x1 + x2 + x3) - k2}");

	}
}