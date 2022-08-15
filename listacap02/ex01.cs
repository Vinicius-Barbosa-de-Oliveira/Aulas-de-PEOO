using System;

class Progam {
	public static void Main () {

		Console.WriteLine("Digite a data do seu nascimento:");

		string[] datas = Console.ReadLine().Split('/');
		

		int n1 = int.Parse(datas[2]);

		int anos = 2022 - n1;

		Console.WriteLine($"em 2022, você terá {anos} anos");
	}
}