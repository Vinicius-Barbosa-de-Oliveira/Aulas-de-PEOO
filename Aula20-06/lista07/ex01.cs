using System;

class Program {
	public static Double Maior (double x, double y) {
		if (x > y) { 
			return x;
		}
		else {
			return y;
		}
	}
	public static void Main (){

		double x = double.Parse(Console.ReadLine());
		double y = double.Parse(Console.ReadLine());
		
		Console.WriteLine(Maior(x, y));
	}
}