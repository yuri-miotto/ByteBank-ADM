using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank_ADM.SistemaInterno;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    { 

        public Diretor(string cpf) : base(cpf, 5000) { }

        public override double GetBonificacao()
        {
            return this.Salario;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}


