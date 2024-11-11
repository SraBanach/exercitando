using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitando
{
    internal class pagInic
    {

        public void paginainicial()
        {
            Console.WriteLine("Escolha uma atividade:");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("Atividade 3");
            Console.WriteLine("Atividade 4");
            Console.WriteLine("Atividade 5");
            Console.WriteLine("Atividade 6");
            Console.WriteLine("Pressione 00 para sair");

            int opcaoescolhida = int.Parse(Console.ReadLine());

            switch (opcaoescolhida)
            {
                case 1:
                    //nome do arquivo, nome da variavel =  cria uma nova funcao
                    //variavel.o public void 
                    atv1 variavel1 = new atv1();
                    variavel1.atividade1();

                    break;
                case 2:
                    atv2 variavel2 = new atv2();
                    variavel2.atividade2();
                    break;
                case 3:
                    atv3 variavel3 = new atv3();
                    variavel3.atividade3();
                    break;
                case 4:
                    atv4 variavel4 = new atv4();
                    variavel4.atividade4();
                    break;
                case 5:
                    atv5 variavel5 = new atv5();
                    variavel5.atividade5();
                    break;
                case 6:
                    atv6 variavel6 = new atv6();
                    variavel6.atividade6();
                    break;
            }

        }

    }
}
