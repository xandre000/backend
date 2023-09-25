class Program
{

    public static void Main()
    {
        Console.WriteLine("Digite o numero");
        int nrDigitado = int.Parse(Console.ReadLine());

        int valorDobro = Dobro(nrDigitado);
        Console.WriteLine($"O dobro de {nrDigitado} é {valorDobro}");

        int valorDobro = Metade(nrDigitado);
        Console.WriteLine($"O dobro de {nrDigitado} é {valorMetade}");

        Console.WriteLine("Escreva o numero");
        int n = int.Parse(Console.ReadLine());
        Tabuada(n);

        ResumoSalarios();

    }
    public static int Dobro(int valor)
    {

        int resultado = valor * 2;

        return resultado;
    }


    public static void Tabuada(int Valor)
    {
        int n = 0;
        while (n <= 10)
        {
            Console.WriteLine($"{n} x {Valor} = {n * Valor}");
            n++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int MenorSalario = 100000;
        int MaiorSalario = 0;
        int SalarioEmpregado = 0;

        do
        {
            Console.WriteLine("Digite o salario do empregado:")
             SalarioEempregado = int.Parse(Console.ReadLine())


             somaSalarios = somaSalarios + SalarioEmpregado;

            if (SalarioEmpregado > MaiorSalario)
            {
                MaiorSalario = SalarioEmpregado
             }
            if (SalarioEmpregado > MenorSalario)
            {
                MenorSalario = SalarioEmpregado





        } while (SalarioEmpregado > 0) ;

            Console.WriteLine($"A soma dos salarios sao {somaSalarios} o maior salario é {MaiorSalario} e o MenorSalario é {MenorSalario}")
}
    }
}