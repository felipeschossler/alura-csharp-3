using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerencia = new GerenciadorBonificacao();

            Funcionario felipe = new Funcionario();      
            felipe.Salario = 250.00;
            felipe.GetBonificacao();
            Console.WriteLine("Bonificacao Funcionario:" +felipe.Salario);

            gerencia.RegistrarBonificacao(felipe);

            Diretor carlos = new Diretor();
            carlos.Salario = 250.00;
            carlos.GetBonificacao();
            Console.WriteLine("Bonificacao Diretor:" +carlos.Salario);

            gerencia.RegistrarBonificacao(carlos);

            Console.WriteLine(gerencia.GetBonificacao());

            Console.ReadLine();

        }
    }
}
