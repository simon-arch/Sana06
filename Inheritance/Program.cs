namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Enrollee enrollee = new Enrollee("Олександр", "Коваленко", "Іванович", new Date(15, 2, 2006), 150, 10, "Приклад");
        string name = enrollee.GetName();
        Console.WriteLine(name);
    }
}