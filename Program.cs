Console.WriteLine("Tamanho do retângulo:");

Console.Write("Largura..: ");
int larg = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura...: ");
int alt = Convert.ToInt32(Console.ReadLine());

if (larg < 1 || larg > 10 || alt < 1 || alt > 10)
{
    Console.WriteLine("As medidas devem estar entre 1 e 10.");
}
else
{
    int linha = 1;
    while (linha <= alt)
    {
        Console.WriteLine();

        int coluna = 1;
        while (coluna <= larg)
        {

            if (linha == 1 || linha == alt)
            {
                Console.Write("*");
            }
            else
            {
                if (coluna == 1 || coluna == larg)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            coluna += 1;
        }

        linha += 1;
    }
}