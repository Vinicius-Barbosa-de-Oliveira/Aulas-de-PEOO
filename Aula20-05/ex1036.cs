using System;
class Program{
	public static void Main (string[] args){

		Console.WriteLine("Digite os 3 valores");
		string[] v = Console.ReadLine().Split();
		double a = double.Parse(v[0]);
		double b = double.Parse(v[1]);
		double c = double.Parse(v[2]);

		double delta = Math.Sqrt((b * b) - 4 * a * c);
		if (delta < 0 || a == 0 ) Console.WriteLine("Impossivel calcular");
		else {
			double x1 = (-b + delta ) / (2 * a);
			double x2 = (-b - delta ) / (2 * a);
			Console.WriteLine($"R1 = {x1:f5}");
			Console.WriteLine($"R2 = {x2:f5}");
		}
	}
}