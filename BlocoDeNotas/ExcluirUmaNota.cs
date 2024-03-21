using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas
{
    internal class ExcluirUmaNota
    {
        public void Excluir()
        {
            Console.Write("\nQual nota você quer excluir? ");
            string excluir = Console.ReadLine();

            string notaExcluir = @"C:\Users\Breno\source\repos\BlocoDeNotas\Notas\" + excluir + ".txt";

            FileInfo file = new FileInfo(notaExcluir);
            if (file.Exists)
            {
                file.Delete();
                Console.WriteLine();
                Console.WriteLine(excluir + " deletado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para retornar ao índice!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Este arquivo não existe!");
            }
        }
    }
}
