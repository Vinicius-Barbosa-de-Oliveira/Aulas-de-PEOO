using System;

class Program {
	public static void Main () {

		Console.WriteLine("Digite o Nome do funcinario:");

		string nome = Console.ReadLine();

		Console.WriteLine("Digite o salario do funcinario:");

		double salario = double.Parse(Console.ReadLine());

		Console.WriteLine("Digite o valor da comissão:");

		double comissao = double.Parse(Console.ReadLine());

		double k = (comissao * 0.15) + salario;

		Console.WriteLine($"TOTAL = R$ {k:f2}");

		//Console.WriteLine($"O total do Funcionario: {nome} é {k:f2}");
		//Console.WriteLine($"O total do Funcionario: {nome} é {Comissao(comissao, salario):f2}");

	}
	public static double Comissao (double x, double y) {
		
		double k = (x * 0.15) + y;
		return k;
		
	}
}