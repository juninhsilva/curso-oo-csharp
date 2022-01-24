using System;
using System.Collections.Generic;
using System.IO;
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho) {
            var retornoCaminho = Directory.GetDirectories(caminho);
            foreach (var c in retornoCaminho)
            {
                Console.WriteLine(c);
            }
        }

        public void ListarArquivos(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
            foreach (var c in retornoCaminho)
            {
                Console.WriteLine(c);
            }
        }

        public void CriarDiretorio(string caminho) {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno);
        }

        public void ApagarDiretorio(string caminho, bool recursivo)
        {
            Directory.Delete(caminho, recursivo);
            Console.WriteLine(caminho);
        }

        public void CriarArquivo(string caminho, string nome, string extensao, string conteudo) {
            var caminhoArquivo = Path.Combine(caminho, nome + extensao);
            File.WriteAllText(caminhoArquivo, conteudo);
            Console.WriteLine("Arquivo criado");
        }

        public void CriarArquivo(string caminho, string nome, string extensao, List<string> conteudo)
        {
            var caminhoArquivo = Path.Combine(caminho, nome + extensao);
            using (var stream = File.CreateText(caminhoArquivo))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
                Console.WriteLine("Arquivo criado com streams");
            }
        }

        public void AdicionarTexto(string caminho, string nome, string extensao, string conteudo) {
            var caminhoArquivo = Path.Combine(caminho, nome + extensao);
            File.AppendAllText(caminhoArquivo, conteudo);
            Console.WriteLine("Arquivo alterado");
        }

        public void AdicionarTexto(string caminho, string nome, string extensao, List<string> conteudo)
        {
            var caminhoArquivo = Path.Combine(caminho, nome + extensao);
            using (var stream = File.AppendText(caminhoArquivo))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
                Console.WriteLine("Arquivo alterado com streams");
            }
        }

        public void LerArquivo(string caminho, string nome, string extensao)
        {
            var caminhoArquivo = Path.Combine(caminho, nome + extensao);
            var conteudo = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }
        }

        public void LerArquivo(string caminho, string nome, string extensao, bool isStream)
        {
            if(isStream){
                string linha = string.Empty;
                var caminhoArquivo = Path.Combine(caminho, nome + extensao);
                using (var stream = File.OpenText(caminhoArquivo))
                {
                    while ((linha = stream.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
        }

        public void MoverArquivo(string caminho, string nome, string extensao, string destino)
        {
            if (destino != null)
            {
                var caminhoArquivo = Path.Combine(caminho, nome + extensao);
                var destinoArquivo = Path.Combine(destino, nome + extensao);
                File.Move(caminhoArquivo, destinoArquivo);
                Console.WriteLine("Arquivo movido com sucesso");
            }
        }

        public void CopiarArquivo(string caminho, string nome, string extensao, string novoNome)
        {
            if (novoNome != null)
            {
                var caminhoArquivo = Path.Combine(caminho, nome + extensao);
                var destinoArquivo = Path.Combine(caminho, novoNome + extensao);
                File.Copy(caminhoArquivo, destinoArquivo);
                Console.WriteLine("Arquivo copiado com sucesso");
            }
        }

        public void DeletarArquivo(string caminho, string nome, string extensao)
        {
            if (caminho != null)
            {
                var caminhoArquivo = Path.Combine(caminho, nome + extensao);
                File.Delete(caminhoArquivo);
                Console.WriteLine("Arquivo deletado com sucesso");
            }
        }
    }
}