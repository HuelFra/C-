using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo = 100;

        public void Depositar(double valor) //criado o objeto de depósito = novo comportamento da classe ContaCorrente, método Depositar na conta corrente
        {
            this.saldo += valor; //this se refere ao próprio objeto criado
        }

        public bool Sacar(double saque) //criando o método sacar - bool, pois se conseguir efeutar  saque return true
        {
            if (saque <= this.saldo)
            {
                this.saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Numero_agencia: " + this.numero_agencia);
            Console.WriteLine("Conta: " + this.conta);
            Console.WriteLine("titular: " + this.titular);
            Console.WriteLine("Saldo: " + this.saldo);
        }
    }

}
