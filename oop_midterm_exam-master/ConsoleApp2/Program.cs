using System;

public class Program
{

    public static void Main(string[] args)
    {

        var name = "Andre Victoria";
        int score = Examination.Start();

        Console.WriteLine($"Student: {name}\r\nScore: {score}/20");
        Console.ReadKey();
    }

        
       }
