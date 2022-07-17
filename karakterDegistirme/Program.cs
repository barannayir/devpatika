
while (true)
{
    Console.WriteLine("kelimeleri aralarında boşluk bırakarak giriniz.");
    string[] str = Console.ReadLine().Split();

    foreach (var item in str)
    {
        char[] cies = item.ToCharArray();
        char tasiyici = cies[0];
        cies[0] = cies[cies.Length - 1];
        cies[cies.Length - 1] = tasiyici;

        string s = "";
        foreach (var c in cies)
            s += c.ToString();
        Console.Write(s + " ");
    }
    Console.WriteLine();
}