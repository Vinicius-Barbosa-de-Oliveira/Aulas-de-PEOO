using System;
class Program {
	public static void Main (string[] args) {
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
					Console.WriteLine($"Soma = {v3 + v1}");}
	}
}