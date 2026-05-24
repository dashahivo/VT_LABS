// Worker.cs
namespace OOP_COLLECTIONS
{
    // =======================
    // Производный класс рабочего
    // =======================

    public class Worker : Employee // Поведение наследуется от сотрудника
    {
        // =======================
        // Для каждого рабочего характерно наличие числа смен в месяц
        // =======================
        public int MonthlyShifts { get; set; }

        // =========================
        // В момент создания рабочего в поля Id, Name, BaseSalary
        // Записываются значения через конструктор базового класса
        // (Внутри конструктора не нужно ничего писать)
        // А вот число смен нужно установить (логика характерная только для рабочего)
        // =========================
        public Worker(string name, double baseSalary, int monthlyShifts)
            : base(name, baseSalary)
        {
            MonthlyShifts = monthlyShifts;
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is doing shift-based work.");
        }

        public override double CalculateSalary()
        {
            // TODO: Расчитать зарплату рабочего
            // =========================
            // Логика расчета
            // У каждого рабочего есть минимальное число смен в месяц = 20
            // За каждый день отработанный сверх минимума он получает бонус = 50
            // Общая ЗП = Стратовая ЗП + бонус
            // =========================
            int minimunShifts = 20;
            double bonusPerExtraShift = 50;

            double bonus = 0;

            // Если число смен MonthlyShifts > minimumShifts
            // Начисляем бонус
            if (MonthlyShifts > minimunShifts)
            {
                bonus = (MonthlyShifts - minimunShifts) * bonusPerExtraShift;
            }
            return BaseSalary + bonus;
        }

        // =========================
        // Система может выводить информацию для каждого рабочего
        // =========================
        public override void DisplayInfo()
        {
            // Базовая информация о сотруднике
            base.DisplayInfo();

            Console.WriteLine($"Monthly Shifts: {MonthlyShifts}");
        }
    }
}