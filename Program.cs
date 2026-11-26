using System;
using classlibrary;

class Program
{
    static void Main()
    {
        Student s = new Student(
            100,
            "Anuj",
            "MCA",
            "GLA University"
        );

        Console.WriteLine("Examination Application");
        s.DisplayDetails();

        Console.ReadLine();
    }
}