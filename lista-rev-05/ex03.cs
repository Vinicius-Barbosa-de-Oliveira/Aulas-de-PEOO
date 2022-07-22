using System;

class Program {
	public static void Main() {

		Console.WriteLine("digite a base do triangulo");
		double y = double.Parse(Console.ReadLine());
		Console.WriteLine("digite a altura do triangulo");
		double x = double.Parse(Console.ReadLine());

		Console.WriteLine(Diagonal(y, x));
	}
	public static double Diagonal(double b, double h) {

		double r = ((b * b) + (h * h));
		double a = Math.Sqrt(r);
		return a;
	}
}