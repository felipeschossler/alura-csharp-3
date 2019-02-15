using ByteBank.Sistemas;
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

            //new object sistemaInterno
            SistemaInterno sistemaInterno = new SistemaInterno();

            //new object Director
            Diretor felipe = new Diretor("222.222.222-33");
            felipe.Senha = "123";

            //new object GerenteDeConta
            GerenteDeConta renato = new GerenteDeConta("333.333.333-55");
            renato.Senha = "abc";

            //new object ParceiroComercial
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "abc123";

            //test if works passwd authentication
            sistemaInterno.Logar(felipe, "123");
            sistemaInterno.Logar(renato, "abc");
            sistemaInterno.Logar(parceiro, "abc123");
            Console.ReadLine();

        }
    }
}
