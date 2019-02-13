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

            Diretor felipe = new Diretor(3000, "132-333-444-21");

            Console.WriteLine(felipe.CPF);
            Console.WriteLine(felipe.Salario);

            Console.ReadLine();

        }
    }
}
