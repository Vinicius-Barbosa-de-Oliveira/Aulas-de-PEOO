using System;

class Program {
	public static void Main() {

		Console.WriteLine("Digiite a Altura da caixa d'água:");
		double x = double.Parse(Console.ReadLine());
		Console.WriteLine("Digiite a Largura da caixa d'água:");
		double y = double.Parse(Console.ReadLine());
		Console.WriteLine("Digiite a Profundidade da caixa d'água:");
		double i = double.Parse(Console.ReadLine());

		Console.WriteLine(VolumeLitros(x, y, i));
	}
	public static double VolumeLitros(double h, double l, double p) {

		double v = h * l * p;
		return v;
	}
}