
using System;

public class TriangleProgram
{

    public void Triangle() {
        float basesize, height, area;

        Console.WriteLine("Enter the base size of the triangle :");
        basesize = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle :");
        height = float.Parse(Console.ReadLine());

        area = (basesize * height) / 2;
        Console.WriteLine("Area of Triangle is : " + area);

    }
    public static void Main1(string[] args)
    {
        TriangleProgram tr = new TriangleProgram();
        tr.Triangle();
    }
}