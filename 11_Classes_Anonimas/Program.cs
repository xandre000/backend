public class Program
{


    public static void Main()
    {

        //Criando uma classe anonima (classe sem definiçao)

        var pessoa1 = new
        {
            nome = "Joao",
            idade = 17

        };
        var pessoa2 = new
        {
            nome = "Maria",
            email = "mariazinhadusenai@17"


        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos ");
         Console.WriteLine($"A pessoa2 é{pessoa2.nome} e tem o email {pessoa2.email}");

         //pessoa1.nome = "douglas"
         //Criar 2 objetos de classe anonima de Carro

          var carro = new
        {
            marca = "bmw",
           modelo = "x1",
            ano = 2020


        };
        var carro = new
        {
            marca = "toyota",
            modelo = "caminhonete",
            ano = 2020


        };
      

    }
}