//Calculadora Cuidados da Mulher *GicellyGomes*
using System;
class Program
{
    static void Main()
    {

Console.WriteLine("Cuidados da Mulher - Cálculo de Exames");

            Console.Write("Digite seu nome:");
            String nome =
            Console.ReadLine();

            Console.Write("Digite sua data de nascimento (DD/MM/AAAA):");
            DateTime
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a data do início da vida sexual (DD/MM/AAAA):");
            DateTime
            inicioVidaSexual = DateTime.Parse(Console.ReadLine());

            Console.Write("Você tem vida sexual ativa? (Sim/Não):");
            bool vidaSexualAtiva = 
            Console.ReadLine().ToLower() == "Sim";

            Console.Write("Você utiliza camisinha? (Sim/Não):") ;
            bool usaCamisinha = 
            Console.ReadLine().ToLower() == "Sim";

            Console.Write("Você utiliza métodos contraceptivos? (Sim/Não):");
            bool usaContraceptivos = 
            Console.ReadLine().ToLower() == "Sim"; 

            Console.Write("Digite a data da última mestruação (DD/MM/AAAA):");
            DateTime
            ultimaMestruacao = DateTime.Parse(Console.ReadLine());

Console.WriteLine("\n***Recomendações para Exames***");
            // Cálculo para mamografia a cada 2 anos após os 40 anos
            int idade = 
            DateTime.Today.Year - 
            dataNascimento.Year;

            if (idade >= 40 && vidaSexualAtiva)
        {
              DateTime
              proximaMamografia = 
              inicioVidaSexual.AddYears(40).AddYears(2);

Console.WriteLine($"Próxima mamografia recomendada em:{proximaMamografia.ToString("dd/mm/yyyy")}");
        }
        else
        {

            Console.WriteLine("Recomendação: Consulte seu médico para orientações específicas.");
        }

           //Cálculo para Papanicolau a cada 1 ou 3 anos
           if(vidaSexualAtiva)
           {

           int
           intervaloPapanicolau = usaCamisinha && usaContraceptivos ? 3 : 1;
           DateTime
           proximoPapanicolau = 
           ultimaMestruacao.AddYears(intervaloPapanicolau);

Console.WriteLine($"Próximo Papanicolau Recomendado em:{proximoPapanicolau.ToString("dd/mm/yyyy)}");
           } 
            else
            {

            Console.WriteLine("Recomendação: Consulte seu médico para orientações específicas.");
               } 
            } 
    }    }


            


