using lab9;

var employee1 = new Employee("Manager", 80000);
var employee2 = new Employee("Developer", 60000);
var employee3 = new Employee("Analyst", 50000);

var department1 = new Department("IT Dep", new List<Employee> { employee1, employee2 });
var department2 = new Department("Business Dep", new List<Employee> { employee3 });

var company = new Company("TLogic", new List<Department> { department1, department2 });

var salaryReportVisitor = new SalaryReportVisitor();

company.Accept(salaryReportVisitor);
department1.Accept(salaryReportVisitor);