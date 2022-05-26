using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Valores pra organizar:");
		int x1 = int.Parse(Console.ReadLine());
		int x2 = int.Parse(Console.ReadLine());
		int x3 = int.Parse(Console.ReadLine());

		int menor = 0;
		int medio = 0;
		int maior = 0;

		if (x1 > x2 && x1 > x3) {maior = x1;}
		else if (x2 > x1 && x2 > x3) {maior = x2;}
		else if (x3 > x1 && x3 > x2) {maior = x3;}

		if (x1 > x2 && x1 < x3) {medio = x1;}
		else if (x2 > x1 && x2 < x3) {medio = x2;}
		else if (x3 > x1 && x3 < x2) {medio = x3;}
		
		if (x1 > x3 && x1 < x2) {medio = x1;}
		else if (x2 > x3 && x2 < x1) {medio = x2;}
		else if (x3 > x2 && x3 < x1) {medio = x3;}

		if (x1 < x2 && x1 < x3) {menor = x1;}
		else if (x2 < x1 && x2 < x3) {menor = x2;}
		else if (x3 < x1 && x3 < x2) {menor = x3;}

		Console.WriteLine("Em ordem crescente: {0}, {1}, {2}", menor, medio, maior);


	}
}