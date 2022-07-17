
using System.Drawing;

public static class Circle
{
    public static void draw()
    {
        int input = Grid.input;
        int Merkez = input;
        Console.WriteLine(Grid.boyut + " X " + Grid.boyut + " pixel square");
        foreach (var item in Grid.points)
        {
            float leftSide = item.x * item.x + item.y * item.y;
            float RightSide = input * input;
            if (Math.Round(leftSide / (input * 2.5f)) == Math.Round(RightSide / (input * 2.5f)))
            {
                item.symbol = 'o';
            }
        }
        Console.WriteLine();
        for (int i = -input; i <= input; i++)
        {
            for (int j = -input; j <= input; j++)
            {
                foreach (var item in Grid.points)
                {
                    if (item.x == i && item.y == j)
                    {
                        Console.Write(item.symbol);
                        Console.Write(item.symbol);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
public static class ConsoleProcessor
{
    static Exception e = new Exception("lütfen console penceresi büyük olmadığı için 44'den küçük bir sayı giriniz. ");
    public static int input()
    {

        int yariçap = -1;
        Console.WriteLine("lütfen daire yarıçap uzunluğunu giriniz.");
        convert();
        void convert()
        {
            try
            {
                yariçap = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("lütfen bir sayı giriniz.");
                convert();
            }
            if (yariçap > 43)
            {
                Console.WriteLine(e.Message);
                convert();
            }
        }
        return yariçap;
    }
}
public static class Grid
{
    public static List<Point> points = new List<Point>();
    public static int boyut = 0;
    public static int input = -1;
    public static void draw()
    {
        input = ConsoleProcessor.input();

        boyut = input * 2 + 1;


        for (int ey = -input; ey < input + 1; ey++)
        {
            for (int ex = -input; ex < input + 1; ex++)
            {
                Point point = new Point();
                point.y = ey;
                point.x = ex;
                points.Add(point);
            }

        }

    }
}
public class Point
{
    public int x = 0;
    public int y = 0;
    public char symbol = ' ';

}
public class Program
{
    static void Main(string[] args) 
    {
        Grid.draw();
        Circle.draw();
    }
}