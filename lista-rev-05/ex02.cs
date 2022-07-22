using System;

class Program {
	public static void Main() {

		Console.WriteLine("digite o valor do raio");

		double x = double.Parse(Console.ReadLine());

		/*double i = AreaCirculo(x);
		Console.WriteLine(i);*/
		Console.WriteLine(AreaCirculo(x));
		
	}
	public static Double AreaCirculo(double raio) {
		double pi = 3.1415;

		double k = ((raio * raio) * pi);
			return k;
		
	}
}