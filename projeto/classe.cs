using System;

class Program {
	public static void Main () {

		Jogador j1 = new Jogador(richarllyson, 09, 9);
		Jogador j2 = new Jogador(Neymar, 10, 20);
		
		lista.Inserir(j1);
		lista.Inserir(j2);

		foreach(Jogador m in lista.Listar())
			Console.WriteLine(m);
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

	public Jogador[] Listar() {
		Jogador[] time = new Jogador[k];
		Array.Copy(jogadores, time, k);
		return time;
	}
	public string Artilheiro () {
		
	}

	public override string ToString () {
		return $"{nome}, {Estado}, {artilheiro}";
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