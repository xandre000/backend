using System.IO;



public class Program
{

    public static void Main()
    {
        //chamando o metodo GravarArquivo
        //GravarArquivo();
        //Chamando o metodo LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {

        try
        {
            string caminhoArquivo = "Arquivo/arquivo.txt";
             //Verificar se o arquivo existe
             if (File.Exists("Arquivo/arquivo.txt") == false)
             {

              //Criando meu arquivo.txt, este comando é executado quando
              //a verificação no if é falsa ou seja o arquivo não existe
              File.Create("Arquivo/arquivo.txt");


             }

            //instanciando um objeto da Classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader("Arquivo/arquivo.txt"))
            {
                string linha;
                //Fazendo o while para ler linha por linha que contêm no arquivo
                while ((linha = arquivo.Readline() != null))

        }
        }
     }
    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                Console.WriteLine("digite uma informaçao para ser gravada")
                    arquivo.WriteLine(Console.Readline());
                Console.WriteLine("informaçoes gravadaas")
                }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}
