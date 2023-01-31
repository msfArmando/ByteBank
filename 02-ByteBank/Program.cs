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
            Cliente cliente = new Cliente(); //Eu criei um cliente

            //Depósito na conta com set.
            conta.Depositar(80);

            //Console.WriteLine(conta.GetSaldo()); Pode-se substituir por:
            Console.WriteLine(conta.Saldo);

            //conta.SetSaldo(20); Pode-se substituir por:
            conta.Saldo = 20;

            cliente.nome = "Eduarda";          //Passei as propriedades
            cliente.cpf = "***.***.***-**";   //desse novo cliente
            cliente.profissao = "Pedagoga";

            conta.Titular = cliente; //Aqui é usado o set para alterar as propriedades do titular sem alterar a classe original, apenas com o objeto cliente
            Console.WriteLine(conta.Titular.nome); //Aqui é usado o get para acecssar/retornar os valores que foram alterados
            Console.WriteLine(conta.Titular.profissao);

            Console.ReadLine();
        }
    }
}