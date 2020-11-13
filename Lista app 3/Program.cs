using System;

namespace Lista_app_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            Console.WriteLine("Digite seu salario");
            int salario = int.Parse(Console.ReadLine());
            
            //processamento
            if(salario < 500){
                int porcentagem = salario * 30 / 100; 
                int aumento = porcentagem + salario;
                Console.WriteLine("Seu salário reajustado é de "+aumento);   

            }else{
                Console.WriteLine("Você não recebera aumento");

            }


            //Exibição

        }
    }
}
