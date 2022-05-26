using System;
class Program {
	public static void Main (string[] args) {
		Console.WriteLine("Numeros da soma");
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		int n4 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Resultados 01");
		if (n1 % 2 == 1 && n2 % 2 == 1) Console.WriteLine("soma dos impares = " + (n1 + n2));
		if (n1 % 2 == 1 && n3 % 2 == 1) Console.WriteLine("soma dos impares = " + (n1 + n3));
		if (n1 % 2 == 1 && n4 % 2 == 1) Console.WriteLine("soma dos impares = " + (n1 + n4));
		if (n2 % 2 == 1 && n3 % 2 == 1) Console.WriteLine("soma dos impares = " + (n2 + n3));
		if (n2 % 2 == 1 && n4 % 2 == 1) Console.WriteLine("soma dos impares = " + (n2 + n4));
		if (n3 % 2 == 1 && n4 % 2 == 1) Console.WriteLine("soma dos impares = " + (n3 + n4));
		
		if (n1 % 2 == 0 && n2 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n2));
		if (n1 % 2 == 0 && n3 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n3));
		if (n1 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n1 + n4));
		if (n2 % 2 == 0 && n3 % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n3));
		if (n2 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n2 + n4));
		if (n3 % 2 == 0 && n4 % 2 == 0) Console.WriteLine("soma dos pares = " + (n3 + n4));
		Console.WriteLine("Resultados 02 = fracasso");
		/*if ((n1 + n2 + n3 + n4) % 2 == 0) Console.WriteLine(n1 + n2 + n3 +n4);
		if ((n2 + n3 + n4) % 2 == 0) Console.WriteLine(n2 + n3 + n4);
		if ((n1 + n3 + n4) % 2 == 0) Console.WriteLine(n1 + n3 + n4);
		if ((n1 + n2 + n4) % 2 == 0) Console.WriteLine(n1 + n2 + n4);
		if ((n1 + n2 + n3) % 2 == 0) Console.WriteLine(n1 + n2 + n3);*/
		
		Console.WriteLine("Resultados 03");
		if ((n1 + n2) % 2 == 0) Console.WriteLine(n1 + n2);
		if ((n1 + n3) % 2 == 0) Console.WriteLine(n1 + n3);
		if ((n1 + n4) % 2 == 0) Console.WriteLine(n1 + n4);
		if ((n2 + n3) % 2 == 0) Console.WriteLine(n2 + n3);
		if ((n2 + n4) % 2 == 0) Console.WriteLine(n2 + n4);
		if ((n3 + n4) % 2 == 0) Console.WriteLine(n3 + n4);
		Console.WriteLine("Resultados 04");
		if (n1 % 2 == 0){
			if (n2 % 2 == 0){
				if (n3 % 2 == 0){
					if (n4 % 2 == 0){
						Console.WriteLine(n1 + n2 + n3 + n4);
					}
					else {Console.WriteLine(n1 + n2 + n3);}
				}
				else {Console.WriteLine(n1 + n2);}
			}
		}
		else { if (n1 % 2 == 1){
			if (n2 % 2 == 1){
				if (n3 % 2 == 1){
					if (n4 % 2 == 1){
						Console.WriteLine(n1 + n2 + n3 + n4);
					}
					else {Console.WriteLine(n1 + n2 + n3);}
				}
				else {Console.WriteLine(n1 + n2);}
				}
			}
		}
	}
}