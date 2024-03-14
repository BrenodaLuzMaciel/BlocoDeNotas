using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas
{
    internal class LerEscolhaUsuario
    {
        string nomeArquivo = null;

        public void EscolhaMenu()
        {

            Console.Write("Escolha um numero de 1 a 3 do Indice: ");
            bool eUmNumero = int.TryParse(Console.ReadLine(), out int escolhaIndice);

            while (!eUmNumero)
            {
                Console.Write("Escolha um numero de 1 a 3 do Indice: ");
                eUmNumero = int.TryParse(Console.ReadLine(), out escolhaIndice);
            }


            switch (escolhaIndice)
            {
                case 1:

                    Console.Clear();
                    Console.Write("Digite o nome do seu arquivo: ");
                    nomeArquivo = Console.ReadLine();
                    //Verifica se o arquivo existe na pasta
                    VerificaArquivo();
                    Console.WriteLine("Digite seu texto aqui:");
                    string escritaUsuario = Console.ReadLine();
                    Console.Write("\nDeseja Salvar? 'S' ou 'N': ");
                    string sn = Console.ReadLine();
                    SalvarArquivo(sn);
                    ReceberEscritaUsuario(escritaUsuario);
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void SalvarArquivo(string sn)
        {
            if (sn == "s" || sn == "S")
                return;

            else
                new BlocoDeNotas().Iniciar();
        }

        private void VerificaArquivo()
        {
            string arquivo = @"C:\Users\Breno\source\repos\BlocoDeNotas\" + nomeArquivo;

            FileInfo file = new FileInfo(arquivo);

            if (!file.Exists)
            {
                Console.WriteLine("\nNome disponível");
                return;
            }
            if (file.Exists)
            {
                while (file.Exists)
                {
                    Console.Write("Este nome de arquivo já existe, digite outro nome: ");
                    //nomeArquivo = null;
                    nomeArquivo = Console.ReadLine();

                    arquivo = @"C:\Users\Breno\source\repos\BlocoDeNotas\" + nomeArquivo;

                    file = new FileInfo(arquivo);
                }
                Console.WriteLine("\nNome disponível");
            }
        }

        private void ReceberEscritaUsuario(string escritaUsuario)
        {
            string saidaTexto = @"C:\Users\Breno\source\repos\BlocoDeNotas\" + nomeArquivo;

            try
            {
                using (StreamWriter sw = File.CreateText(saidaTexto))
                {
                    sw.WriteLine(escritaUsuario);
                }
                Console.WriteLine("\nTexto salvo com sucesso! ");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial! ");
                Console.ReadLine();
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!" + e);
            }
            finally
            {
                new BlocoDeNotas().Iniciar();
            }
        }
    }
}
