using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
	public static void Main () {
				Console.WriteLine("---------------------------------------------");
		Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
		int op = int.Parse(Console.ReadLine());
		while (op != 0) {
			switch(op){
			case 1:
				Console.Write("Informe o ID: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Informe o Nome: ");
				string nome = Console.ReadLine();
				Console.Write("Informe a Matricula: ");
			 	string matricula = Console.ReadLine();
				Console.Write("Informe a Area: ");
				int area = Console.ReadLine();
			
				Professor p = new Professor {
					Id = id, Nome = nome,
					Matricula = matricula, Area = area };
				
				NProfessor.Inserir(p);
				break;
				
			case 2:
				foreach (Professor x in NProfessor.Listar())
					Console.WriteLine(x);
				break;

			case 3: 
					NProfessor.Salvar();
				break;
			case 4:
					NProfessor.Abrir();
				break;
			}
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
			op = int.Parse(Console.ReadLine());
		}
	}
}

public Class Professor{
	public int Id { get; set; }
	public string Nome { get; set; }
	public string Matricula { get; set; }
	public string Area { get; set; }

	public override string ToString (){
		return $" {Id} - {Nome} - {Matricula} - {Area}";
	}
}
static Class NProfessor {
	private static List<Professor> Professores = new List<Professor>();

	public static void Inserir(Professor p) { // C - Create
		Abrir();
		Professores.Add(p);
		Salvar();
	}
	public static List<Professor> Listar() { // R - Read
		Abrir();
		return Professores;
	}
	public static Professor Listar(int id)
  {
    // Encontra, se existir, uma turma com o id
    foreach (Professor obj in Professores)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar(Professor p) { // U - Update
		Abrir();
    Professor obj = Listar(p.Id);
		if (obj != null){
    	obj.Nome = p.Nome;
    	obj.Matricula = p.Matricula;
    	obj.Area = p.Area;
		}
    Salvar();
	}
	public static void Excluir(Professor p) { // D - Delete
		Abrir();
    Professores.Remove(Listar(p.Id));
    Salvar();
	}
	public static void Abrir() {
    StreamReader pro = null;
		
    try
    {
    	XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
  		pro = new StreamReader("./Professor.xml");
    	turmas = (List<Professor>)xml.Deserialize(pro);
    }
    catch
    {
      Professores = new List<Professor>();
    }
      if (pro != null) pro.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
    StreamWriter pro = new StreamWriter("./Professor.xml", false);
    xml.Serialize(pro, Professores);
    pro.Close();
}