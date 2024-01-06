namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Person[] people = new Person[]
        {
            new Person("Вікторія", "Мельник", "Андріївна", new Date(23, 5, 1992)),
            new Enrollee("Олександр", "Коваленко", "Іванович", new Date(15, 2, 2006), new ZnoList(190, 198, 178, 199), 10, "Державний університет «Житомирська політехніка»"),
            new Student("Дарина", "Петренко", "Володимирівна", new Date(10, 6, 2005), 2, "ЕК-2102", "Факультет економіки та управління", "Київський національний університет імені Тараса Шевченка"),
            new Professor("Андрій", "Сергієнко", "Михайлович", new Date(12, 3, 1984), "Доцент", "Кафедра міжнародних відносин", "Львівський національний університет імені Івана Франка"),
            new LibraryUser("Ірина", "Жукова", "Олександрівна", new Date(8, 4, 1999), 562748, new Date(15, 1, 2024), 50)
        };
        for (int i = 0; i < 5; i++) Console.WriteLine(people[i].ShowInfo());
    }
}