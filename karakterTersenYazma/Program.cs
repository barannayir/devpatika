while (true)
{
    Console.WriteLine("Bir kelime giriniz: ");
    string input = Console.ReadLine();
    string output = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        output += input[i].ToString();
    }
    Console.WriteLine(output);
    Console.WriteLine();
}