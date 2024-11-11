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
        //sempre deixar como public para conseguir abrir em outro local 
        public void atividade1()
        {
            Console.Clear();//limpar a tela 
            Console.WriteLine("Escreva um programa que verifique se o numero fornecido pelo usuario é positivo, negtivo ou zero");
            Console.WriteLine("Digite um numero: ");
            int opcaoescolhida = int.Parse(Console.ReadLine()); //transformando a variavel em numero inteiro e esperando ler
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
             
            Thread.Sleep(3000); //para esperar 3 segundos
            Console.Clear(); // para limpar a tela

            cbc variavelcbc = new cbc(); //chamar o cabecalho
            variavelcbc.cabecalho();

            pagInic variavelpagInic = new pagInic();// chamar o menu 
            variavelpagInic.paginainicial();

        }

    }
}
