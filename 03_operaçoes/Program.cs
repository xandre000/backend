// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Digite o número x:")
int x = int.Parse(Console.Readline());

Console.WriteLine("Digite o número y:")
int y = int.Parse(Console.Readline());

//exemplos de operadores aritiméticos
int soma = x + y;
int subtraçao = x - y;
int multiplicaçao = x * y;
int divisao = x / y;
int resto = x % y; //Calculando o resto da divisao de x / 2
int restoDiv2 = x % 2; //Calculando o resto da divisao de x / 2

//console para exibir na tela as variaveis em cada linha
// Soma: 15 
console.WriteLine($"soma:{soma}");
console.WriteLine("subtraçao:{soma}");
console.WriteLine("multiplicaçao :" + multiplicaçao);
console.WriteLine("divisao" + divisao);
console.WriteLine("resto:" + resto);


if (restoDiv2 == 0)
{
    console.WriteLine($"O numero {x} é par");
}
else
{
    nsole.WriteLine($"O numero {x} é impar");
}

string resultado = (restoDiv2 == 0)  ? $"O numero {x} é par" : $"O numero {x} é impar";
console.WriteLine(resultado);

int diaSemana = 3;
//Aprendendo o switch Case
switch (diaSemana) {

 case 1 :
 Console.WriteLine("Hoje é domingo!");
break;

case 2 :
 Console.WriteLine("Hoje é segunda!");
break;

case 3 :
 Console.WriteLine("Hoje é terça!");
break;

case 4 :
 Console.WriteLine("Hoje é quarta!");
break;

case 5 :
 Console.WriteLine("Hoje é quinta!");
break;

case 6 :
 Console.WriteLine("Hoje é sexta!");
break;

case 7 :
 Console.WriteLine("Hoje é sábado!");
break;
default:
Console.WriteLine("Hoje é invalido!");




}

 





