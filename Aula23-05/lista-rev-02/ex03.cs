using System;
class Program {
	public static void Main (string[] args) {
		Console.WriteLine("Numeros da soma");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		int n4 = int.Parse(Console.ReadLine());
		
	/*	Console.WriteLine("Resultados 01- semi fracasso");
		if (n1 % 2 != 0 && n2 % 2 != 0) Console.WriteLine("soma dos impares = " + (n1 + n2));
		if (n1 % 2 != 0 && n3 % 2 != 0) Console.WriteLine("soma dos impares = " + (n1 + n3));
		if (n1 % 2 != 0 && n4 % 2 != 0) Console.WriteLine("soma dos impares = " + (n1 + n4));
		if (n2 % 2 != 0 && n3 % 2 != 0) Console.WriteLine("soma dos impares = " + (n2 + n3));
		if (n2 % 2 != 0 && n4 % 2 != 0) Console.WriteLine("soma dos impares = " + (n2 + n4));
		if (n3 % 2 != 0 && n4 % 2 != 0) Console.WriteLine("soma dos impares = " + (n3 + n4));
		
		if (n1 % 2 == 0 && n2 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n2));
		if (n1 % 2 == 0 && n3 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n3));
		if (n1 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n4));
		if (n2 % 2 == 0 && n3 % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n3));
		if (n2 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n4));
		if (n3 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n3 + n4));
		Console.WriteLine("Resultados 02 = fracasso");
		if ((n1 + n2 + n3 + n4) % 2 == 0) Console.WriteLine(n1 + n2 + n3 +n4);
		if ((n2 + n3 + n4) % 2 == 0) Console.WriteLine(n2 + n3 + n4);
		if ((n1 + n3 + n4) % 2 == 0) Console.WriteLine(n1 + n3 + n4);
		if ((n1 + n2 + n4) % 2 == 0) Console.WriteLine(n1 + n2 + n4);
		if ((n1 + n2 + n3) % 2 == 0) Console.WriteLine(n1 + n2 + n3);
		
		Console.WriteLine("Resultados 03- semi fracasso");
		if ((n1 + n2) % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n2));
		if ((n1 + n3) % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n3));
		if ((n1 + n4) % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n4));
		if ((n2 + n3) % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n3));
		if ((n2 + n4) % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n4));
		if ((n3 + n4) % 2 == 0) Console.WriteLine("soma dos pares = " + (n3 + n4));*/
		Console.WriteLine("Resultados 04 - sucesso");
		int s1 = 0;
		int s2 = 0;
		int s3 = 0;
		int s4 = 0;
		if (n1 % 2 == 0) {
			s1 += n1;
		}
		if (n2 % 2 == 0) {
			s1 += n2;
		}
		if (n3 % 2 == 0) {
			s1 += n3;
		}
		if (n4 % 2 == 0) {
			s1 += n4;
		}
		if (n1 % 2 == 0) {
			s2 += n1;
		}
		if (n2 % 2 == 0) {
			s2 += n2;
		}
		if (n3 % 2 == 0) {
			s2 += n3;
		}
		if (n4 % 2 == 0) {
			s2 += n4;
		}
		if (n1 % 2 != 0) {
			s3 += n1;
		}
		if (n2 % 2 != 0) {
			s3 += n2;
		}
		if (n3 % 2 != 0) {
			s3 += n3;
		}
		if (n4 % 2 != 0) {
			s3 += n4;
		}
		if (n1 % 2 != 0) {
			s4 += n1;
		}
		if (n2 % 2 != 0) {
			s4 += n2;
		}
		if (n3 % 2 != 0) {
			s4 += n3;
		}
		if (n4 % 2 != 0) {
			s4 += n4;
		}
		
		Console.WriteLine("pares = "+ (s1 + s2) / 2);
		Console.WriteLine("impares = "+ (s3 + s4) / 2);
	}
}