
Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);

//escreve na mesma linha 'Maria tem 25 anos'

//concatenação
Console.WriteLine(nome + " tem " + idade + " anos");

Console.WriteLine();

//interpolação de strings
Console.WriteLine($"{nome} tem {idade} anos");

Console.WriteLine();    

//placeholders
Console.WriteLine($"{0} tem {1} anos", nome, idade);



Console.ReadLine();
