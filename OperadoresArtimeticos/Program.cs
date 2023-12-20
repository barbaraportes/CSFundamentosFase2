Console.WriteLine("## Operadores Artiméticos ##\n");


Console.WriteLine("Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());

//classes estaticas
Console.WriteLine($"\nRaiz quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de X elevado a Y = {Math.Pow(x,y)}");
Console.WriteLine($"\nValor minimo entre X e Y = {Math.Min(x,y)}");
Console.WriteLine($"\nValor maximo entre X e Y = {Math.Max(x,y)}");
Console.WriteLine($"\nCoseno de X = {Math.Cos(x)}");
Console.WriteLine($"\nSeno de X = {Math.Sin(x)}");
Console.WriteLine($"\nExponencial de X = {Math.Exp(x)}");


Console.ReadKey();


//Console.WriteLine($"Soma de x+y = {x+y}");
//Console.WriteLine($"Subtração de x-y = {x-y}");
//Console.WriteLine($"Multiplicação de x*y = {x*y}");
//double divisao = (double) x / y;
//Console.WriteLine($"Divisão de x/y = {divisao}");
////Console.WriteLine($"Divisão de x/y = {x/y}");  //int não armazena casa decimal
//Console.WriteLine($"Módulo de x%y = {x%y}");