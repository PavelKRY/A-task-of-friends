Console.WriteLine("Введите чему равно а");
string numberA = Console.ReadLine();
Console.WriteLine("Введите чему равно b");
string numberB = Console.ReadLine();
Console.Write("Максимальное число это: ");
    if (Convert.ToInt32(numberA) > Convert.ToInt32(numberB))
        {
        Console.WriteLine(Convert.ToInt32(numberA));
        }
    else
        {
        Console.WriteLine(Convert.ToInt32(numberB));
        }
// после нового запуска VS Code подсвечивает папку как буд-то появились какие-то изменения
