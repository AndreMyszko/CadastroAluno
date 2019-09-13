// # andre myszko # 2019102420
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoas
{ 
    class Aluno
    {
        public Aluno(){}

        //Atributos da classe Pessoas:
        public string Cod { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string cod, string nome, int idade)
        {
            this.Cod = cod;
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
