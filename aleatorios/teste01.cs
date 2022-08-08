using System;

class Program {
	public static void Main () {

		Console.WriteLine("Digite a raio do circulo:");

		double x = double.Parse(Console.ReadLine());

		Console.WriteLine($"{AreaTriangulo(x):f2}");
	}
	public static double AreaTriangulo(double raio) {

		double pi = 3.1415;

		double calculo = (raio * raio) * pi;

		return calculo;
	}
}