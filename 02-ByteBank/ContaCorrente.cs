
using System;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public int agencia; 
        public int numero;
        private double _saldo = 100;

        /*public Cliente Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }*/

        public Cliente Titular { get; set; } //Método refatorado!

        public double Saldo
        {
            get { return _saldo; } //Saída - Retorna

            set { //Entrada - Altera
                if (value < 0)
                {
                    Console.WriteLine("O saldo não pode ser alterado!");
                }
                else
                {
                    this._saldo += value;
                    Console.WriteLine("Saldo definido com sucesso! Novo valor: " + this._saldo);
                }
            }
        }


        /*public void SetSaldo(double saldo) //Setter
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

        public double GetSaldo() //Getter
        {
            return saldo;
        }*/

        public bool Sacar(double valor)
        {
            if (_saldo < valor) //O this serve pra pegar o saldo da instancia que o método for usado.
            {
                return false;
            }
            else
                _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
