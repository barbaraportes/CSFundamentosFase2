Console.WriteLine("## Operador Ternário ##\n");

//operador uniário -> ++, --, !, +, -

//operador binário -> &&, ||, !=, >, <, >=, <=, *=, /=, %=, +=, -=, ==, =, *, +, -, /, %

//operador ternário -> utiliza 3 argumentos e avalia uma expressão booleana -> ? :
//usado para validar uma condição
//condição ? expressão1_se_true : expressão2_se_false


//Console.WriteLine("Informe a temperatura:");
//var temp = Convert.ToDouble(Console.ReadLine());
//var resultado = temp > 27 ? "Quente" : "Normal";
//Console.WriteLine($"O tempo está {resultado}");




//aninhamento de operador condicional ternário

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";






Console.ReadKey();