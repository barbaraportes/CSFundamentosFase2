Console.WriteLine("## Conversão de tipos 1 ##\n");

//implicita
    //int varInt = 100; //int usa 4 bytes
    //double varDouble = varInt; //double usa 8 bytes
    //Console.WriteLine(varDouble);

////conversão de menor valor para maior valor - implicita - automatica

    //int numeroInt = 2145678;
    //long numeroLong = numeroInt;
    //float numeroFloat = numeroInt;
    //double numeroDouble = numeroInt;
    //decimal numeroDecimal = numeroInt;

    //Console.WriteLine(numeroInt);
    //Console.WriteLine(numeroLong);
    //Console.WriteLine(numeroFloat);
    //Console.WriteLine(numeroDouble);
    //Console.WriteLine(numeroDecimal);


//conversão de maior valor para menor valor - explicita

double varDouble = 12.456;             //8 bytes
int varInt = (int)varDouble;          //4 bytes (perda de precisão
Console.WriteLine(varInt);
//int não suporta casa decimal, compilador despreza tudo que tem depois do ponto

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;      //10/4 = 2.5
//com o (float) exibe 2,5 pq fez a conversão
Console.WriteLine(resultado);             //exibe 2 pq as variaveis são do tipo int



Console.ReadLine();