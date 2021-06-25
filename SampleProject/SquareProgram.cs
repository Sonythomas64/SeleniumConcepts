using System;

public class SquareProgram
{

    public void Square() {

        int side, area;

        Console.WriteLine("Enter the length of the Square:");
        side = int.Parse(Console.ReadLine());

        area = side * side;
        Console.WriteLine("Area of the Sqaure is : " + area);
    }
    public static void Main(string[] args)
    {
        SquareProgram sq = new SquareProgram();
        sq.Square();



    }
}