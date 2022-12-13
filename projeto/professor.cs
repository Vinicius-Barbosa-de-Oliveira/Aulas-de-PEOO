using System;

class Program {
  public static void Main() {
		Console.WriteLine ("digite o Nome");
		string no = Console.ReadLine ();
		Console.WriteLine ("digite a numeração da Camisa");
		string ca = Console.ReadLine();
		Console.WriteLine ("digite a quantidade de gols");
		int go = int.Parse(Console.ReadLine());
		Jogador j4 = new Jogador(no, ca, go);
		Console.WriteLine();

		
    Jogador j1 = new Jogador("Neymar", "10", 10);
    Jogador j2 = new Jogador("Richarlison", "09", 10);
    Jogador j3 = new Jogador("Vini. JR", "18", 10);
    Time time = new Time("Infoweb", "PEOO");
		
    time.Inserir(j1);
    time.Inserir(j2);
    time.Inserir(j3);
		time.Inserir(j4);
		
    foreach(Jogador m in time.Listar())    
      Console.WriteLine(m);
  }
}

class Time {
  private string nome;
	private string estado;
  private int k = 0;
	/*private int jogos = 0;
	private string art = "";*/
  private Jogador[] jogadores = new Jogador[1];
  public Time(string n, string e) {
    nome = n;
		estado = e;
  }
  public void Inserir(Jogador m) {
    if (k == jogadores.Length) 
      Array.Resize(ref jogadores, jogadores.Length * 2);
    jogadores[k] = m;
    k++;
  }
  public Jogador[] Listar() {
    Jogador[] vetor = new Jogador[k];
    Array.Copy(jogadores, vetor, k);

		Console.WriteLine($"Nome do Time: {nome} - Estado: {estado}");
		Console.WriteLine();
		return vetor;
		
  }

	/*public Jogador Artilheiro () {
		if (k==0) { 
  	MessageBox.Show("nenhum jogador foi inserido ");
		return;
	  }

	jogador  aux  =js[0];
	for( int i =1; i<k ;i++);
  if( js[i].GetGols() > aux.GetGols() )
    aux= js[i];
	MensssageBox.Show(aux.ToString())
	}*/

	public override string ToString() {
		return $"{nome} - {estado}";
	}
}

class Jogador {
  private string Nome;
  private string Camisa;
  private int Gols;
  public Jogador(string n, string c, int g) {
    Nome = n;
    Camisa = c;
    Gols = g;
  }
  public override string ToString() {
    return $"Nome: {Nome} - Camisa: {Camisa} - Quantidade de Gols: {Gols}";
  }
}