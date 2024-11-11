using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atv1
    {

        public void atividade1()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que verifique se o numero fornecido pelo usuario é positivo, negtivo ou zero");
            Console.WriteLine("Digite um numero: ");
            int opcaoescolhida = int.Parse(Console.ReadLine());
            if (opcaoescolhida > 1)
            {
                Console.WriteLine("O numero é positivo");
            }
            else if (opcaoescolhida == 0)
            {
                Console.WriteLine("O numero é zero");
            }
            else
            {
                Console.WriteLine("O valor é negativo");
            }
            Thread.Sleep(3000);
            Console.Clear();

            cbc variavelcbc = new cbc();
            variavelcbc.cabecalho();

            pagInic variavelpagInic = new pagInic();
            variavelpagInic.paginainicial();

        }

    }
}
