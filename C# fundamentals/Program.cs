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