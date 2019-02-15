using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario, IAutenticavel
    {
        //construtor que referencia a classe base
        public Diretor(string cpf) : base(5000, cpf) { }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        internal void Logar(string v)
        {
            throw new NotImplementedException();
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
