using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas
{
    internal class BlocoDeNotas
    {
        private bool FimDoPrograma;

        public BlocoDeNotas()
        {
            FimDoPrograma = false;
        }

        public void Iniciar()
        {
            while (!FimDoPrograma)
            {
                RenderizarMenu();
                new LerEscolhaUsuario().EscolhaMenu();
            }
        }

        private void RenderizarMenu()
        {
            Console.Clear();
            Console.WriteLine(EscolherMenu());
        }
 
        public string EscolherMenu()
        {
            return "1 - Iniciar editor de texto\n" +
                   "2 - Procurar um arquivo salvo\n" +
                   "3 - Sair do programa\n";

        }
    }
}
