using System;
using System.Globalization;

namespace Exemplo_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Colaborador.ReajusteColaborador objReajusteColaborador =
                new Colaborador.ReajusteColaborador();

            Console.WriteLine("Entre com o nome");
            objReajusteColaborador.nomeColaborador = Console.ReadLine();

            Console.WriteLine("Entre com o salário");
            objReajusteColaborador.salarioColaborador = double.Parse(Console.ReadLine());

            Console.WriteLine("Antes do Reajuste: ");
            Console.WriteLine("\nNome: " + objReajusteColaborador.nomeColaborador);
            Console.WriteLine("\nSalário: R$ " + objReajusteColaborador.salarioColaborador);

            objReajusteColaborador.Reajuste();

            Console.WriteLine("\nDepois do Reajuste: ");
            Console.WriteLine("\nNome: " + objReajusteColaborador.nomeColaborador);
            Console.WriteLine("\nSalário: R$ " + objReajusteColaborador.salarioColaborador);

            Console.ReadKey();
        }
    }
}
