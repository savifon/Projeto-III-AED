using System;
using System.Collections.Generic;

class Acesso {
	private List<Cadastro> cadastros;

	public Acesso() {
		cadastros = new List<Cadastro>();
	}

	public void addCadastro(Cadastro c){
    cadastros.Add(c);
  }

	public bool validaAcesso(string e, string s) {
		string emailCadastro = "";

		try {
			if (string.IsNullOrEmpty(e) || string.IsNullOrEmpty(s) || !Cadastro.validaEmail(e)) {
				throw new ArgumentException("Você digitou valores inválidos. Tente novamente!");
			}
			foreach (Cadastro cad in cadastros) {
				if (e == cad.getEmail()) {
					if (s == cad.getSenha()) {
						return true;
					} else {
						throw new ArgumentException("A senha digitada é incorreta. Tente novamente!");
					}
				}
			}

			if (emailCadastro == "") {
				throw new ArgumentException("O e-mail digitado não possui cadastro. Tente novamente!");
			}

		} catch (Exception ex) {
			Console.WriteLine("Erro: {0}", ex.Message);
		}

		return false;
	}

}