using Models;


public class Program
{



    public static void Main()
    {
        //Criando um objetonda classe Pessoa
        //Instanciando sem um metodo construtor
        /*Pessoa pessoa1  = new Pessoa();
        pessoa1.nome = "Guilherme";
        pessoa1.idade = 25;
        pessoa1.Cantar();

        //Alternativa para criaçao de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
           nome = "Ricardo",
           idade = 22

        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Guilherme", 35 , "email");
        pessoa1.Cantar();
        pessoa1.informacoes();
    }
}