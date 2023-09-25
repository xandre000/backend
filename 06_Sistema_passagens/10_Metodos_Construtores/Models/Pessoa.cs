namespace Models
{
    public class Pessoa
    {

        //Atributos da nossa classe pessoa

        private string nome { get; set; }

        private int idade { get; set; }

        private string email { get; set; }

        private int anoNascimento{ get; set; }


        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }



        //Metodo da Classe Pessoa

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void informacoes()
        {
            Console.WriteLine($" Meu nome é: {nome}, Minha idade é {idade}, Eu tenho um: {email}, E nasci em: {anoNascimento}");
        }
    }
}