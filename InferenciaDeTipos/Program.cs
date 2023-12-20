Console.WriteLine("## Inferencia de tipos (var) ##\n");


var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}"); //.ToString("c") formata para moeda local

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario:c}"); //forma simplificada



//limitações do var
//var salario = null;
//var titulo;
//var salario, imposto, total;

//não posso mudar o tipo apos incializar
var num = 10;
num = num + 20;
//num = "Teste";



var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu método");
    }
}


//Usos de var

//considerado sugarsyntax - mais facil de ser lida
//usada para declarar tipos anonimos
//usada em laços for e foreach
//usada em instruções using