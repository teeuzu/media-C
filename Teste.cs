using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
// utilizar estrutura de repetição dentro desse projeto
// nota de aluno
    public class Teste 
    {
           static void main (string [] args)
           {
           	Console.WriteLine ("Media de alunos ");
            float soma = 0;
           	float media = 0;
           	
           	for (int i= 0; i < 5 ; i++)
           	{
           		Console.WriteLine("Digite o valor real: " + 1 + ":");
           		float nota = 0;
           		float.Parse(Console.ReadLine());
           		soma += nota;
           	}
           	media = soma/5;
           Console.WriteLine ("A média é : " +media);
           Console.ReadKey();
           }
    }
}