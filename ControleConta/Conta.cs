using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta
{
    class Conta
    {
        //private int _numero;
       //rivate decimal _saldo;

        public long Numero { get; private set; }

        public decimal Saldo { get;  private set; }

        public Cliente Titular { get; set; }

        public Conta(long numero, Cliente titular)
        {
            if (numero < 999)
                throw new System.ArgumentException("O numero da conta for superior a 999");
            Numero = numero;
            Titular = titular;
        }
        
        public void Depositar(decimal valor) 
        {
            Saldo += valor;

        }

        public bool Sacar(decimal valor)
        {
            if (Saldo - (valor - 0.1m) < 0)
            {
                return false;
            }

            Saldo -= (valor + 0.1m);
            return true;
        }

        public bool Transferir(Conta destino, decimal valor)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
