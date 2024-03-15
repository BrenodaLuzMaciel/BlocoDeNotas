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
            return "Bem vindo ao seu bloco de notas\n" +
                   "-------------------------------\n\n" + 
                   
                   "1 - Inserir uma nota\n" +
                   "2 - Ver todas as notas\n" +
                   "3 - Sair do programa\n";

        }
    }
}
