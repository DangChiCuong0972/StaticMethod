using System.Security.Authentication.ExtendedProtection;

public class Student
{
    private int serial ;
    private string name;

    private static string college = "RedSchool";

    public Student(int s , string n)
    {
        serial = s;
        name = n;
    }

    public static void Change()
    {
       college = "OrangeSchool";
    }

    public void Display()
    {
        Console.WriteLine(serial + ", " + name + ", " + college );
    }

}