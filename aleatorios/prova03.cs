 using System;

class Program {
	public static void Main() {
		Console.WriteLine("Digite o seu peso:");

		double x = double.Parse(Console.ReadLine());

		Console.WriteLine("Digite a sua altura:");

		double y = double.Parse(Console.ReadLine());

		Console.WriteLine($"o seu IMC é:{IMC(x, y)}");

		Console.WriteLine("Digite o número para contar os multiplos");

		int i = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"o número de multiplos são: {ContarMultiplos(i)}");
	}
	public static double IMC(double massa, double altura) {

		double cal = massa / (altura * altura);

		return cal;
	}
	public static int ContarMultiplos(int x) {

		int k = 1;
		int qtd = -1;
		int s1 = 0;

		while (s1 <= 1000) {
			s1 = x * k;
			k +=1;
			qtd += 1;
		}
		return qtd;
	}
}