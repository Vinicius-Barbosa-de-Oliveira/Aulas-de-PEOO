using System;
class Program {
	public static void Main(string[] args) {

		int c = 0;
		//for (i = 1; i <= 6; i++) {
			int x = int.Parse(Console.ReadLine());
			if (x > 0){
				c++;
			}
			Console.WriteLine($"{c} Valores Positivos");
		}
	}
}