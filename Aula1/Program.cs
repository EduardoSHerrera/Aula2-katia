using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracaao e instalacao do objeto
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();

            Console.WriteLine("--------------------------------- dados do cliente ---------------------------------");

            Console.Write("digite o nome do cliente: ");
            cliente.SetNome(Console.ReadLine());
            Console.Write("digite o nome do cliente: ");
            cliente.SetCpf(Convert.ToInt32(Console.ReadLine()));
            Console.Write("digite a idade do cliente: ");
            cliente.SetIdade(Convert.ToInt32(Console.ReadLine()));
            Console.Write("digite o endereço do cliente: ");
            cliente.SetEndereco(Console.ReadLine());

            Console.WriteLine("--------------------------------- dados do produto ---------------------------------");

            Console.Write("Digite o numero do produto: ");
            produto.SetCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descricao do produto: ");
            produto.SetDescricao(Console.ReadLine());
            Console.Write("Digite a categoria do produto: ");
            produto.SetCategoria(Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            produto.SetValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("--------------------------------- dados do produto ---------------------------------");

            Console.Write("Digite o numero do produto: ");
            pedido.SetNumero(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o numero do produto: ");
            pedido.SetQuantidade(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o valor do produto: ");
            pedido.SetTotal(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine("Nome: " + cliente.GetNome() + "\nCpf: " +
                cliente.GetCpf() + "\nIdade: " + cliente.GetIdade() +
                "\nValor: " + cliente.GetEndereco());

            Console.WriteLine("Codigo: " + produto.GetCodigo() + "\nDescrição: " +
                produto.GetDescricao() + "\nCategoria: " + produto.GetCategoria() +
                "\nValor: " + produto.GetValor().ToString("C"));

            Console.ReadKey();
        }
    }
}
