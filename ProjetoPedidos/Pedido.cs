using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
	public static void Main() {
		
	}
}

public class Pedido {
	public int Id { get; set; }
	public string NomeCliente { get; set; }
	public int QtdItens { get; set; }

	public override string ToString() {
		return $"{Id} - {NomeCliente} - {QtdItens}"
	}
}
public class Item {
	public int Id { get; set; }
	public int IdPedido { get; set; }
	public int IdProduto { get; set; }
	public double PrecoTotal { get; set; }

	public override string ToString() {
		return $"{Id} - {IdPedido} - {IdProduto} - {PrecoTotal}";
	}
}
public class Produto {
	public int Id { get; set; }
	public string NomedoProduto { get; set; }
	public double Preco { get; set; }

	public override string ToString() {
		return $"{Id} - {NomedoProduto} - {Preco}";
	}
}


static class NPedido {
	private static List<Pedido> Pedidos = new List<Pedido>();

	public static void Inserir(Pedido p) {
		Abrir();
		Pedidos.Add(p);
		Salvar();
	}
	public static List<Turma> Listar() {
		Abrir();
		return Pedidos;
	}
	public static Turma Listar(int id)
  {
    foreach (Pedido obj in Pedidos)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar(Pedido p) {
		Abrir();
    Pedido obj = Listar(p.Id);
		if (obj != null) {
			obj.NomeCliente = p.NomeCliente;
    	obj.QtdItens = p.QtdItens;
		}
    Salvar();
	}
	public static void Excluir(Pedido p) {
		Abrir();
  	Pedidos.Remove(Listar(p.Id));
    Salvar();
	}
	public static void Abrir() {
    StreamReader f = null;
		
    try
    {
    	XmlSerializer xml = new XmlSerializer(typeof(List<Pedido>));
  		f = new StreamReader("./Pedidos.xml");
    	turmas = (List<Pedido>)xml.Deserialize(f);
    }
    catch
    {
      turmas = new List<Pedido>();
    }
      if (f != null) f.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Pedido>));
    StreamWriter f = new StreamWriter("./Pedidos.xml", false);
    xml.Serialize(f, Pedidos);
    f.Close();
	}
}
static class NItem {
	private static List<Item> Itens = new List<Item>();

	public static void Inserir(Item i) {
		Abrir();
		Itens.Add(i);
		Salvar();
	}
	public static List<Turma> Listar() {
		Abrir();
		return itens;
	}
	public static Turma Listar(int id)
  {
    foreach (Item obj in Itens)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar(Item i) {
		Abrir();
    Pedido obj = Listar(i.Id);
		if (obj != null) {
			obj.IdPedido = i.IdPedido;
    	obj.IdProduto = i.IdProduto;
		}
    Salvar();
	}
	public static void Excluir(Item i) {
		Abrir();
  	Itens.Remove(Listar(i.Id));
    Salvar();
	}
	public static void Abrir() {
    StreamReader f = null;
		
    try
    {
    	XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
  		f = new StreamReader("./Itens.xml");
    	turmas = (List<Item>)xml.Deserialize(f);
    }
    catch
    {
      turmas = new List<Item>();
    }
      if (f != null) f.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Item>));
    StreamWriter f = new StreamWriter("./Itens.xml", false);
    xml.Serialize(f, Itens);
    f.Close();
	}
	public static void VincularPedido(Item i, Pedido p) {
    i.IdPedido = p.Id;      
    Atualizar(i);
  }
	public static void VincularProduto(Item i, Produto pro) {
    i.IdPedido = pro.Id;      
    Atualizar(a);
  }
}
static class NProduto {
	private static List<Produto>  = new List<Produto>();

	public static void Inserir(Produto pro) {
		Abrir();
		produtos.Add(pro);
		Salvar();
	}
	public static List<Turma> Listar() {
		Abrir();
		return Produtos;
	}
	public static Turma Listar(int id)
  {
    foreach (Produto obj in Produtos)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar(Produto pro) {
		Abrir();
    Produto obj = Listar(pro.Id);
		if (obj != null) {
			obj.NomedoProduto = pro.NomedoProduto;
    	obj.Preco = pro.Preco;
		}
    Salvar();
	}
	public static void Excluir(Produto pro) {
		Abrir();
  	Produtos.Remove(Listar(pro.Id));
    Salvar();
	}
	public static void Abrir() {
    StreamReader f = null;
		
    try
    {
    	XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
  		f = new StreamReader("./Produtos.xml");
    	turmas = (List<Produto>)xml.Deserialize(f);
    }
    catch
    {
      turmas = new List<Produto>();
    }
      if (f != null) f.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
    StreamWriter f = new StreamWriter("./Produtos.xml", false);
    xml.Serialize(f, Produtos);
    f.Close();
	}
}