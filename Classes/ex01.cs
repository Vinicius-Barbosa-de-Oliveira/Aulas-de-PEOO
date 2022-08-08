using System;

class Program {
	public static void Main () {

		Console.WriteLine("Digite o raio do seu circulo:");

		double x = double.Parse(Console.ReadLine());

		circulo C1 = new circulo();

		C1.raio = x;

		Console.WriteLine($"A area do seu circulo é: {C1.AreaCirculo()}");
		Console.WriteLine($"A circunferência do seu circulo é: {C1.Circunferencia():f2}");
	}
}
class circulo {

	public double raio;
	double pi = 3.1415;

	public double AreaCirculo () {
		
		return (raio * raio) * pi;
		
	}
	public double Circunferencia () {

		return (pi * pi) * raio;
		
	}
	
}