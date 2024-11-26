
Console.Title = "SGK 3 Numbers Calculator";
Console.WriteLine("Выберите 1 число");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите 2 число");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите 3 число");
int Number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все числа записаны.");
Console.Write("Выберите какое действие необходимо совершить: 1 - Сложение | 2 - Вычитание |3 - Умножение | 4 Деление \n\n");
int moveselection = Convert.ToInt32(Console.ReadLine());

switch (moveselection)
{
    case 1:
        
        Console.WriteLine("Результат сложения ваших чисел " + (Number1 + Number2 + Number3));
        
        break;
    case 2:
        
        Console.WriteLine("Результат вычитания ваших чисел " + (Number1 - Number2 - Number3));
        
        break;
    case 3:
        
        Console.WriteLine("Результат умножения ваших чисел " + (Number1 * Number2 * Number3));
        
        break;
    case 4:
        
        Console.WriteLine("Результат деления ваших чисел " + (Number1 / Number2 / Number3));
        
        break;
    default:
        Console.WriteLine("Вы выбрали неверное действие. Укажите действия от 1 до 4");
        break;
}

await (Task.Delay(5000));

