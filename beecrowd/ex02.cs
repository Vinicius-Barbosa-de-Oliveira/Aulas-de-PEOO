using System;

class Program {
	public static void Main () {
		Console.WriteLine("Digite a distancia dos carros em km:");

		int x = int.Parse(Console.ReadLine());

		int min = x * 2;

		Console.WriteLine($"O tempo levado para ter essa distancia entre os carros é de {min} minutos.");
	}
}