using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite os valores");
		int a1 = int.Parse(Console.ReadLine());
		int a2 = int.Parse(Console.ReadLine());

		Console.WriteLine("numero maior ou igual");
			
		if (a1 > a2) Console.WriteLine(a1);
		if (a2 > a1) Console.WriteLine(a2);
		if (a1 == a2) Console.WriteLine("sao numeros iguais");
		
		Console.WriteLine("-------------------------------");

		Console.WriteLine("Digite as quatro notas do bimestre");
		int m1 = int.Parse(Console.ReadLine());
		int m2 = int.Parse(Console.ReadLine());
		int m3 = int.Parse(Console.ReadLine());
		int m4 = int.Parse(Console.ReadLine());

		int media = (m1 + m2 + m3 + m4) / 4 ;
		Console.WriteLine($"MEDIA = {media}");
		
		Console.WriteLine("maior numero ou igual das notas");
		if (m1 > m2) Console.WriteLine(m1);
		if (m2 > m3) Console.WriteLine(m2);
		if (m3 > m4) Console.WriteLine(m3);
		else Console.WriteLine(m4);

		if (m1 == media || m2 == media || m3 == media || m4 == media) Console.WriteLine("tem numero igual ao resultado da media");

		Console.WriteLine("-------------------------------");

		Console.WriteLine("Numeros da soma");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		int n4 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Resultados");
		if ((n1 + n2) % 2 == 0) Console.WriteLine(n1 + n2);
		if ((n1 + n3) % 2 == 0) Console.WriteLine(n1 + n3);
		if ((n1 + n4) % 2 == 0) Console.WriteLine(n1 + n4);
		if ((n2 + n3) % 2 == 0) Console.WriteLine(n2 + n3);
		if ((n2 + n4) % 2 == 0) Console.WriteLine(n2 + n4);
		if ((n3 + n4) % 2 == 0) Console.WriteLine(n3 + n4);

	
			
		
		Console.WriteLine("-------------------------------");
		Console.WriteLine("-------------------------------");

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
		Console.WriteLine("-------------------------------");

		Console.WriteLine("Digite tres valores");
		int v1 = int.Parse(Console.ReadLine());
		int v2 = int.Parse(Console.ReadLine());
		int v3 = int.Parse(Console.ReadLine());

		if (v1 > v2 && v2 > v3 && v1 > v2 && v2 < v3){
			Console.WriteLine($"Soma = {v1 + v2}");}
			 else if (v1 < v2 && v2 > v3 && v1 > v2 && v2 < v3){
				Console.WriteLine($"Soma = {v2 + v1}");}
				else if (v1 < v2 && v2 > v3 && v1 > v2 && v2 > v3){
				Console.WriteLine($"Soma = {v2 + v3}");}
					else if (v1 < v2 && v2 < v3 && v1 < v2 && v2 < v3){
					Console.WriteLine($"Soma = {v3 + v1}");
					}
				
			
		
	}
}