using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite os coeficiente de a, b e c:");
		double a = double.Parse(Console.ReadLine());
		double b = double.Parse(Console.ReadLine());
		double c = double.Parse(Console.ReadLine());

		double delta = Math.Sqrt((b * b) - 4 * a * c);
		if (delta < 0 || a == 0 ) Console.WriteLine("Impossivel calcular");
		else {
			double x1 = (-b + delta ) / (2 * a);
			double x2 = (-b - delta ) / (2 * a);
			Console.WriteLine($"as raizes sao {x1} e {x2}");
		}
	}
}