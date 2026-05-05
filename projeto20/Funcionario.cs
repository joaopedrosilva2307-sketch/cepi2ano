using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;


namespace Projeto20
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario_Bruto;
        public double Imposto;

        public double SalarioLiquido()
        {

            return Salario_Bruto - Imposto;

        }

        public void AumentarSalario (double porcentagem )
        {
            Salario_Bruto = Salario_Bruto + (Salario_Bruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome
            + ", R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);


        }

    }
}
