using System;
using System.Globalization;

namespace Questao1
{


    class ContaBancaria
    {
        private int numero { get; }
        private string titular { set; get; }
        private double depositoInicial { set; get; }
        private double saldo { set; get; }

        const double taxa = 3.50;



        public ContaBancaria(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial)
        {
            this.numero = numero;
            this.titular = titular;
            this.depositoInicial = depositoInicial;

            if (this.depositoInicial > 0)
            {
                Deposito(this.depositoInicial);
            }

        }

        internal void Deposito(double quantia)
        {
            this.saldo += quantia;
        }

        internal void Saque(double quantia)
        {
            this.saldo = saldo - quantia - taxa;
        }


        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta {this.numero}, Titular: {this.titular}, Saldo: $ {this.saldo}");
        }


    }
}
