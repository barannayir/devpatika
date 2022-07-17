
while (true)
{
    try
    {
        Console.WriteLine("Lütfen bir kelime ve bir numara giriniz: ");
        string input = Console.ReadLine();
        int indeks = int.Parse(input.Split(',')[0]);
        string kelime = input.Split(",")[1];

        if (indeks < kelime.Length)
        {
            string yeni = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                yeni = (i != indeks) ? (yeni + kelime[i]) : (yeni);
            }
            Console.WriteLine(yeni);
        }
        Console.WriteLine();
    }
    catch (Exception)
    {

    }
}