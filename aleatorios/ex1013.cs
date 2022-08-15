using System;

class Program {

	public static void Main () {

		Console.WriteLine("Digite os três valores separados por espaços:");

		string[] entrada = Console.ReadLine().Split();

		int n1 = int.Parse(entrada[0]);
		int n2 = int.Parse(entrada[1]);
		int n3 = int.Parse(entrada[2]);

		int maior = 0;
				
	 	if (n1 > n2 && n1 > n3) {
			maior += n1;
		}
	 	if (n2 > n1 && n2 > n3) {
			maior += n2;
		}
	 	if (n3 > n2 && n3 > n1) {
			maior += n3;
		}

		Console.WriteLine($"{maior} eh o maior");

	}
}