using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ContaFísica: Conta
    {
        public override bool Sacar(double sacar)
        {
            if (this.Saldo1 > 0.0 && this.Saldo1 <= 4000.0)
            {
                this.Saldo1 = this.Saldo1 - sacar;
            }
            return base.Sacar(sacar);
        }

   

    }
}
