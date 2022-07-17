
Console.WriteLine("Sayıları aralarında boşluk olacak şekilde giriniz: ");

string[] str = Console.ReadLine().Split();

if (str.Length > 0)
{
    int[] d = new int[2];
    List<int[]> list = new List<int[]>();
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == " " || str[i] == "  " || String.IsNullOrEmpty(str[i]))
            continue;

        if (i % 2 == 0)
        {
            d = new int[2] { int.Parse(str[i]), 0 };
            if (i == str.Length - 1)
                list.Add(d);
        }
        else
        {
            d[1] = int.Parse(str[i]);
            list.Add(d);
        }
    }
    foreach (var item in list)
    {
        if (item[0] == item[1])
        {
            Console.Write((item[0] + item[1]) * (item[0] + item[1]) + " ");
        }
        else
        {
            Console.Write((item[0] + item[1]) + " ");
        }
    }
}