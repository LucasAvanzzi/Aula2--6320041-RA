using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2__6320041_RA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme al = new Filme();
            Entrada men = new Entrada();

            Console.Write("Digite o Titulo do Filme: ");
            al.SetTitulo(Console.ReadLine());
            Console.Write("Digite a Sinopse do Filme: ");
            al.SetSinopse(Console.ReadLine());
            Console.Write("Digite o Genero do Filme: ");
            al.SetGenero(Console.ReadLine());
            Console.Write("Digite a Classificação Indicativa do Filme: ");
            al.SetClassificacao(Console.ReadLine());
            Console.Write("Digite o Valor do Ingresso: ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a Data do Ingresso: ");
            men.SetData(Console.ReadLine());
            Console.Write("Digite a Hora do Ingresso: ");
            men.SetHora(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
