using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_Interface
{
    class Colaborador
    {
        interface IReajuste
        {
            double Reajuste();
        }
        public class ReajusteColaborador : IReajuste
        {
            public string nomeColaborador;
            public double salarioColaborador;

            public double Reajuste()
            {
                salarioColaborador = salarioColaborador * 1.50;

                return salarioColaborador;
            }
        }

    }
}
