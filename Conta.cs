using System;

namespace Banco
{
    public class Conta
    {
        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public String NomeConta { get; set; }

        public Titular Titular { get; set; }

        public Decimal Saldo { get; set; }

        public Decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(Decimal valor)
        {
            Saldo += valor;        
        }

        public void Sacar(Decimal valor)
        {

            if (valor <= Saldo) 
                Saldo -= valor;
            else
                Console.WriteLine("Saldo Insuficiente");

        }

    }
}
