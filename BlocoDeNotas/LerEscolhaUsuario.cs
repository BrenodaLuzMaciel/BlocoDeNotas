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

            Console.Write("Escolha um numero de 1 a 2 do Indice: ");
            bool eUmNumero = int.TryParse(Console.ReadLine(), out int escolhaIndice);

            while (!eUmNumero)
            {
                Console.Write("Escolha um numero de 1 a 2 do Indice: ");
                eUmNumero = int.TryParse(Console.ReadLine(), out escolhaIndice);
            }


            switch (escolhaIndice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite o nome do seu arquivo:");
                    nomeArquivo = Console.ReadLine();
                    Console.WriteLine("Digite seu texto aqui:");
                    string escritaUsuario = Console.ReadLine();
                    ReceberEscritaUsuario(escritaUsuario);
                    break;
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
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!" + e);
            }

        }
    }
}
