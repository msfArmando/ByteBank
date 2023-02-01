
using System;

namespace _03_ByteBank
{
    public class ContaCorrente
    {
        private int _agencia;
        private Cliente _titular;
        private double _saldo = 100;

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Número de agência inválido!");
                }
                else
                {
                    _agencia = value;
                }
            }
        }
        public int Numero { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public double Saldo
        {
            get { return _saldo; }
            set {
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

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
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

        public ContaCorrente(int agencia, int numero) //Construtor
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
    }
}
