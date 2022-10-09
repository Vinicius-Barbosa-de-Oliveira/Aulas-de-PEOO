using System;

class Program {

	public static void Main () {
		//setando a interrface com o usuario.
		
		Aluno x = new Aluno();
		
		Console.WriteLine("Digite o nome do aluno:");
		x.SetNome("Daniel");

		Console.WriteLine("Digite sua matricula:");
		x.SetMatricula("20201011110030");

		Console.WriteLine("Digite sua idade:");
		x.SetIdade(19);

		Console.WriteLine();

		Console.WriteLine("Digite as notas:");
		Console.WriteLine("Primeira Nota:");
		x.SetNota1(65);
		Console.WriteLine("Segunda Nota:");
		x.SetNota2(75);
		Console.WriteLine("Terceira Nota:");
		x.SetNota3(45);
		Console.WriteLine("Quarta Nota:");
		x.SetNota4(98);

		Console.WriteLine();

		Console.WriteLine($"NOME: {x.GetNome()}");
		Console.WriteLine($"MATRICULA: {x.GetMatricula()}");
		Console.WriteLine($"IDADE: {x.GetIdade()}");

		Console.WriteLine();

		Console.WriteLine($"1 BIMESTRE: {x.GetNota1()}");
		Console.WriteLine($"2 BIMESTRE: {x.GetNota2()}");
		Console.WriteLine($"3 BIMESTRE: {x.GetNota3()}");
		Console.WriteLine($"4 BIMESTRE: {x.GetNota4()}");

		Console.WriteLine($"MEDIA DO ALUNO: {x.Media()}");
	}
	
}
class Aluno {
	//setando as variaveis.
	
	private string Nome;
	private string Matricula;
	private int Idade;
	double Nota1, Nota2, Nota3, Nota4;
	//private int qtd = 0;

	//--------------------------------------------------------

	//fazendo os teste para validar os valores.

	public void SetNome (string n) {
		if (n != "") {
			Nome = n;
		}
	}
	public void SetMatricula (string m) {
		/*int j = int.Parse(m);
		foreach (int k in j) {
			qtd += 1;
			if (qtd == 14) {
				Matricula = m;
			}
		}*/
		if (m != "") {
			Matricula = m;
		}
	}
	public void SetIdade (int i) {
		if (i > 0) {
			Idade = i;
		}
	}
	public void SetNota1 (double n1) {
		if (n1 >= 0 && n1 <= 100) {
			Nota1 = n1;
		}
	}
	public void SetNota2 (double n2) {
		if (n2 >= 0 && n2 <= 100) {
			Nota2 = n2;
		}
	}
	public void SetNota3 (double n3) {
		if (n3 >= 0 && n3 <= 100) {
			Nota3 = n3;
		}
	}
	public void SetNota4 (double n4) {
		if (n4 >= 0 && n4 <= 100) {
			Nota4 = n4;
		}
	}

	//------------------------------------------------
	//Retornando os valores para serem mostrados.
	
	public string GetNome () {
		return Nome;
	}
	public string GetMatricula () {
		return Matricula;
	}
	public int GetIdade () {
		return Idade;
	}
	public double GetNota1 () {
		return Nota1;
	}
	public double GetNota2 () {
		return Nota2;
	}
	public double GetNota3 () {
		return Nota3;
	}
	public double GetNota4 () {
		return Nota4;
	}

	//-------------------------------------------
	//Metodos de calculos

	public double Media () {
		return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
	}
	/*public static void DadosAlunos () {
		switch (Matricula) {
			case "20201011110030": {
				return Nome;
				return Matricula;
				return Idade;
			}
				default : Console.WriteLine("Não cadastrado.");
		}
	}*/
}