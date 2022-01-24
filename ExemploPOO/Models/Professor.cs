using System;

namespace ExemploPOO.Models
{
    public class Professor:Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Hello, I'm {Nome}, I'm {Idade} years old and have {Salario} salary.");
        }
    }
}