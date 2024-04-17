internal class Program
{
    private static void Main(string[] args)
    {
       Student.Change();
       Student st1 = new Student(126,"Huong");
       Student st2 = new Student(127,"Minh");
       Student st3 = new Student(128,"Linh");

       st1.Display();
       st2.Display();
       st3.Display();
       
    }
}