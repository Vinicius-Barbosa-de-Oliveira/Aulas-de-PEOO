using System; 

class Program {
	public static void Main (string[] args) {

		int a = 1;
		int exp = 0;
		while (a <= 50) {
			Console.WriteLine(a + exp);
			a = a + exp;
			exp++;
		}
	}
}