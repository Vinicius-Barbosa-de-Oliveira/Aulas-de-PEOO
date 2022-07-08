using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("alternando o sinal");
		/*int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		foreach (int x in v) {
			Console.WriteLine(x);
			Console.WriteLine(-x);
		}*/
		int a = 1;
		while (a <= 10) {
			Console.WriteLine(a);
			a++;
			Console.WriteLine(-a);
			a++;
		}
		/*do {
			Console.WriteLine(a);
			a++;
			Console.WriteLine(-a);
			a++;
		} while(a <=10);*/
	}
}