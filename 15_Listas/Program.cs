using System.Collections.Generic;
using Sesi.Models;
public class Program
{

    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista
        listaNumeros.Add(10);  //posição [0]
        listaNumeros.Add(20);  //posição [1]
        listaNumeros.Add(45);  //posição [2]

        //Acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[0]);


        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(45);  //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        ///////////////////

        List<string> listaNomes = new List<string>();

        listaNomes.Add("gabriela");  //posição [0]
        listaNomes.Add("baruela");  //posição [1]


        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);
        Console.WriteLine($"Neste momento temos {listaNomes.Count} elementos");
        Console.WriteLine("#################################################");

        //Ciando uma lista de numeros já atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elementos na lista numeros: {numeros.Count}");
        numeros.Remove(2);  //Remover o elemento 2
        numeros.RemoveAt(1); //Remove o elemento no indice 1
        numeros.RemoveRange(2, 2); //Remover 2 elementos apartir do indice 2

        //Substitundo informaçao do item da lista
        numeros[0] = 100;


        //iterando sobre todos os itens da lista 
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }



        //Criando uma lista com objetos da Classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adcionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine(item.nome);

            Console.WriteLine(item.idade);
        }


        //Criando uma nova lista, ordenando por nome
        var ordenacao = from aluno in listaAlunos

                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;


        foreach (var Aluno in ordenacao)
        {
            Console.WriteLine(Aluno);
        }


        //LINQ utilizando Sintaxe de método
        var consulta = listaAlunos
            .Where(aluno => aluno.idade == 17)
            .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }



}