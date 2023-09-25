﻿//Classe pai que será herdada pelofilho - SuperClasse
abstract class Animal
{

    public string cor { get; set; }


    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}
//Classe filha que herdará a classe Animal
//Receberá todos os atributos e metodos da SuperClasse

class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}



class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando");
    }
}



class Program
{
    public static void Main()
    {
        // Animal animalGenerico = new Animal();
        //animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();


    }
}