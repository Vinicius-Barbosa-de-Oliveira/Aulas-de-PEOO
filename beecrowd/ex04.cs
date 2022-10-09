using System;

class Program {
	public static void Main () {
		Console.WriteLine("Digite o tempo da viagem:");

		int x = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite a velocidade media da viagem");

		int y = int.Parse(Console.ReadLine());

		double km = x * y;

		double consumo = km / 12;

		Console.WriteLine($"{consumo:f3}");
	}
}