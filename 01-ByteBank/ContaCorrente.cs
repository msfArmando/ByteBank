
namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia; 
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor) //O this serve pra pegar o saldo da instancia que o método for usado, e não do valor padrão da classe
            {
                return false;
            }
            else
                this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
