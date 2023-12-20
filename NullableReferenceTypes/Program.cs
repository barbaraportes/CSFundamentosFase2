Console.WriteLine("## Nullable Reference Types - Alerta ativado ##\n");

//recurso de tempo de compilação onde o compilador usa análise estatica e emite avisos
//alerta sobre a possibilidade de ocorrer erro envolvendo manipulação de referencia nula
//finalidade é minimar a chance do app lançar um 'System.NullReferenceException' quando executado

//para evitar o NullReferenceException usa o tipo Nullable (?) ao atribuir o valor null
// e emprega Null Conditional Operador (?.) ao acessar a referencia

string? nome = null;
Console.WriteLine(nome?.ToUpper());
//se nome for null, atribui o valor null
//se nome não for null, aplica o método


// OU
//string nome = "";
//Console.WriteLine(nome?.ToUpper());

Console.ReadKey();
