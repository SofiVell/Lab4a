// Варіант 8
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Оберіть напрямок конвертації:");
        Console.WriteLine("1 — UAH → USD");
        Console.WriteLine("2 — USD → UAH");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть курс: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введіть суму в гривнях (UAH): ");
                double uah = Convert.ToDouble(Console.ReadLine());
                double usdResult = uah / rate;
                Console.WriteLine($"Результат: {usdResult:F2} USD");
                break;

            case 2:
                Console.Write("Введіть суму в доларах (USD): ");
                double usd = Convert.ToDouble(Console.ReadLine());
                double uahResult = usd * rate;
                Console.WriteLine($"Результат: {uahResult:F2} UAH");
                break;

            default:
                Console.WriteLine("Неправильний вибір! Введіть 1 або 2.");
                break;
        }
    }
}