using _02_ByteBank;
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
            Cliente cliente = new Cliente(); //Eu criei um cliente

            //Depósito na conta com set.
            conta.Depositar(80);

            //Console.WriteLine(conta.GetSaldo()); Pode-se substituir por:
            Console.WriteLine(conta.Saldo);

            //conta.SetSaldo(20); Pode-se substituir por:
            conta.Saldo = 20;

            cliente.Nome = "Eduarda";          //Passei as propriedades
            cliente.CPF = "***.***.***-**";   //desse novo cliente
            cliente.Profissao = "Pedagoga";

            conta.Titular = cliente; //Aqui é usado o set para alterar as propriedades do titular sem alterar a classe original, apenas com o objeto cliente
            Console.WriteLine(conta.Titular.Nome); //Aqui é usado o get para acecssar/retornar os valores que foram alterados
            Console.WriteLine(conta.Titular.Profissao);
            Console.WriteLine(conta.Titular.CPF);

            conta.Agencia = 512;

            Console.ReadLine();
        }
    }
}