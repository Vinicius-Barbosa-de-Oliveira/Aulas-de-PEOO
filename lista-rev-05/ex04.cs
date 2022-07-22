using System;

class Program {
	public static void Main() {
		Console.WriteLine("digite o raio");

		double i = double.Parse(Console.ReadLine());

		Console.WriteLine(VolumeEsfera(i));
	}
	public static double VolumeEsfera(double r) {

		double pi = 3.14;

		double x = (r * r * r);
		double y = (4 * pi * x) / 3;
		return y;
	}
}