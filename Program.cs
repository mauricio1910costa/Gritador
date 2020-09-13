using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome...");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Bom dia Sr. ");
            Console.WriteLine(nomeUsuario.ToUpper());
            Console.WriteLine("Digite a marca do carro...");
            string marcaCarro = Console.ReadLine();
            Console.Write("Não atendemos mais a marca ");
            Console.WriteLine(marcaCarro.ToUpper());
            Console.Write("TENHA UM BOM DIA");
            
            
        }
    }
}
