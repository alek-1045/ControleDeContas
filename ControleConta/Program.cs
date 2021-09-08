using System;

namespace ControleConta
{
    class Program
    {
        static void Main(string[] args)
          {
            try
            {
                Cliente cliente1 = new Cliente("Alek", 2000, "53681478930");
                Conta conta1 = new Conta(1234, cliente1);
                Conta conta2 = new Conta(1875, cliente1);
                

                Console.WriteLine(conta1.Numero);
                conta1.Depositar(1000);
                Console.WriteLine("O saldo inicial da conta {0} é {1}", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo inicial da conta {0} é {1}", conta2.Numero, conta2.Saldo);
                conta1.Sacar(10);
                Console.WriteLine("O saldo da conta após o deposito é " + conta1.Saldo);
                Console.WriteLine("O saldo da conta após o saque é "+ conta1.Saldo);
                conta1.Transferir(conta2, 300m);
                Console.WriteLine("O saldo atual da conta {0} é {1}", conta1.Numero, conta1.Saldo);
                Console.WriteLine("O saldo atual da conta {0} é {1}", conta2.Numero, conta2.Saldo);
                
                Console.WriteLine("O cliente da conta {0} é {1}", conta1.Numero, conta1.Titular.Nome);
            }
            catch(Exception e)

            {
                Console.WriteLine(e.Message);
            }
          }
    }
}
