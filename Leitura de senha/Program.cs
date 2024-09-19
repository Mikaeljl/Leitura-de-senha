using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_de_senha
{
    public class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 454545) {
                Console.WriteLine("Senha invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
