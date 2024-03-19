using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas
{
    internal class VisualizarNotas
    {
        public void VerTodasAsNotas()
        {
            string path = @"C:\Users\Breno\source\repos\BlocoDeNotas\Notas";

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", 
                SearchOption.AllDirectories);

            Console.WriteLine("Estas são as suas notas");
            Console.WriteLine("-----------------------\n");

            foreach (string file in files)
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));

        }
    }
}
