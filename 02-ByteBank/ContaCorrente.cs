
using System;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia; 
        public int numero;
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                Console.WriteLine("O saldo não pode ser alterado!");
            }
            else
            {
                this.saldo += saldo;
                Console.WriteLine("Saldo definido com sucesso! Novo valor: " + this.saldo);
            }
        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor) //O this serve pra pegar o saldo da instancia que o método for usado.
            {
                return false;
            }
            else
                saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
