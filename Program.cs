using System;

namespace AlunosExercicioArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos alunos tem na sala?");
            int tamanho = int.Parse(Console.ReadLine());

            string[] nomeAlunos = new string[tamanho];

            for (var i = 0; i < nomeAlunos.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomeAlunos[i] = Console.ReadLine();
            }    
            Console.WriteLine("A sala tem os seguintes alunos:");
            for (var i = 0; i < nomeAlunos.Length; i++)
            {
                Console.WriteLine(nomeAlunos[i]);
            }
        }
    }
}
