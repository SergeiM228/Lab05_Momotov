// int dayNumber = 5;

// switch (dayNumber) {
//     case 5 or 7: Console.WriteLine("Выходной"); break;
//     default: Console.WriteLine("Будний"); break;

// }
int score = 50;

switch (score) {
    case >= 0 and <= 999:
        Console.WriteLine("Новичок");
        break;
    case >= 1000 and <= 4999:
        Console.WriteLine("Опытный");
        break;
    case >= 5000 and <= 9999:
        Console.WriteLine("Продвинутый");
        break;
    case < 0:
        Console.WriteLine("Ошибка");
        break;
    case >= 10000:
        Console.WriteLine("Мастер");
        break;
}
