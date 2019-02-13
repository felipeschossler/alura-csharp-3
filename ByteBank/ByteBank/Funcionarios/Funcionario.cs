using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
  
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }

        //construtor que passa salario e cpf
        public Funcionario(double salario, string cpf)
        {
            this.Salario = salario;
            this.CPF = cpf;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

    }
}
