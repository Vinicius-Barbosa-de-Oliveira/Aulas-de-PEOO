using System;

class Progam {
	public static void Main () {

		Console.WriteLine("Digite a data do seu nascimento:");

		string[] datas = Console.ReadLine().Split('/');
		

		int n1 = int.Parse(datas[2]);

		int idade = 2022 - n1;

		if (idade >= 0 && idade <= 19) {
			Console.WriteLine("Você está na faixa etária: Jovem");
		}
		else { 
			if (idade >= 20 && idade <= 59)	{
				Console.WriteLine("Você está na faixa etária: Adulta");
			}
			else {	
				if (idade >= 60){
					Console.WriteLine("Você está na faixa etária: Idoso");
					}
			}
		}
	}
}