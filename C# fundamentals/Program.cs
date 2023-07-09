using BethanysPieShopHRM;

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979, 1, 16), 25, EmployeeType.Manager);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();


WorkTask task;
task.description = "Bake a delicious pies";
task.hours = 3;
task.PerformWorkTask();
