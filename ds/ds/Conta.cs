using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds
{
    class Conta
    {
        public string erro;
        public int numero;
        public double saldo;

        public bool depoisitar(double valor)
        {
            if(valor > 0)
            {
            this.saldo += valor;
                return true;
            }
            this.erro = "erro";
            return false;
            
        }
        public bool saque(double valor)
        {
            if (valor > 0)
            { 
                if(this.saldo >= valor)
                {
                this.saldo -= valor;
                return true;
                }
            }
            this.erro = "erro";
            return false;
        }

        public double versaldo()
        {
            return this.saldo;
        }

       
    }
}
