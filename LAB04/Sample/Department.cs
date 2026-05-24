namespace OOP_COLLECTIONS
{
    // =======================
    // Класс отдела
    // =======================

    public class Department
    {
        // =========================
        // У каждого отдела в системе есть
        // - Имя
        // - Список сотрудников
        // =========================
        public string Name { get; set; }
        public List<Employee> Employees { get; private set; }

        // =========================
        // В момент создания отдела ему:
        // 1) Задается Имя
        // 2) Создается Пустой Список, в который будут добавлены сотрудники
        // =========================
        public Department(string name)
        {
            Name = name;

            Employees = new List<Employee>();
        }

        // =========================
        // Для каждого отдела характерна логика добавления сотрудника
        // НЕЛЬЗЯ ДОБАВИТЬ В ОТДЕЛ БОЛЕЕ 1 УПРАВЛЯЮЩЕГО (Manager)
        // =========================
        public void AddEmployee(Employee employee)
        {
            // Проверка: нельзя добавить второго менеджера
            if (employee is Manager)
            {
                foreach (Employee emp in Employees)
                {
                    if (emp is Manager)
                    {
                        Console.WriteLine("Ошибка: В отделе уже есть менеджер! Нельзя добавить второго.");
                        return;
                    }
                }
            }

            // Проверка: нельзя добавить одного и того же сотрудника дважды
            if (Employees.Contains(employee))
            {
                Console.WriteLine($"Ошибка: Сотрудник {employee.Name} уже есть в отделе!");
                return;
            }

            Employees.Add(employee);
            Console.WriteLine($"Сотрудник {employee.Name} добавлен в отдел {Name}");
        }
        

        // =========================
        // Для каждого отдела характерна логика поиска сотрудника по Id
        // =========================
        public Employee FindEmployeeById(int id)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        // =========================
        // Для каждого отдела характерна логика удаления сотрудника по Id
        // =========================
        public bool RemoveEmployeeById(int id)
        {
            Employee emp = FindEmployeeById(id);

            if (emp != null)
            {
                Employees.Remove(emp);
                Console.WriteLine($"Сотрудник {emp.Name} (ID: {id}) удалён из отдела");
                return true;
            }

            Console.WriteLine($"Сотрудник с ID {id} не найден");
            return false;
        }

        // =========================
        // Для каждого отдела характерна логика обзора всех сотрудников
        // =========================
        public void ShowAllEmployees()
        {
            Console.WriteLine($"\nDepartment: {Name}");

            Console.WriteLine("======================");

            if (Employees.Count == 0)
            {
                Console.WriteLine("В отделе нет сотрудников");
                return;
            }

            foreach (Employee emp in Employees)
            {
                emp.DisplayInfo();
                emp.Work();
                Console.WriteLine($"Total Salary: {emp.CalculateSalary()}");
                Console.WriteLine("----------------------");
            }
        }

        // =========================
        // Для каждого отдела характерна логика вывода сводной информации
        // =========================
        public void GetDepartmentInfo()
        {
            int totalEmployees = Employees.Count;

            double totalSalary = 0;
            int workers = 0, programmers = 0, managers = 0;

            foreach (Employee emp in Employees)
            {
                totalSalary += emp.CalculateSalary();

                if (emp is Worker)
                {
                    workers++;
                }
                else if (emp is Programmer)
                {
                    programmers++;
                }
                else if (emp is Manager)
                {
                    managers++;
                }
            }

            double avgSalary = totalEmployees > 0 ? totalSalary / totalEmployees : 0;

            Console.WriteLine($"\n=== Department Info: {Name} ===");
            Console.WriteLine($"Total Employees: {totalEmployees}");
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Average Salary: {avgSalary:F2}");

            Console.WriteLine("\nBy Type:");
            Console.WriteLine($"Workers: {workers}");
            Console.WriteLine($"Programmers: {programmers}");
            Console.WriteLine($"Managers: {managers}");
        }
    }
}