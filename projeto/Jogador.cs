using System;

class Program {
	public static void Main () {
		Time time = new Time("Infoweb", "PEOO");

		Jogador j1 = new Jogador("Neymar", "10", 10);

		foreach(Jogador m in time.Listar())    
    	Console.WriteLine(m);
	}
}

class Time {
	private string Nome, Estado;
	private int k = 0;
	private Jogador[] jogadores = new Jogador[1];

	public Time(string n, string e) {
		Nome = n;
		Estado = e;
	}

	public void Inserir(Jogador j) {
    if (k == jogadores.Length) 
      Array.Resize(ref jogadores, jogadores.Length * 2);
    jogadores[k] = j;
    k++;
	}
		
	public Jogador[] Listar() {
    Jogador[] vetor = new Jogador[k];
    Array.Copy(jogadores, vetor, k);

		return vetor;
	}

	public Jogador Artilheiro () {
		if (k == 0) {
			return ("Nenhum jogador cadastrado.");
		}
			
		Jogador aux = Jogador[0];
		for(int i = 1; i < k; i++);
			if (Jogador[i].GetGols() > aux.GetGols())
			aux = Jogador[i];
		return aux.ToString();		
	}
		
	public override string ToString() {
		return $"{nome} - {estado}";
	
	}
}

class Jogador {
	private string nome, camisa;
	private int Gols;

	public Jogador(string n, string c, int g) {
    Nome = n;
    Camisa = c;
    Gols = g;
  }

	public void Setnome(string no) {
		nome = no;
	}
	public void Setcamisa(string ca) {
		camisa = ca;
	}
	public void SetGols(int go) {
		Gols = go;
	}

	public string Getnome() {
		return nome;
	}
	public string Getcamisa() {
		return camisa;
	}
	public int GetGols() {
		return Gols;
	}
	

	public override string ToString() {
		return $"{nome} - {camisa} - {Gols}";
	}
	
}