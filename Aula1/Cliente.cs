using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Cliente
    {
        // declaracao de atributos
        string nome;
        int cpf;
        string endereco;
        int idade;

        // declaracao dos metodos getter e setter
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetCpf(int cpf)
        {
            this.cpf = cpf;
        }

        public int GetCpf()
        {
            return this.cpf;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetEndereco()
        {
            return this.endereco;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return this.idade;
        }
        
    }
}
