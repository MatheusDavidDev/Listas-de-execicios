using System;

namespace Lista_app_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.WriteLine("Digite seu ano de nascimento");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            int atual = int.Parse(Console.ReadLine());

            //processamento
            int idade = atual - nascimento;
            int semana = idade * 48;



            //exibição
            Console.WriteLine("Sua idade é de "+idade+" anos e você tem "+semana+"semanas");
            
        }
    }
}
