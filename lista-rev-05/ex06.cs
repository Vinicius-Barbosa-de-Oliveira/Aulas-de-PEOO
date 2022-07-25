using System;

class Program {
	public static void Main() {
		Console.WriteLine("Digite os Quilometros rodados:");
		double x = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite a quantidade de quilos");
		double y = double.Parse(Console.ReadLine());

		Console.WriteLine(Frete(y, x));
		
	}
	public static double Frete(double massa, double distancia){

		double v = distancia * massa;
		double k = v * 0.1;
		return k;
	}
}