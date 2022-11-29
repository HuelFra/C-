/*
public: acessível de qualquer ponto do código, ou seja não impõe restrições;
private: acessível somente dentro do contexto onde foi declarado, ou seja, um membro privado dentro de uma classe só é acessível dentro da própria classe;
protected: o elemento é acessível dentro da classe e suas derivadas;
internal: é o padrão no C#. Caso nenhum modificador seja declarado, definirá a acessibilidade do elemento dentro do executável ou dll onde foi declarado;
protected internal: é proveniente união dos modificadores protected e internal. 
*/

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

        public static int TotalContasCriadas { get; private set; } //static passa a ser objeto da classe e não do objeto



        public int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public string conta;
        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente titular { get; set; }



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

        public void SetSaldo(double valor) //Set = Definir
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double GetSaldo() //Get = Obter
        {
            return this.saldo;
        }
        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        public ContaCorrente(string titular, int numero_agencia, string numero_conta)
        {
            titular = titular;
            this.numero_agencia = numero_agencia;
            this.conta = numero_conta;
            //Incrementando a propriedade
            TotalContasCriadas++;
        }
    }
}
