using System; 

class Program {
	public static void Main () {
		Console.WriteLine("Digite a distancia percorrida em Km:");

		int x = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite a quantidade de combustivel gasto:");

		double y = double.Parse(Console.ReadLine());

		double consumo = x / y;

		Console.WriteLine($"O consumo foi de {consumo:f3} km/l.");
	}
}