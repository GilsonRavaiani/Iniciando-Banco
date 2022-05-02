using System;

namespace Banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta Gilson";
            conta.NumeroConta = 1234567;
            conta.Agencia = 001;
            conta.Saldo = 10;        

            conta.Titular = new Titular()
            {
                Nome = "Gilson Ravaiani",
                Endereco = "Rua da Paz",
                Cpf = "0123456789",
                Rg = "87654321",
            };


            Console.WriteLine($"Saldo: { conta.VerSaldo()}");

            Console.WriteLine("Valor depositado: ");

            string valor = Console.ReadLine();

            conta.Depositar(12);            

            Console.WriteLine($"Saldo após depósito: { conta.VerSaldo()}");

            Console.ReadKey();

            Console.WriteLine("Valor Saque: ");

            string Saque = Console.ReadLine();

            conta.Sacar(3);

            Console.WriteLine($"Saldo após Saque: { conta.VerSaldo()}");

            Console.ReadKey();

            Console.WriteLine("Valor Saque2: ");

            string Saque2 = Console.ReadLine();

            conta.Sacar(11);

            Console.WriteLine($"Saldo após Saque2: { conta.VerSaldo()}");

            Console.ReadKey();

            Console.WriteLine("Valor Saque3: ");

            string Saque3 = Console.ReadLine();  
                  
            conta.Sacar(10);

            Console.ReadKey();


        }
    }
}
