using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Pedido
    {
        int numero;
        int quantidade;
        double total;


        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return this.numero;
        }

        public void SetQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int GetQuantidade()
        {
            return this.quantidade;
        }

        public void SetTotal(double total)
        {
            this.total = total;
        }

        public double GetTotal()
        {
            return this.total;
        }
    }
}
