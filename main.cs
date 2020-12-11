using System;

class MainClass {
  public static void Main (string[] args) {
		//variáveis
		string nome, email, senha;
		long telefone=0;
		bool validaTelefone = false;

		/*
		//cadastro
    Console.Clear();
		Console.WriteLine("\nSeja bem-vindo(a)!\nPara se cadastrar, informe os dados abaixo:\n");

		do {
			Console.Write("Nome >> ");
			nome = Console.ReadLine();
		} while (!Cadastro.validaNome(nome)); //valida nome digitado

		do {
			Console.Write("E-mail >> ");
			email = Console.ReadLine();
		} while (!Cadastro.validaEmail(email)); //valida email digitado

		do {
			Console.Write("Telefone (somente números) >> ");
			try {
				telefone = long.Parse(Console.ReadLine());
				validaTelefone = true;
			} catch (FormatException) {
				Console.WriteLine("Digite um telefone válido!");
			}
		} while (!validaTelefone); //valida telefone digitado
		
		do {
			Console.Write("Senha (mín. 8 caracteres, 1 letra maiúscula, 1 letra minúscula e 1 caractere especial) >> ");
			senha = Console.ReadLine();
		} while (!Cadastro.validaSenha(senha)); //valida senha digitada

		//efetiva cadastro
		Cadastro novoCadastro = new Cadastro(nome, email, Md5.Hash(senha), telefone);*/
		Acesso novoAcesso = new Acesso();
		novoAcesso.addCadastro(Cadastro.Cadastrar());

		//confirma cadastro
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