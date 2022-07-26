using System;

class Program {
	public static void Main() {
		Console.WriteLine("Digite o valor que deseja compara com o intero:");

		double y = double.Parse(Console.ReadLine());

		Console.WriteLine(MenorInteiro(y));
		
	}
	public static int MenorInteiro(double x) {

		int i = (int) x;
		if (x == i) {
			return i;
		}
		else {
			return i + 1;
		}
	}
}