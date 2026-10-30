namespace Employees_Tracker
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public int Grade {  get; set; }
        public string Department {  get; set; }
        public Employee(int id,string name,string dep,int age,int grade,double salary)
        {
            Id = id;
            Name = name;
            Department = dep;
            Age = age;
            Grade = grade;
            Salary = salary;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(1,"Emp1","dep1",44,80,9200),
                new Employee(2,"Emp2","dep1",35,86,7500),
                new Employee(3,"Emp3","dep3",31,85,30000),
                new Employee(4,"Emp4","dep3",40,75,20000),     
                new Employee(5,"Emp5","dep5",50,70,15000),
                new Employee(6,"Emp6","dep5",46,73,7000),
            };
            var Raises = employees.Select(e => new
            {
                e.Name,
                newSalary = e.Salary * 1.1
            });
            Console.WriteLine("Employees and their salaries after raises: ");
            Console.WriteLine();
            foreach(var item in Raises)
            {
                Console.WriteLine(item.Name + " " + item.newSalary);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            var OrderedByAge = employees.OrderBy(e => e.Age);
            Console.WriteLine("Employees ordered by age: ");
            Console.WriteLine();
            foreach(var item in OrderedByAge)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            var OrderedBySalary = employees.OrderByDescending(e => e.Salary);
            Console.WriteLine("Employees Ordered by salary: ");
            Console.WriteLine();
            foreach(var item in OrderedBySalary)
            {
                Console.WriteLine(item.Name + " " + item.Salary);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            var GroupByDep = employees.GroupBy(e => e.Department);
            Console.WriteLine("Employees grouped by department: ");
            Console.WriteLine();
            foreach(var group in GroupByDep)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine(group.Count());
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Employees grouped by grade: ");
            Console.WriteLine();
            var GroupByGrade = employees.GroupBy(e => e.Grade >= 80);
            foreach(var group in GroupByGrade)
            {
                Console.WriteLine(group.Key);
                foreach(var item in  group)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("-----------------------");
            }
        }
    }
}
