using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas
{
    internal class AbrirUmaNota
    {
        public void VisualizarUmaNota()
        {
            Console.Write("\nQual o nome da Nota que você quer ver? ");
            string nome = Console.ReadLine();

            Console.Clear();

            string sourcePath = @"C:\Users\Breno\source\repos\BlocoDeNotas\Notas\" + nome + ".txt";

            FileInfo file = new FileInfo(sourcePath);
            if (file.Exists)
            {
                using (StreamReader sr = new StreamReader(sourcePath))
                {
                    string[] lines = File.ReadAllLines(sourcePath);

                    Console.WriteLine("Conteúdo da nota " + nome);
                    Console.WriteLine("-----------------------\n");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nome de arquivo inválido");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu iniciar");
                Console.ReadLine();
            }
        }
    }
}
