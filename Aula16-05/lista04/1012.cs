using System;
class Program{
	public static void Main(string[] args) {

		Console.WriteLine("Digite os valores");
		string[] x = Console.ReadLine().Split(' ');
		
		double a = double.Parse(x[0]);
		double b = double.Parse(x[1]);
		double c = double.Parse(x[2]);

		const double pi = 3.14159;

		double triangulo = ((a * c) / 2);
		double circulo = (pi * (c * c));
		double trapezio = (((a + b) * c) / 2);
		double quadrado = (b * b);
		double retangulo = (a * b);

		Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
		Console.WriteLine($"CIRCULO: {circulo:0.000}");
		Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
		Console.WriteLine($"QUADRADO: {quadrado:0.000}");
		Console.WriteLine($"RETANGULO: {retangulo:0.000}");
	}
}