using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite os valores:");
		string[] x = Console.ReadLine().Split();
		
		int s1 = int.Parse(x[0]);
		char s2 = char.Parse(x[1]);
		int s3 = int.Parse(x[2]);
		
		if (s2 == '+') Console.WriteLine("o resultado dos valores é " + (s1 + s3));
		if (s2 == '-') Console.WriteLine("o resultado dos valores é " + (s1 - s3));
		if (s2 == '*') Console.WriteLine("o resultado dos valores é " + (s1 * s3));
		if (s2 == '/') Console.WriteLine("o resultado dos valores é " + (s1 / s3));


	}
}