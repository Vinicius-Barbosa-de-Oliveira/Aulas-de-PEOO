using System;

class Program {
	public static void Main() {

		//Console.WriteLine("Digite o seu Peso:");

		IMC x = new IMC ();
		x.SetPeso(75.5);
		x.SetAltura(1.80);

		double imc = x.CalcIMC();
		Console.WriteLine($"{imc:f4}");
	}
}
class IMC {
	private double Peso, Altura;

	public void SetPeso (double p) {
		if (p > 0) Peso = p;
	}
	public void SetAltura (double a) {
		if (a > 0) Altura = a;
	}
	public double GetPeso () {
		return Peso;
	}
	public double GetAltura () {
		return Altura;
	}
	public double CalcIMC () {
		return Peso / (Altura * Altura);
	}
	
}