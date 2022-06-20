using System;

class Program {
	public static double Maior (double x, double y, double z){
		if (x > y && x > z) { 
			return x;
		}
		if (y > x && y > z) {
			return y;
		}
		if (z > x && z > y) {
			return z;
		}
	}
	public static void Main (string[] args){
		double x = double.Parse(Console.WriteLine());
		double y = double.Parse(Console.WriteLine());
		double z = double.Parse(Console.WriteLine());

		Console.WriteLine(Maior(x, y, z));
	}
}