using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ContaCorrente.TotalDeContasCriadas = 1000;

            ContaCorrente conta = new ContaCorrente(867, 56487126);
            ContaCorrente Eduarda = new ContaCorrente(456, 48712654);

            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            Console.ReadLine();
        }
    }
}
