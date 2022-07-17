
while (true)
{
    Console.WriteLine("\n\nkelimeleri giriniz: ");

    foreach (var item in Console.ReadLine().Split())
    {
        bool def = false;
        for (int i = 1; i < item.Length; i++)
        {
            if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                def = true;
        }
        Console.Write(def + " ");
    }

    bool sessizMi(char c)
    {
        return !"aeıioöuü".ToCharArray().Contains(c);
    }
}