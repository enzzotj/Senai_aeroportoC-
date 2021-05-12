using System;

namespace _12._05_Senai
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];
            bool senhavalida = false;
            bool pas = false;
            int c = 0;
            Console.WriteLine("Bem vindo!");

            while (senhavalida == false)
            {

                Console.Write("Digite sua senha = ");
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123456)
                {
                    senhavalida = true;
                    bool menus = false;
                    while (menus == false)
                    {
                        Console.WriteLine($@"
|-------------------------------------------------------------------------------|
|                                Meunu Principal                                |
|-------------------------------------------------------------------------------|
|                                                                               |
|        1- Cadastrar passagem        2- Listar Passagens        0- Sair        |  
|-------------------------------------------------------------------------------|

Escolha uma opção:");
                        int menu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        switch (menu)
                        {
                            case 1:
                            do {
                                Console.Write("Qual é o nome do passageiro: ");
                                nomes[c] = Console.ReadLine().ToUpper();

                                Console.Write("Qual é a origem: ");
                                origem[c] = Console.ReadLine().ToUpper();

                                Console.Write("Qual é o destino: ");
                                destino[c] = Console.ReadLine().ToUpper();

                                Console.Write("Qual é a data: ");
                                data[c] = Console.ReadLine();
                                c++;

                                Console.WriteLine("Gostaria de cadastrar uma nova passagem?(S/N) Maximo 5 passagem");
                                string cotpas = Console.ReadLine().ToUpper();
                                if (cotpas == "S"){
                                    pas = false;
                                }else {
                                    pas = true;
                                }

                                } while(pas == false);

                                Console.WriteLine("Aperte 'M' para voltar ao Menu");
                                string voltmenu = Console.ReadLine().ToUpper();

                                if (voltmenu == "M"){
                                menus = false;
                                }
                                break;

                            case 2:
                            Console.WriteLine($@"
|--------------------------------------------------------------|
|      1-Nome      2-Origem      3-Destino       4-Data        |
|--------------------------------------------------------------|");
                                for (var i = 0; i < c; i++)
                                {
                                    Console.WriteLine($@"|   {i + 1}º  {nomes[i]}   -   {origem[i]}   -   {destino[i]} -   {data[i]}   |");
                                }
                                    Console.WriteLine("|--------------------------------------------------------------|");

                                Console.WriteLine("Aperte 'M' para voltar ao Menu");
                                string voltmen = Console.ReadLine().ToUpper();

                                if (voltmen == "M"){
                                menus = false;
                                } 
                                break;

                            case 0:
                                Console.WriteLine("Você saiu :)");
                                menus = true;
                                break;
                            default:
                                Console.WriteLine("Opção não esta valida, tente novamente:");
                                menus = false;
                                break;
                        }
                    }
                } else
                {
                    Console.WriteLine("Senha incorreta :(");
                    Console.WriteLine("Tente novamente");
                }
            }
        }
    }
}
