using System;
class Program{
	public static void Main(string[] args){

		Console.WriteLine("Digite as horas gasta:");
		int x = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite a velocidade media em Km/h");
		int y = int.Parse(Console.ReadLine());

		double cal = (x * y) / 12.0;

		Console.WriteLine($"{cal:0.000}");
		
	}
}