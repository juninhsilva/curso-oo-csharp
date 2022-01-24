using System.IO;
using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Juninh";
            p1.Idade = 20;
            p1.Nota = 9.86;
            p1.Apresentar();

            Retangulo retangulo = new Retangulo();
            retangulo.GerarRetangulo(10, 10.2);
            Console.WriteLine(retangulo.ObterArea());

            Professor professor = new Professor();
            professor.Nome = "Juninh Silva";
            professor.Idade = 32;
            professor.Salario = 3200.86;
            professor.Apresentar();

            Conta cc = new ContaCorrente();
            cc.Creditar(100);
            Console.WriteLine(cc.Extrato());

            ICalculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Somar(10, 10));
            Console.WriteLine(calculadora.Subtrair(10, 17));
            Console.WriteLine(calculadora.Multiplicar(10, 10));
            Console.WriteLine(calculadora.Dividir(10, 50));

            FileHelper fileHelper = new FileHelper();
            var caminho = "/home/juninhsilva14/Documents/SI/cursos/cursoOOC#/ExemploPOO/Files/";
            fileHelper.ListarDiretorios(caminho);
            fileHelper.ListarArquivos(caminho);
            fileHelper.CriarDiretorio(Path.Combine(caminho, "Test 3", "SubTest 3"));
            //fileHelper.ApagarDiretorio(caminho, true);
            fileHelper.CriarArquivo(
                caminho, "arquivo-criado", ".txt", "Meu Arquivo");
            var conteudoStream = new List<string> {"Olá", "Meu arquivo com streams!" };
            fileHelper.CriarArquivo(caminho, "arquivo-stream", ".txt", conteudoStream);
            conteudoStream.Add("Mais texto");
            conteudoStream.Add("Mais texto 1");
            conteudoStream.Add("Mais texto 2");
            conteudoStream.Add("Mais texto 3");
            fileHelper.AdicionarTexto(caminho, "arquivo-criado", ".txt", "Escrever mais no arquivo.");
            fileHelper.AdicionarTexto(caminho, "arquivo-stream", ".txt", conteudoStream);
            fileHelper.LerArquivo(caminho, "arquivo-criado", ".txt");
            fileHelper.LerArquivo(caminho, "arquivo-stream", ".txt", true);
            fileHelper.CopiarArquivo(caminho, "arquivo-stream", ".txt", "cp-arquivo-stream");
            fileHelper.MoverArquivo(caminho, "arquivo-stream", ".txt", caminho+"/New Test/");
            fileHelper.DeletarArquivo(caminho, "arquivo-stream", ".txt");
        }
    }
}
