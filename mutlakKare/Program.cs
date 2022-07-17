
while (true)
{
    try
    {
        Console.WriteLine("Sayıları aralarında boşluk bırakarak yazınız: ");
        string[] str = Console.ReadLine().Split();

        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        foreach (string s in str)
        {
            int sayi = int.Parse(s);

            if (sayi < 67)
            {
                list.Add(67 - sayi);
            }
            else
            {
                list2.Add(sayi - 67);
            }
        }
        int top1 = 0;
        foreach (var item in list)
            top1 += item;

        int top2 = 0;
        foreach (var item in list2)
            top2 += item * item;

        Console.WriteLine(top1 + " " + top2);
    }
    catch (Exception)
    {

    }
}