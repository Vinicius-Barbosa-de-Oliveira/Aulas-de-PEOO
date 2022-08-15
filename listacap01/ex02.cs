using System;

class Program {
	public static void Main () {

		Console.WriteLine("digite o primeiro valor:");

		int x1 = int.Parse(Console.ReadLine());

		Console.WriteLine("digite o segundo valor:");

		int x2 = int.Parse(Console.ReadLine());

		Console.WriteLine($"SOMA = {x1 + x2}");
	}
}