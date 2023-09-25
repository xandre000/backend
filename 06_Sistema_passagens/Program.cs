using System.Runtime.CompilerServices;

class Program
{
      public static string[] poltronas = new string[43];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao LexBus");
        Console.WriteLine("-------------------");
        Console.WriteLine("Contamos com 42 lugares disponiveis");

        Menu();

    }
    public static void Menu()
    {


        string opcao = "";

        do 
        {
            Console.WriteLine("###########MENU#########");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponiveis");
            Console.WriteLine("3- Para fechar o sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {




                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    ComprarPassagem();

                    break;
                case "2":
                    PoltronasDisponiveis();

                    break;
                default:


                    Console.WriteLine("Opçao Invalida");
                    break;


            }

        }



    }
    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagem = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagem; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis()
    {

        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 42; i++)
        {
            if (poltronas[i] == null)
            {
              Console.WriteLine($"Nº {i}" );
            }

        }





    }








}