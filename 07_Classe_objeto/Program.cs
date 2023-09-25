//Sempre que formos utilizar bibliotexas ou classes ja criadas
//impotamos ela com using
using Sesi.Model;


class Program
{

    public static void Main()
    {
        //Criando uma variavel aluno1 e instanciando da classe aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atrbuindo um vlaor ao atributo do aluno1
        aluno1.nome = "alexandre";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";
        //Chamando o metodo da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificacaoAusencia(4);
         aluno1.ResumirFaltas();



        var aluno2 = new Aluno();
       //Atrbuindo um vlaor ao atributo do aluno1
       aluno2.nome = "alexandre";
       aluno2.idade = 16;
       aluno2.turma = "2º EM";
       //Chamando o metodo da classe Aluno
       aluno2.Apresentar();
    }
}