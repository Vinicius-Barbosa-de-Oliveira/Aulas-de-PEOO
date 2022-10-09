using System;

class Program {
	public static void Main () {

		Console.WriteLine("Digite os tres valores:");

		string[] k = Console.ReadLine().Split();
		
		int valor1 = int.Parse(k[0]);
		int valor2 = int.Parse(k[1]);
		int valor3 = int.Parse(k[2]);

		int maior = 0;
		
		if (valor1 == valor2 && valor2 == valor3) {
			Console.WriteLine("Os valores são iguais.");
		}
		else {
			if (valor1 > valor2 && valor1 > valor3) {
			maior = valor1;
			}
			else {
				if (valor2 > valor1 && valor2 > valor3) {
					maior = valor2;
				}
				else {
					if (valor3 > valor1 && valor3 > valor2) {
					maior = valor3;
					}
				}	
			}
		}
		Console.WriteLine($"o maior valor: {maior}");

		int s1 = Math.Max(valor1, valor2);
			int s2 = Math.Max(s1, valor3);
		Console.WriteLine($"{s2} eh maior");

	}
}