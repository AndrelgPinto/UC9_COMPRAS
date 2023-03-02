// Criar variáveis necessarias
int i;


double produto, total;
for (i = 1; i <= 5; i++)
{
    Console.WriteLine("informe o " + i "° valor de produto");
    produto = double.Parse(Console.ReadLine());
    total = total + produto;
}
