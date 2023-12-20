

//1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato:
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.

//Console.WriteLine("EXERCICIO 1\n");

//string nome = "Paulo";
//int idade = 17;
//double nota = 7.5;

//Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
//Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

////2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

//Console.WriteLine("\nEXERCICIO 2\n");
//Console.Write($"{nome}\n{idade}\n{nota}");

////3 - Para qual tipo de dados você pode converter um float implicitamente ?
////( ) int
////(X) double
////( ) long
////(X) decimal


////4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
////( ) int para long
////(X) double para long
////(X) double para float
////(X) decimal para float
////(X) long para int
////(X) double para decimal


////5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
////a concatenação e também a interpolação de strings

//Console.WriteLine("\nEXERCICIO 5\n");

//Console.WriteLine("Informe a primeira letra:");
//char letra1 = Convert.ToChar(Console.Read());

//Console.WriteLine("Informe a segunda letra:");
//char letra2 = Convert.ToChar(Console.Read());

//Console.WriteLine("Informe a terceira letra:");
//char letra3 = Convert.ToChar(Console.Read());

//Console.WriteLine(letra3 + "-" + letra2 + "-"  + letra1);
//Console.WriteLine($"{letra3} - {letra2} - {letra1}");


////6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
////(F) long resultado = 1.32;
////(V) var nome = “Maria”;
////(V) string resultado = 100.ToString();
////(V) A sequência de escape \n inclui uma nova linha
////(F) float f = 5.45;
////(V) decimal valor = (decimal)10.99f;
////(F) var status = null;
////(V) object o = 12.45m;
////(V) string titulo = true.ToString();
////(F) A sequencia \t inclui uma tabulação vertical


////7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir
////realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
////exibindo o resultado:

//Console.WriteLine("\nEXERCICIO 7\n");

//double valor1, valor2;

//Console.WriteLine("Informe o primeiro valor");
//valor1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Informe o segundo valor");
//valor2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"soma dos valores = {valor1 + valor2}");
//Console.WriteLine($"subtração dos valores = {valor1 - valor2}");
//Console.WriteLine($"multiplicação dos valores = {valor1 * valor2}");
//Console.WriteLine($"exponenciação dos valores = {Math.Pow(valor1, valor2)}");
//Console.WriteLine($"divisão dos valores = {valor1 / valor2}");
//Console.WriteLine($"módulo dos valores = {valor1 % valor2}");



////8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c .
////Valores : a = 1 , b = 12 e c = -13

//Console.WriteLine("\nEXERCICIO 8\n");

//int valorA = 1;
//int valorB = 12;
//int valorC = -13;

//double delta, x1, x2;

// delta = Math.Pow(valorB, 2) - 4 * valorA * valorC;
// x1 = ((-valorB) + Math.Sqrt(delta)) / 2 * valorA;
// x2 = ((-valorB) - Math.Sqrt(delta)) / 2 * valorA;

//Console.WriteLine("x1 = " + x1);
//Console.WriteLine("x2 = " + x2);


//9 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)

Console.WriteLine("Informe o nome \t");
string? nome = Console.ReadLine();

Console.WriteLine("Informe a senha \t");
int? senha = Convert.ToInt32(Console.ReadLine());

string mensagem = (nome == "admin" || nome == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";

Console.WriteLine(mensagem);


//10 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis considerando
//a nomenclatura usada:
//(V) string? nome; é um exemplo de nullable reference type;
//(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
//(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
//(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
//(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
//(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
//(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
//(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
//(F) Para x = 5, a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
//(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
//(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"


//11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.Write("\nInforme o valor de x : \t");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y : \t");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x % 2 == 0 ? "x é par " : "x não é par");
Console.WriteLine(y % 2 == 0 ? "y é par " : "y não é par");
Console.ReadKey();


//12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
//console o resultado das seguintes operações: (x ^ 2->x ao quadrado) (pi = 3.1415)

//-6 + x * 5
//(13 - 2) * x
//(x + -2) * (20 / x)
//(12 + x) / (x - 4)
//3 x ^ 2 + x + 10
//pi* x^2


//Console.Write("Informe o valor de x : \t");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(-6 + x * 5);
//Console.WriteLine((13 - 2) * x);
//Console.WriteLine((x + -2) * (20 / x));
//Console.WriteLine((12 + x) / (x - 4));
//double resultado = 3 * Math.Pow(x, 2) + x + 10;
//double area = Math.PI * Math.Pow(x, 2);
//Console.WriteLine(resultado);
//Console.WriteLine(area);
//Console.ReadKey();



//13 - Considere o seguinte trecho de código:
//int y = 5;
//y = (y++) + y + (++y); ou y = y++ + y + ++y;
//Console.WriteLine(y);

//y = 18
//y++ retona 5 e incrementa para 6
//++y incrementa 6 para 7
//y = (5+6+7) = 18



//14 - Escreva um programa que solicite a temperatura em graus Celsius e converta para
//Kelvin e Farhenheit usando as fórmulas a seguir:
//-Converter para Kelvin => K = C + 273;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;


//Console.Write("Informe o valor em graus Celsius: ");
//double celsius = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Graus Kelvin = {celsius + 273}");
//double farhenheit = (celsius * 9) / 5 + 32;
//Console.WriteLine($"Graus Fahrenheit = {farhenheit}");
//Console.ReadKey();


//15 - Escolha a opção que representa a exibição do resultado para o código usando os
//operadores de decremento e incremento (pré e pós):

//var numero = 5;
//Console.WriteLine(numero++);
//numero = 1;
//Console.WriteLine(++numero);
//numero = 2;
//Console.WriteLine(numero--);
//numero = 3;
//Console.WriteLine(--numero);
//Console.ReadKey();



// 5 - 2 - 2 - 2

