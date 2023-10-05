Console.Write("Ingrese un número: ");

int altura = int.Parse(Console.ReadLine());

for (int numEscaleras = 1; numEscaleras <= altura; numEscaleras++)
{
    for (int i = 1; i < numEscaleras; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine("*");
}