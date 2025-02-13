using System;

class Rectangel
{
    public double width;
    public double height;

    static string opisanie;


    public Rectangel()
    {
        width = 2;
        height = 4;
    }

    public Rectangel(int width, int height)
    {
        this.width = width;
        this.height = height;  
    }
    public Rectangel(Rectangel rectangel) 
        {
        this.width = rectangel.width;
        this.height = rectangel.height;
        }
    static Rectangel()
    {
        opisanie = "Прямоугольник";
    }

    ~Rectangel()
    {
        Console.WriteLine("Деструктор вызван");
    }

    public double Ploshad()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangel rect = new Rectangel();
        Console.WriteLine($"Ширина: {rect.width}, Высота: {rect.height}, Площадь: {rect.Ploshad()}");
    }

}