using _01_ByteBank;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Depositar(80);

            Console.WriteLine(conta.ObterSaldo());
            conta.DefinirSaldo(20);
            Console.ReadLine();
        }
    }
}
