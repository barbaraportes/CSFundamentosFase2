Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme seu nome: ");
string nome = Console.ReadLine();


Console.WriteLine("\nInforme sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
//int idade = Console.Read();
//console.read recebe apenas 1 caractere e retorna seu codigo ASCII

Console.WriteLine($"\nO seu nome é {nome}");
Console.WriteLine($"\nEvocê tem {idade} anos");


Console.ReadKey(); //le apenas um caractere - utilizado para segurar tela
