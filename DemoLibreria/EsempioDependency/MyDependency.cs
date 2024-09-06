namespace DemoLibreria.EsempioDependency;

public enum Gender
{ 
  Unknown,
  Male,
  Female
}

public enum Position
{
    Administrator,
    Manager,
    Executive
}

public class Employee
{
    public string? Name { get; set; }
    public Gender Gender { get; set; }
    public Position Position { get; set; }
}

//public class EmployeeManager { 
//    private readonly List<Employee> _employees = new();

//    public void AddEmployee(Employee employee)
//    {
//        _employees.Add(employee);
//        // Add employee to the database
//    }

//    public List<Employee> employees => _employees;
//}


public class EmployeeManager: IEmployeeSearchable
{
    private readonly List<Employee> _employees = new();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
        // Add employee to the database
    }

    public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
    {
        return _employees.Where(e => e.Gender == Gender.Female && e.Position == Position.Manager);
    }

    //public List<Employee> employees => _employees;
}

public class  EmployeeStatistics
{
    private readonly EmployeeManager _employeeManager;

    public EmployeeStatistics(EmployeeManager employeeManager)
    {
        _employeeManager = employeeManager;
    }

    public int CountFemaleManagers()
    {
       return  _employeeManager.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}

public interface IEmployeeSearchable
{
    IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
}





