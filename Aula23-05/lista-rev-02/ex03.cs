using System;
class Program {
	public static void Main (string[] args) {
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
	}
}