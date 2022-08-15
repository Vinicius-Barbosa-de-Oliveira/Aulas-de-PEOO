using System;

class Program {
	public static void Main () {

		Console.WriteLine("digite o número de alunos:");

		int qtd = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite as notas dos alunos:");

		int notas = 0;
		int soma = 0;

	 	int k = qtd;
		
		while (k >= 1) {
			notas = int.Parse(Console.ReadLine());
			
			soma += notas;

			k -= 1;
		
		}

		Console.WriteLine($"Média das notas = {soma / qtd}");
	}
}