using System;

namespace ExemploPOO.Models
{
    public class Aluno:Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Hello, I'm {Nome}, I'm {Idade} years old and have {Nota} points.");
        }
    }
}