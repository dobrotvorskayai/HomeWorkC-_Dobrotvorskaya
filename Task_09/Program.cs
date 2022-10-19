// 9. Напишите программу, которая 
// - выводит случайное число из отрезка [10, 99] и 
// - показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;
// // Условный оператор
// // if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} равно {firstDigit}");

// // else Console.WriteLine($"Наибольшая цифра числа {number} равно {secondDigit}");

// // Тернарный оператор
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} равно {maxDigit}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} равно {maxDigit}");