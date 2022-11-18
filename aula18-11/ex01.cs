using system;

class Program {
	public statis void Main () {

		Musica m1 = new Musica("easy", "Ivete", "Ao Vivo");
		Musica m2 = new Musica("Beribau", "Ivete", "Ao Vivo");
		Musica m3 = new Musica("Transilvania", "Iron Maiden", "IM");
		Playlist lista = new Playlist("POO");
		lista.Inserir(m1);
		lista.inserir(m2);
		lista.inserir(m3);

		foreach (Musica m in lista.Listar()){
			Console.WriteLine(m);
		}
		/*
		Musica[]v = new Musica[10];

		v[0] = m1;
		v[1] = m2;
		v[3] = new Musica("Transilvania", "Iron Maiden", "IM");

		foreach(Musica m in v) {
			if (m != null) Console.WriteLine(m);*/
		}
		
		Console.WriteLine(m1);
		Console.WriteLine(m2);
		
	}
	class Playlist {
		private string nome;
		private int k = 0;
		private Musica[] musicas = new Musica[10];

		public Playlist(string n) {
			nome = n;
		}
		public void Inserir(Musica m) {
			if (k == musicas.Legth){
				Array.Resize(ref musicas, musicas.Length * 2);
			}
			if (k < 10) {
				musica[k] = m;
				k++;
			}
		}
		public Musica[] Listar() {
			Musica[] vetor = new Musica[k];
			Array.Copy(musicas, vetor, k);
			return vetor;
		}
	}
	
	Class Musica {
		private string titulo;
		private string artista;
		private string album;

		public Musica (string t, string a, string al) {
			titulo = t;
			artista = a;
			album = al;
		}

		public void 

		public override string ToString () {
			return $"{titulo} - {artista} - {album}";
		}
		
	}
}