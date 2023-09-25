namespace Bank
{
    public class ContaCorrente
    {



        private string titular { get; set; }

        private double saldo { get; set; }



        public ContaCorrente(string titularContaCorrente)
        {
            this.titular = titularContaCorrente;
            this.saldo = 200;

        }

       public void ConsultarSaldo()
    {
        Console.WriteLine($"{saldo} o seu saldo é de R${saldo}");
    }

        public void Depositar()
        {

          Console.WriteLine("digite o valor que voce deseja depositar...");
           double valor = double.Parse(Console.ReadLine());

            if (saldo < 0)
            {
                Console.WriteLine("Invalido");
                
            }
            else
            {
                saldo += valor;
                
                Console.WriteLine($"Seu saldo foi atualizado para R${valor}");

            }


        }

        public void Sacar()
        {

            Console.WriteLine("digite o valor que voce deseja sacar...");
           double valor = double.Parse(Console.ReadLine());

            if (saldo <= 0)
            {
                
                Console.WriteLine("Invalido");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"voce acabou de sacar R${valor}");
            }



        }
    }
}