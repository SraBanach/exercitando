﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercitando
{
    internal class atv3
    {

        public void atividade3()
        {
            Console.Clear();
            Console.WriteLine("Escreva um programa que verifique se um numero é par ou impar");
            int opcaoescolhida = int.Parse(Console.ReadLine());

            if (opcaoescolhida % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
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
