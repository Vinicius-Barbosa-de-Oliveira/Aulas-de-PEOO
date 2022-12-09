using System;

class Program {
	public static void Main () {

		
	}
}

class Time () {
	private string Nome;
	private string Estado;
	private int k = 0;
	private Jogador[] Jogadores = new Jogador[1];

	public Time (string N, string E){
		Nome = N;
		Estado = E;
	}

	public void inserir (Jogador m) {
		if (k == jogadores.Length) {
			array.Resize(ref jogadores, jogadores.Length * 2);
		}
		jogadores[k] = m;
		k++;
	}

	public string Artilheiro () {
		
	}

	public override string ToString () {
		return $"{nome}, {Estado}, {}";
	}
}

class Jogador () {
	private string nome;
	private string Camisa;
	private int gols;

	public jogador (string n, string C, int g) {
		nome = n;
		Camisa = C;
		gols = g;
	}
	public override string ToString() {
		return $"{nome}, {Camisa}, {gols}";
	}
}