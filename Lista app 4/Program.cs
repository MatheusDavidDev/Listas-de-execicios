using System;

namespace Lista_app_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            Console.WriteLine("Digite sua idade nadador");
            int idade = int.Parse(Console.ReadLine());

            //processamento
            if(idade >= 5){

                if(idade <= 7){
                    Console.WriteLine("Sua cartegoria é a Infantil A");
                }

                if(idade >= 8){

                    if(idade <=10){
                    Console.WriteLine("Sua cartegoria é a Infantil B");

                    }
                }
            

                if(idade >= 11){

                    if(idade <=13){
                    Console.WriteLine("Sua cartegoria é a Juvenil A");

                    }
                    if(idade >=14){
                        if(idade <=17){
                            Console.WriteLine("Sua cartegoria é a Juvenil B");
                        }
                    }
                }

                if(idade >=18){
                    Console.WriteLine("Sua cartegoria é a Sênior");
                }


            }else{     
            Console.WriteLine("Infelizmente não temos categoria para você");  
            }        
                
        }
    }
}
