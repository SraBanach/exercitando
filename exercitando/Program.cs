using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    public class Program //sempre deixar como public 
    {
       public static void Main(string[] args)
        {

            cbc variavelcbc = new cbc();
            variavelcbc.cabecalho();
            // chamando cabecalho

            pagInic variavelpagInic = new pagInic();
            variavelpagInic.paginainicial();
            //chamando menu

        }

    }
}