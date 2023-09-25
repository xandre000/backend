public class Program
{





    public static void Main()
    {


        //O try serve para tratar um erro e nao parar a execuçao do programa
        //Se ocorrer qualquer erro dentro do bloco fly, o sistema interrompe
        //a execuçao do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.Readline());
            Console.WriteLine($"Voce digitou o nº  {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O resultado é: {resultado}");
        }
        //Tratando execeção de overflow (estouro de campo)
        catch (OverflowException)
        {
            Console.WriteLine("Este numero inteiro é maior que o suportado");
        }
        catch (FormatException)
        {
            Console.WriteLine($" Erro: Digite um numero inteiro");
        }
    }
        //catch é tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor coompreensao do usuario
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.}");

        }
        //O finally é um bloco executado independentemente se ocorrer um erro ou não
        finally
        {
    Console.WriteLine("Entrando no finally")
        }

    }

