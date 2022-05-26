using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digitar 4 valores inteiros:");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());

		if (a != b && c != d && a != c) {
			if (a > b && a > c && a > d) Console.WriteLine("Maior Valor = {0}", a);
			if (b > a && b > c && b > d) Console.WriteLine("Maior Valor = {0}", b);
			if (c > a && c > b && c > d) Console.WriteLine("Maior Valor = {0}", c);
			if (d > a && d > b && d > c) Console.WriteLine("Maior Valor = {0}", d);
			
			if (a < b && a < c && a < d) Console.WriteLine("Menor Valor = {0}", a);
			if (b < a && b < c && b < d) Console.WriteLine("Menor Valor = {0}", b);
			if (c < a && c < b && c < d) Console.WriteLine("Menor Valor = {0}", c);
			if (d < a && d < b && d < c) Console.WriteLine("Menor Valor = {0}", d);
		}
		int s1 = 0;
		int s2 = 0;

		if (a > b && b > c && c < d) s1 += a;
		if (b > c && c > d && d < a) s1 += b;
		if (c > d && d > a && a < b) s1 += c;
		if (d > a && a > b && b < c) s1 += d;

		Console.WriteLine(s1);
		/*if (a > b && a > c && a < d) {
			s1 += a;
		}
		if (b > a && b > d && b < c) {
			s1 += b;
		}
		if (c > b && c > c && c < b) {
			s1 += c;
		}
		if (d > b && d > c && d < a) {
			s1 += d;
		}

		if (a < b && a < c && a > d) {
			s2 += a;
		}
		if (b < b && b < d && b > c) {
			s2 += b;
		}
		if (c < b && c < c && c > b) {
			s2 += c;
		}
		if (d < b && d < c && d > a) {
			s2 += d;
		}*/

		//int x1 = s1 + s2;
		
		//Console.WriteLine(x1);



		
	/*	if (a > b && a > c && a < d) (b < c) Console.WriteLine("Soma = " + (a + b));
		if (a > b && a > c && a < d) (c < b) Console.WriteLine("Soma = " + (a + c));
		if (b > a && b > c && b < d) (a < c) Console.WriteLine("Soma = " + (b + a));
		if (b > a && b > c && b < d) (c < a) Console.WriteLine("Soma = " + (b + c));
		if (c > a && c > b && c < d) (a < b) Console.WriteLine("Soma = " + (c + a));
		if (c > a && c > b && c < d) (b < a) Console.WriteLine("Soma = " + (c + b));
		
		if (d > a && d > b && d < c) (a < b) Console.WriteLine("Soma = " + (d + a));
		if (d > a && d > b && d < c) (b < a) Console.WriteLine("Soma = " + (d + b));
		if (a > b && a > d && a < c) (b < d) Console.WriteLine("Soma = " + (a + b));
		if (a > b && a > d && a < c) (d < b) Console.WriteLine("Soma = " + (a + d));
		if (b > a && b > d && b < c) (a < d) Console.WriteLine("Soma = " + (b + a));
		if (b > a && b > d && b < c) (d < a) Console.WriteLine("Soma = " + (b + d));
		
		if (a > c && a > d && a < b) (d < c) Console.WriteLine("Soma = " + (a + d));
		if (a > c && a > d && a < b) (c < d) Console.WriteLine("Soma = " + (a + c));
		if (d > a && d > c && d < b) (a < c) Console.WriteLine("Soma = " + (d + a));
		if (d > a && d > c && d < b) (c < a) Console.WriteLine("Soma = " + (d + c));
		if (c > a && c > d && c < b) (a < d) Console.WriteLine("Soma = " + (c + a));
		if (c > a && c > d && c < b) (d < a) Console.WriteLine("Soma = " + (c + d));
		
		if (b > c && b > d && b < a) (c < d) Console.WriteLine("Soma = " + (b + c));
		if (b > c && b > d && b < a) (d < c) Console.WriteLine("Soma = " + (b + d));
		if (c > b && c > d && c < a) (b < d) Console.WriteLine("Soma = " + (c + b));
		if (c > b && c > d && c < a) (d < b) Console.WriteLine("Soma = " + (c + d));
		if (d > b && d > c && d < a) (b < c) Console.WriteLine("Soma = " + (d + b));
		if (d > b && d > c && d < a) (c < b) Console.WriteLine("Soma = " + (d + c));*/
	}
}