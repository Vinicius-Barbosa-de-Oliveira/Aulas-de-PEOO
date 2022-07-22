using System;

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("digite os valores, para receber o maior deles");
		double i = double.Parse(Console.ReadLine());
		double k = double.Parse(Console.ReadLine());
		Console.WriteLine(Menor(i, k));
	}
	public static double Menor (double x, double y) {
		if (x > y) {
			return x;
			}
		else {
			return y;
		}
	}
}