using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleConta
{
    class Cliente
    {
        public string Nome { get; private set; }

        public string Email { get; set; }

        public int AnoNascimento { get; private set; }

        public string Cpf { get; private set; }


        public Cliente(string nome, int anoNascimento, string cpf)
        {
            if(Int32.Parse(DateTime.Now.ToString("yyyy")) - anoNascimento < 18)
                throw new System.ArgumentException("O cliente deve ser maior de 18 ano!");
            if (cpf.Length != 11)
                throw new System.ArgumentException("O CPF deve ter até 11 digitos!");
            Nome = nome;
            AnoNascimento = anoNascimento;
            Cpf = cpf;
        }
    }
}
