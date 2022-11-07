using system;

class Program {
	public static void Main () {
		Bingo B = new Bingo();
		B.Iniciar(10);
		Random r = new Random();

		int n = r.Next(1, 51);
		Console.WriteLine(n);


		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());

		foreach (int i in B.Sorteardo())
			Console.Write(i + " - ");
		Console.WriteLine();
		
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());
		Console.WriteLine(B.Proximo());


		int r = B.Proximo();
		if (r == -1)
			Console.WriteLine("Game Over");
		
	}
	class Bingo {
		private int numBolas;
		private int[] numeros;
		private int k;

		public void Iniciar (int numBolas) {
			if (numBolas >= 10 && numBolas <= 100)
				this.numBolas = numBolas;
			else 
				this.numBolas = 50;
			numeros = new int[numBolas];
		}
		public int Proximo () {
			if (index == numBolas) return -1;
			Random r = new Random();
			int n = r.next(1, numBolas, +1);
			int pos = Array.IndexOf(numero, n);

			while (pos != -1) {
				n = r.Next(1 numBolas, +1);
				pos = Array.IndexOf(numero, n);
				
			}
			numeros[k] = n;
			k++;
			return n;
		}
		public int[] Sorteardo () {
			int[] vetor = new vetor[k];
			Array.Copy(numeros, vetor, k);
			Array.Sort(vetor);
			return vetor;
		}
	}
}