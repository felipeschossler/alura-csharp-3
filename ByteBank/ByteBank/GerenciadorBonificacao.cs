using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void RegistrarBonificacao(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.Salario;
        }

        public double GetBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
