using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("digite os tres valores:");

		int x1 = int.Parse(Console.ReadLine());
		int x2 = int.Parse(Console.ReadLine());
		int x3 = int.Parse(Console.ReadLine());

		if ((x1 + x2) > x3) {
		if (x1 == x2 && x1 == x3 && x1 == x3) {Console.WriteLine("Esses valores formam um triangulo equilátero");}
		
		else if (x1 == x2 && x1 != x3) {Console.WriteLine("Esses valores formam um triagulo isoceles");}

		else if (x2 == x3 && x2 != x1) {Console.WriteLine("Esses valores formam um triagulo isoceles");}
			
		else if (x3 == x1 && x2 != x3) {Console.WriteLine("Esses valores formam um triagulo isoceles");}

		else if (x1 != x2 && x2 != x3 && x3 != x1) {Console.WriteLine("Esses valores formam um triagulo escaleno");}
		}
		else {Console.WriteLine("isso n é um triagulo");}
	}
}