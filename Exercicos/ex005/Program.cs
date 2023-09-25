class ex005
{
    public static void Main()
    {
        ListaDoChurrasco();
         
         //Chamando outro metodo

    }

    public static void ListaDoChurrasco()
    {
     //Declarar o vetor com 6 posiçoes tipo string
     string[] lista = new string[6];
     //Receber os produtos que precisam ser comprados
    for (int i = 0; i < 6; i++)
    {
      
      //Console para informar o produto a comprar
      Console.WriteLine("Digite o produto que vamos comprar");
      //Declarar uma variavel produto para receber o que eu escrever no ReadLine
      string produto = Console.ReadLine();
      //Atribuir no meu vetor o produto que eu digitei pela posiçao
      lista[i] = produto;
    }
    
    //Ordenar meu vetor 
    Array.Sort(lista);


    //Para cada item na lista imprimiro produto
    foreach (string item in lista){
        Console.WriteLine(item);
    }


    }

}