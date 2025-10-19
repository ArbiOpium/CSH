using System;
using System.Globalization;

public class Programma
{
    void Zadacha1()
    {
        Console.WriteLine("Введите число от 1 до 100:");
        int chislo = int.Parse(Console.ReadLine());

        if (chislo >= 1 && chislo <= 100)
        {
            if (chislo % 3 == 0 && chislo % 5 == 0)
                Console.WriteLine("fizzbuzz");
            else if (chislo % 3 == 0)
                Console.WriteLine("Fizz");
            else if (chislo % 5 == 0)
                Console.WriteLine("buzz");
            else
                Console.WriteLine(chislo);
        }
        else
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 100.");
        }
    }

    void Zadacha2()
    {
        Console.WriteLine("Введите число:");
        double chislo = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите процент:");
        double procent = double.Parse(Console.ReadLine());

        double rezultat = chislo * procent / 100;
        Console.WriteLine($"{procent}% от {chislo} = {rezultat}");
    }

    void Zadacha3()
    {
        Console.WriteLine("Введите первую цифру:");
        string c1 = Console.ReadLine();

        Console.WriteLine("Введите вторую цифру:");
        string c2 = Console.ReadLine();

        Console.WriteLine("Введите третью цифру:");
        string c3 = Console.ReadLine();

        Console.WriteLine("Введите четвертую цифру:");
        string c4 = Console.ReadLine();

        string itog = c1 + c2 + c3 + c4;
        int chislo = int.Parse(itog);
        Console.WriteLine($"Ваше число: {chislo}");
    }

    void Zadacha4()
    {
        Console.WriteLine("Введите шестизначное число:");
        string vvod = Console.ReadLine();

        if (vvod.Length != 6)
        {
            Console.WriteLine("Ошибка: число должно состоять из 6 цифр.");
            return;
        }

        Console.WriteLine("Введите первую позицию для обмена (1–6):");
        int p1 = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Введите вторую позицию для обмена (1–6):");
        int p2 = int.Parse(Console.ReadLine()) - 1;

        if (p1 >= 0 && p1 < 6 && p2 >= 0 && p2 < 6)
        {
            char[] arr = vvod.ToCharArray();

            char temp = arr[p1];
            arr[p1] = arr[p2];
            arr[p2] = temp;

            Console.WriteLine($"Результат: {new string(arr)}");
        }
        else
        {
            Console.WriteLine("Ошибка: позиции должны быть от 1 до 6.");
        }
    }

    void Zadacha5()
    {
        Console.WriteLine("Введите дату в формате дд.мм.гггг:");
        string strokaData = Console.ReadLine();

        DateTime data = DateTime.ParseExact(strokaData, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        string sezon = "";
        int mesyac = data.Month;

        if (mesyac == 12 || mesyac == 1 || mesyac == 2)
            sezon = "зима";
        else if (mesyac >= 3 && mesyac <= 5)
            sezon = "весна";
        else if (mesyac >= 6 && mesyac <= 8)
            sezon = "лето";
        else
            sezon = "осень";

        string denNedeli = data.ToString("dddd", new CultureInfo("ru-RU"));

        Console.WriteLine($"Сегодня {sezon}, {denNedeli}");
    }

    void Zadacha6()
    {
        Console.WriteLine("Что нужно конвертировать?");
        Console.WriteLine("1. Цельсий в Фаренгейт");
        Console.WriteLine("2. Фаренгейт в Цельсий");

        int vibor = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите температуру:");
        double t = double.Parse(Console.ReadLine());
        double rez;

        if (vibor == 1)
        {
            rez = (t * 1.8) + 32;
            Console.WriteLine($"{t}°C = {rez:F2}°F");
        }
        else if (vibor == 2)
        {
            rez = (t - 32) / 1.8;
            Console.WriteLine($"{t}°F = {rez:F2}°C");
        }
        else
        {
            Console.WriteLine("Ошибка: неправильный выбор.");
        }
    }

    void Zadacha7()
    {
        Console.WriteLine("Введите начало диапазона:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите конец диапазона:");
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
            Console.WriteLine($"Диапазон исправлен: от {start} до {end}");
        }

        Console.WriteLine($"Четные числа от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        var app = new Programma();
        app.Zadacha1();
        app.Zadacha2();
        app.Zadacha3();
        app.Zadacha4();
        app.Zadacha5();
        app.Zadacha6();
        app.Zadacha7();
    }
}
