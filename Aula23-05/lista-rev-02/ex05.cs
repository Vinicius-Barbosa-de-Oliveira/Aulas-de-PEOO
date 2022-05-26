using System;
class Program {
	public static void Main (string[] args) {
		Console.WriteLine("Digite o mes");
		int mes = int.Parse(Console.ReadLine());


		switch (mes) {
			case 1 : Console.WriteLine("Janeiro, é do primeiro trimestre do ano"); break;
			case 2 : Console.WriteLine("Fevereiro, é do primeiro trimestre do ano"); break;
			case 3 : Console.WriteLine("Março, é do primeiro trimestre do ano"); break;
			case 4 : Console.WriteLine("Abril, é do segundo trimestre do ano"); break;
			case 5 : Console.WriteLine("Maio, é do segundo trimestre do ano"); break;
			case 6 : Console.WriteLine("Junho, é do segundo trimestre do ano"); break;
			case 7 : Console.WriteLine("Julho, é do terceiro trimestre do ano"); break;
			case 8 : Console.WriteLine("Agosto, é do terceiro trimestre do ano"); break;
			case 9 : Console.WriteLine("Setembro, é do terceiro trimestre do ano"); break;
			case 10 : Console.WriteLine("Outubro, é do quarto trimestre do ano"); break;
			case 11 : Console.WriteLine("Novembro, é do quarto trimestre do ano"); break;
			case 12 : Console.WriteLine("Dezembro, é do quarto trimestre do ano"); break;
	}
}