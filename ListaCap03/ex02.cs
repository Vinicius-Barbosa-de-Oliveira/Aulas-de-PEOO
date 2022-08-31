using System;

class program {
	public static void Main () {

		Compra x = new Compra();
		x.SetTotal(1000);
		x.SetNumPrestacoes(10);

		double total = x.GetTotal();
		int Numprestacoes = x.GetNumPrestacoes();
		double ValorParcelas = x.GetValorPrestacoes();
		double Desconto = x.GetDesconto();

		Console.WriteLine($"R${total}");
		Console.WriteLine($"R${Numprestacoes}");
		Console.WriteLine($"R${ValorParcelas}");
		Console.WriteLine($"R${Desconto}");
	}
}
class Compra {
	private double Total;
	private int NumPrestacoes;

	public void SetTotal (double t) {
		if (t > 0) Total = t;
	}
	public void SetNumPrestacoes (int p) {
		if (p > 0) NumPrestacoes = p;
	}
	public double GetValorPrestacoes () {
		return (Total / NumPrestacoes);
	}
	public double GetDesconto () {
		return (Total * 0.15);
	}
	public double GetTotal () {
		return Total;
	}
	public int GetNumPrestacoes () {
		return NumPrestacoes;
	}


}