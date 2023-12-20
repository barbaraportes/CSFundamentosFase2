Console.WriteLine("## Conversão de tipos 2 ##\n");

//int valorInt = 123;
//double valorDouble = 12.45;
//decimal valorDecimal = 12.45678m;

//string s1 = valorInt.ToString();    
//string s2 = valorDouble.ToString();
//string s3 = valorDecimal.ToString();

//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);


int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

//ampliação - converter de um tipo de menor capacidade para um tipo de maior
//estreitamento - converter de um tipo de maior capacidade para um tipo de menor

//quando conversao de estreitamento resultar em perda de dados, ocorre 'OverflowException' (erro quando executa o programa)

int varInt = 1000;
Console.WriteLine(Convert.ToByte(varInt));


Console.ReadLine();