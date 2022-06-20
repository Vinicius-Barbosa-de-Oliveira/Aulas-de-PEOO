using System;

class Program {
	public static double Maior(double x, double y, double z){
		if (x > y && x > z) { 
			return x;
		}
		else {
			if (y > x && y > z){
				return y;
			}
			else return z;
		}
	
	}
	public static void Main (string[] args){
		double x = double.Parse(Console.ReadLine());
		double y = double.Parse(Console.ReadLine());
		double z = double.Parse(Console.ReadLine());

		Console.WriteLine(Maior(x, y, z));
	}
}