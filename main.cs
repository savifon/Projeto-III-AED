using System;

class MainClass {
  public static void Main (string[] args) {
		string nome, email, senha;
		long telefone=0;
		bool validaTelefone = false;

		//cadastro
		Acesso novoAcesso = new Acesso();
		novoAcesso.addCadastro(Cadastro.Cadastrar());
		Console.Clear();
		Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");

		//acesso
		do {
			Console.WriteLine("\nRealize o login abaixo:\n");
			Console.Write("E-mail >> ");
			email = Console.ReadLine();
			Console.Write("Senha >> ");
			senha = Console.ReadLine();
			Console.Clear();
		} while (!novoAcesso.validaAcesso(email, Md5.Hash(senha))); //valida acesso email+senha

		Console.WriteLine("\nOs dados estão corretos. SEJA BEM-VINDO(A)!");

  }
}