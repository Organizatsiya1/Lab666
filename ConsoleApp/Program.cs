using Model;

class Program
{
    static void Main()
    {
        var scientist = new Scientist
        {
            Name = "Иванов И.А.",
            BaseSalary = 100000
        };

        Console.WriteLine($"Сотрудник: {scientist.Name}");

        Console.WriteLine("\n\tСтратегия\n");

        Console.WriteLine($"1. Базовая зарплата (без стратегии): {scientist.BaseSalary:F2} руб.");

        scientist.BankService = new Sberbank();
        Console.WriteLine($"\n2. Сбербанк (с комиссией 1%): {scientist.CalculateSalary():F2} руб.");

        scientist.BankService = new GZBank();
        Console.WriteLine($"\n3. Газпромбанк (с комиссией 1.5%): {scientist.CalculateSalary():F2} руб.");

        Console.WriteLine("\n\tДекоратор\n");

        Console.WriteLine("1. Начало, без характеристик: " + scientist.GetInfo());

        var withEnglish = new IntermediateEnglishSertificate(scientist)
        {
            ExaminationTitle = "TOEFL",
            YearOfSertificate = 2024
        };
        Console.WriteLine("\n2. Добавление: " + withEnglish.GetInfo());

        var withDegree = new AcademicDegree(withEnglish)
        {
            DissertationTitle = "Жанровая типология романов",
            Year = 2026,
            ScienceArea = "Литература"
        };
        Console.WriteLine("\n3. Еще добавление: " + withDegree.GetInfo());
    }
}