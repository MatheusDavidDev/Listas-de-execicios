using System;

namespace Lista_app_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Entrada de dados
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            //Processamento
            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;


            //Exibição
            Console.WriteLine("Voçê tem "+meses+" Meses "+dias+" Dias "+horas+" Horas "+minutos+" Minutos");



        }
    }
}
