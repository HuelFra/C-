using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;



        public void Depositar(double valor) //criado o objeto de depósito = novo comportamento da classe ContaCorrente, método Depositar na conta corrente
        {
            saldo += valor; //this se refere ao próprio objeto criado
        }

        public bool Sacar(double saque) //criando o método sacar - bool, pois se conseguir efeutar  saque return true
        {
            if (saque <= saldo)
            {
                saldo -= saque;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Numero_agencia: " + numero_agencia);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("titular: " + titular);
            Console.WriteLine("Saldo: " + saldo);
        }
    }

}
