using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Produto
    {
        // declaracao de atributos
        int codigo;
        string descricao;
        double valor;
        string categoria;

        // declaracao dos metodos getter e setter
        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string GetDescricao()
        {
            return this.descricao;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public double GetValor()
        {
            return this.valor;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public string GetCategoria()
        {
            return this.categoria;
        }
    }
}
