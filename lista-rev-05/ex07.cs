using System;

class Program {
	public static void Main() {
		Console.WriteLine("Digite o numero que desejá saber o antecessor e o sucessor");

		int y =  int.Parse(Console.ReadLine());
		int i, p;
		

		AntecessorSucessor(y,out i,out p);

		Console.WriteLine(y);
		Console.WriteLine(i);
		Console.WriteLine(p);
	}
	public static void AntecessorSucessor(int x, out int antecessor, out int sucessor) {

		antecessor = x - 1;
		sucessor = x + 1;
	}
}