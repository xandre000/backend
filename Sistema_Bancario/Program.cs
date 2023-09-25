using Bank;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("$$Bem-vindo ao Bank$$");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("Digite seu nome aqui ");


        Menu();

    }

    public static void Menu()
    {
        string titular = Console.ReadLine();
        ContaCorrente banco = new ContaCorrente(titular);
        string opcao = "";



        do
        {
            Console.WriteLine("###########MENU#########");
            Console.WriteLine("1- Consultar meu Saldo ");
            Console.WriteLine("2- Depositar um valor");
            Console.WriteLine("3- Sacar um valor");
            Console.WriteLine("4- Sair do Sistema");
            opcao = Console.ReadLine();


            switch (opcao)
            {

                case "1":

                    banco.ConsultarSaldo();
                    break;
                case "2":

                    banco.Depositar();

                    break;
                case "3":
                    banco.Sacar();
                    break;
                case "4":
                    Console.WriteLine("Voce acabou de sair");
                    break;
                default:
                    Console.WriteLine("Opçao Invalida");
                    break;

            }


        } while (opcao != "4");








    }
}


