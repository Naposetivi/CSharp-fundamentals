using C__fundamentals.HR;

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979, 1, 16), 25, EmployeeType.Manager);

#region Bethany calling some methods
bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
#endregion


WorkTask task;
task.description = "Bake a delicious pies";
task.hours = 3;
task.PerformWorkTask();


Employee.taxRate = 0.2;
Employee.DisplayTaxRate();


// Робота зі списками
//int[] sampleArray1 = new int[5];
//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

//Console.WriteLine("How many employees IDs do you want to register?");
//int length = int.Parse(Console.ReadLine());
//int[] employeesIds = new int[length];

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeesIds[i] = id;
//}

//for (int i = 0; i < employeesIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeesIds[i]}");
//}

//Employee bethanys = new Employee("Bethanys", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
//Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

//Employee[] employees = new Employee[7];
//employees[0] = george;
//employees[1] = mary;
//employees[2] = bobJunior;
//employees[3] = kevin;
//employees[4] = kate;
//employees[5] = kim;
//employees[6] = bethanys;

//foreach (Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}


// Робота із динамічними списками


//List<int> employeeIds = new List<int>();
//employeeIds.Add(1);
//employeeIds.Add(2);
//employeeIds.Add(3);
//employeeIds.Add(4);
//employeeIds.Add(5);

//if (employeeIds.Contains(1))
//{
//    Console.WriteLine("1 is found!");
//}

//int currendAmountOfEmployees =  employeeIds.Count();

//var employeesIdsArray  = employeeIds.ToArray();

//employeeIds.Clear();

//Console.WriteLine("How many employees IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.Write("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds.Add(id);
//}

Employee bethanys = new Employee("Bethanys", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
Employee mary = new Employee("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17, EmployeeType.Research);
Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10, EmployeeType.StoreManager);
Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10, EmployeeType.StoreManager);
Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1975, 5, 14), 22, EmployeeType.StoreManager);

List<Employee> employees = new List<Employee>();
employees.Add(george);
employees.Insert(0, mary);
employees.Add(bethanys);
employees.Add(kate);
employees.Add(kim);
employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(george);

foreach (Employee e in employees)
{
    e.DisplayEmployeeDetails();
}