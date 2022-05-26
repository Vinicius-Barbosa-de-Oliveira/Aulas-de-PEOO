using System;
class Program {
	public static void Main (string[] args) {
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
	}
}