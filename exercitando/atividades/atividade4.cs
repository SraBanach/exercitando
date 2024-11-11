using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atv4
    {

        public  void atividade4()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que leia o mes do ano e informe quantos dias ele tem");
            string opcaoescolhida = Console.ReadLine();

            if (opcaoescolhida == "abril" || opcaoescolhida == "junho" || opcaoescolhida == "setembro" || opcaoescolhida == "novembro")
            {
                Console.WriteLine("O mês tem 30 dias");
            }
            else if (opcaoescolhida == "fevereiro")
            {
                Console.WriteLine("O mês tem 28 dias");
            }
            else
            {
                Console.WriteLine("O mês tem 31 dias");
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
