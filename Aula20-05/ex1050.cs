using System;
class Program {
	public static void Main () {

		Console.WriteLine("Digite o DDD");

		int D = int.Parse(Console.ReadLine());

	 	switch (D) {

			case D == 61: Console.WriteLine("Brasilia"); break;
			case D == 71: Console.WriteLine("Salvador"); break;
			case D == 11: Console.WriteLine("Sao Paulo"); break;
			case D == 21: Console.WriteLine("Rio de Janeiro"); break;
			case D == 32: Console.WriteLine("Juiz de Fora"); break;
			case D == 19: Console.WriteLine("Campinas"); break;
			case D == 27: Console.WriteLine("Vitoria"); break;
			case D == 31: Console.WriteLine("Belo Horizonte"); break;
			default: Console.WriteLine("DDD nao cadastrado");
		}
	}
}