namespace LINQPart2
{
    internal class Program
    {    // Задание 15.4.1

        static void Main(string[] args)
        {
            var departments = new List<Department>()

            {
                  new Department() {Id = 1, NameDepartment = "Программирование"},
                  new Department() {Id = 2, NameDepartment = "Продажи"}
            };

            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},

               
            };
            var result = departments.Join(employees,
                dep => dep.Id,
                emp => emp.Id,
                (dep, emp) =>
                new
                {
                    NameDepartment1 = dep.NameDepartment,
                    Name1 = emp.Name
                });
            foreach (var wo in result)
                Console.WriteLine($"{wo.Name1} - {wo.NameDepartment1}");
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string NameDepartment { get; set; }
    }
    public class Employee
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }

    
}