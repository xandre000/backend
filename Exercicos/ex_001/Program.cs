
Console.WriteLine("digite aqui a sua nota!");
int NotaAluno1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite aqui a sua nota!");
int NotaAluno2 =  int.Parse (Console.ReadLine());
Console.WriteLine("digite aqui a sua nota!");
int NotaAluno3 =  int.Parse(Console.ReadLine());

int Notadetodos = (NotaAluno1 + NotaAluno2 + NotaAluno3) /3 ;

if (Notadetodos >= 7)
{
    Console.WriteLine($"O Aluno foi aprovado");
}
else
{
    Console.WriteLine($"O Aluno foi reprovado");
}

