using System;

class program {
	public static void Main () {

		Console.WriteLine("Digite o nome da Diciplina:");

		string x = Console.ReadLine();

		Console.WriteLine("Digite a nota do primeiro bimeste:");

		double n1 = double.Parse(Console.ReadLine());

		Console.WriteLine("Digite a nota do segundo bimeste:");

		double n2 = double.Parse(Console.ReadLine());

		Console.WriteLine("Digite a nota do terceiro bimeste:");

		double n3 = double.Parse(Console.ReadLine());

		Console.WriteLine("Digite a nota do quarto bimeste:");

		double n4 = double.Parse(Console.ReadLine());

		Diciplina d1 = new Diciplina();

		d1.nome = x;
		d1.nota1 = n1;
		d1.nota2 = n2;
		d1.nota3 = n3;
		d1.nota4 = n4;

		if (d1.Media() >= 0 && d1.Media() <= 100) {
			if (d1.Media() >= 60){
				Console.WriteLine($"vc foi aprovado!");
				Console.WriteLine($"Sua Media Parcial da diciplina de  {d1.nome} é: {d1.Media()}");
				Console.WriteLine($"Sua Media Ponderada da diciplina de {d1.nome} é: {d1.MediaPonderada():f2}");
			}
			else {
				if (d1.mediafinal() < 60) {
					Console.WriteLine("você foi reprovado!");
				}
				else {
					Console.WriteLine($"vc foi aprovado!");			
				}
			}
		}
		else {
			Console.WriteLine("Ouve algum erro com suas notas, olhe se você digitou todas corretamente");
		}
	}
}
class Diciplina {

	public string nome;
	public double nota1;
	public double nota2;
	public double nota3;
	public double nota4;
	public double nf;

	public double notafinal () {

		nf = 100 - (nota1 + nota2 + nota3 + nota4);
	  return nf;

	}
	public double Media () {

		double media = (nota1 + nota2 + nota3 + nota4) / 4;
		return media;
		
	}

	public double MediaPonderada () {

		return ((nota1 * 2) + (nota2 * 2) + (nota3 * 3)) / (nota1 + nota2 + nota3 + nota4);	
		
	}
	public double MediaFinal () {
		double mediafinal =;
		return mediafinal;
	}
	
}