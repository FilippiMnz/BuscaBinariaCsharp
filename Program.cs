using System;
using System.Runtime.InteropServices.JavaScript;

namespace Busca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista Desordenada
            int[] numbers = { 4, 9, 2, 5, 10, 60, 23, 21 };
            //Ordenador de Lista
            int[] newNumbers = numbers.OrderBy(i => i).ToArray();
            Console.WriteLine(numbers);
            foreach (int elemento in newNumbers)
            {
                Console.WriteLine(elemento);
            }
            
            //BuscaBinaria

            int entradaDados = int.Parse(Console.ReadLine());
            int baixo = 0;
            int alto = newNumbers.Length -1;
            int meio = 0;   

    
            while(baixo <= alto)
            {
                    meio = (baixo + alto) / 2;
                int buscaCentro = newNumbers[meio];
                
                if (buscaCentro == entradaDados)
                {Console.WriteLine($"Número {entradaDados} encontrado na posição {meio}");
                    return;
                }if (buscaCentro > entradaDados)    
                {
                    alto = meio - 1;
                }else
                {
                    baixo = meio + 1;
                }
            }
            Console.WriteLine($"Número {entradaDados} não encontrado Na base informada.");

           
        }
    }
}