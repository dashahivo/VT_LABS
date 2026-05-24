namespace LAB03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1.1 (Код проверки пишем ниже)
            Console.WriteLine("=== 1.1 Конструктор с двумя аргументами ===");
            LAB03.Rational rational1 = new LAB03.Rational(3, 8);
            Console.WriteLine($"new Rational(3, 8) = {rational1}");

            LAB03.Rational rational1b = new LAB03.Rational(6, 16);
            Console.WriteLine($"new Rational(6, 16) = {rational1b}\n");
            // Задание 1.2 (Код проверки пишем ниже)
            Console.WriteLine("=== 1.2 Конструктор с одним аргументом ===");
            LAB03.Rational rational2 = new LAB03.Rational(4);
            Console.WriteLine($"new Rational(4) = {rational2}\n");
            // Задание 1.3 (Код проверки пишем ниже)
            Console.WriteLine("=== 1.3 Конструктор без аргументов ===");
            LAB03.Rational rational3 = new LAB03.Rational();
            Console.WriteLine($"new Rational() = {rational3}\n");

            // Задание 1.4 (Код проверки пишем ниже)
            Console.WriteLine("=== 1.4 Знаменатель = 0 ===");
            try
            {
                LAB03.Rational rational4 = new LAB03.Rational(-3, 0);
                Console.WriteLine("ОШИБКА: Исключение не выброшено!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"УСПЕХ: {ex.Message}\n");
            }

            // Задание 2.1 (Код проверки пишем ниже)
            Console.WriteLine("=== 2.1 Сокращение дроби ===");
            LAB03.Rational rational5 = new LAB03.Rational(4, 8);
            Console.WriteLine($"new Rational(4, 8) = {rational5}");

            LAB03.Rational rational6 = new LAB03.Rational(8, 12);
            Console.WriteLine($"new Rational(8, 12) = {rational6}\n");

            // Задание 2.2 (Код проверки пишем ниже)
            Console.WriteLine("=== 2.2 Нормализация знака ===");
            LAB03.Rational rational7 = new LAB03.Rational(4, -9);
            Console.WriteLine($"new Rational(4, -9) = {rational7}");

            LAB03.Rational rational8 = new LAB03.Rational(-2, -10);
            Console.WriteLine($"new Rational(-2, -10) = {rational8}");

            LAB03.Rational rational9 = new LAB03.Rational(-7, 3);
            Console.WriteLine($"new Rational(-7, 3) = {rational9}");

            LAB03.Rational rational10 = new LAB03.Rational(5, -20);
            Console.WriteLine($"new Rational(5, -20) = {rational10}\n");
            // ========== ЗАДАНИЕ 3 ==========
            Console.WriteLine("========== ЗАДАНИЕ 3 ==========\n");

            LAB03.Rational fractionA = new LAB03.Rational(1, 2);
            LAB03.Rational fractionB = new LAB03.Rational(1, 3);

            // Задание 3.1 (Код проверки пишем ниже)
            Console.WriteLine("\n=== Задание 3.1 Арифметические операции ===");

            LAB03.Rational a = new LAB03.Rational(1, 2);
            LAB03.Rational b = new LAB03.Rational(1, 3);

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");

            // Задание 3.2 (Код проверки пишем ниже)
            Console.WriteLine("\n=== Задание 3.2 Сравнение дробей ===");

            LAB03.Rational c = new LAB03.Rational(1, 2);
            LAB03.Rational d = new LAB03.Rational(2, 4);

            Console.WriteLine($"{c} == {d} ? {c == d}");
            Console.WriteLine($"{c} != {d} ? {c != d}");
        }
    }
}