using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testando os métodos
            
            ContaCorrente contaTeste = new ContaCorrente();

            //Tentando sacar um valor maior que o valor default da conta

            bool ResultadoDoSaque = contaTeste.Sacar(200); //Retornará false, pois 200 é maior do que o valor que tem na conta
            if (ResultadoDoSaque)
            {
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
                Console.WriteLine("Não foi possível realizar o saque!");

            Console.WriteLine(ResultadoDoSaque);

            //Agora veja o atual valor que tem na conta:
            Console.WriteLine("Saldo antes do depósito.");
            Console.WriteLine(contaTeste.saldo);
            //E agora veja o valor que vai ficar depois do depósito
            contaTeste.Depositar(200); //Certamente retornará 300
            Console.WriteLine("Saldo depois do depósito.");
            Console.WriteLine(contaTeste.saldo);

            //Agora vamos criar uma conta para fazer a transferência
            ContaCorrente contaTransferencia = new ContaCorrente();

            contaTeste.Transferir(100, contaTransferencia); //Após essa transferência, certamente teremos o valor 200 na conta teste, pois somamos os 100 com
            //os 200 depositados e tinhamos 300, mas depois de transferir 100 ficamos com 200, e a contaTransferencia também terá 200, pois além dos 100 default,
            //ela recebeu mais 100 da contaTeste
            Console.WriteLine("TRANSFERÊNCIA REALIZADA!");

            Console.WriteLine("Saldo da conta teste depois da transferência.");
            Console.WriteLine(contaTeste.saldo);
            Console.WriteLine("Saldo da conta Transferência depois da TRANSFERÊNCIA.");
            Console.WriteLine(contaTransferencia.saldo);

            Console.ReadLine(); //Não apaga o readline, se apagar o console nem abre direito.

            //Crio aqui um objeto da classe cliente
            Cliente armando = new Cliente();

            //E vou atribuindo os valores;
            armando.cpf = "***.631.394.**";
            armando.nome = "Armando";
            armando.profissao = "Desenvolvedor Estagiário";

            //E agora vou criar uma contam para o cliente em específico
            ContaCorrente armandoConta = new ContaCorrente();
            armandoConta.titular = armando;
        }
    }
}
