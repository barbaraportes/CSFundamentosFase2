Console.WriteLine("## Operadores Incremento e Decremento\n");


//incremento
//int x = 10;
//x++; //x = x + 1
//Console.WriteLine(x);


//decremento
//int y = 10;
//y--; //y = y - 1
//Console.WriteLine(y);



//pos-incremento -> X++ -> primeiro resolve expressão depois incrementa
//int x = 0;
//Console.WriteLine($"X = {x}");
//int resultado1 = x++ + 10;
//Console.WriteLine($"pós-incremento -> {resultado1}");
//Console.WriteLine($"Valor de X -> {x}\n");

////pre-incremento -> ++Y -> primeiro incrementa depois resolve
//int y = 0;
//Console.WriteLine($"Y = {y}");
//int resultado2 = ++y + 10;
//Console.WriteLine($"pre-incremento -> {resultado2}");
//Console.WriteLine($"Valor de y -> {y}\n");



//pos-decremento -> X++ -> primeiro resolve expressão depois decrementa
int x = 0;
Console.WriteLine($"X = {x}");
int resultado1 = x-- + 10;
Console.WriteLine($"pós-decremento -> {resultado1}");
Console.WriteLine($"Valor de X -> {x}\n");

//pre-decremento -> --Y -> primeiro decrementa depois resolve
int y = 0;
Console.WriteLine($"Y = {y}");
int resultado2 = --y + 10;
Console.WriteLine($"pre-decremento -> {resultado2}");
Console.WriteLine($"Valor de y -> {y}\n");





Console.ReadKey();