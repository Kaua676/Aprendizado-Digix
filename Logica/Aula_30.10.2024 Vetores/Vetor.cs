//Formar de declarar vetores

int [] vetor1 = new int [5];
//Sem estabelecer tamanho
int [] vetor2 = new int [] {1, 2, 3, 4, 5};
int [] vetor3 = {1, 2, 3, 4, 5};
int [] vetor4 = {}; //Vetor vazio

//Acessando elementos
System.Console.WriteLine(vetor1[4]);

//Alterando elementos
vetor2[4] = 10;
System.Console.WriteLine(vetor2[4]);

//Percorrendo o vetor com for
for (int i = 0; i < vetor3.Length; i++)
{
    System.Console.WriteLine(vetor3[i]);
}

//Percorrendo o vetor com foreach
foreach (int i in vetor3)
{
    System.Console.WriteLine(i);
}

//Percorrendo o vetor com while
int i = 0;
while (i < vetor3.Length)
{
    System.Console.WriteLine(vetor3[i]);
    i++;
}

//Percorrendo o vetor com do while
i = 0;
do
{
    System.Console.WriteLine(vetor3[i]);
    i++;
}while (i <vetor3.Length);