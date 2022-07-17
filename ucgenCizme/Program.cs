
while (true)
{
    Console.WriteLine("Lütfen boyut bilgisi giriniz: ");
    int boyut = int.Parse(Console.ReadLine());

    for (int i = 1; i < boyut; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}