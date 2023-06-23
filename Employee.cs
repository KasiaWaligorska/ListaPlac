namespace ListaPłac;

public class Employee
{
    private String firstName;
    private String lastName;
    private int salary;
    
    private Company company;

    public Employee(Company company)
    {
        this.company = company;
    } 
    
    public Employee()
    {
        
    }    
    public Employee(String firstName, String lastName, int salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }

    public String FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    
    public String LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    public int Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    
    public String GetAllData()
    {
        String allData = "Salary for " + this.firstName + " " + this.lastName + " is " + this.salary + ".";
        return allData;
    }

    public String ToString()
    {
        return "Salary for " + 
               this.firstName + 
               " " + 
               this.lastName + 
               " is " + 
               this.salary + 
               ".";
    }

    public Employee CreateNewEmployee()
    {
        String description = "Creating new employee." + 
                             "\n" + 
                             "-----------------------------------------------------------------------";
        String firstNameCommand = "Enter the employee's first name:";
        String lastNameCommand = "Enter the employee's last name:";
        String salaryCommand = "Enter the employee's salary:";
        
        Console.WriteLine(description);
        Console.WriteLine(firstNameCommand);
        this.firstName = Console.ReadLine();
        if (string.IsNullOrEmpty(firstName))
        {
            throw new ArgumentNullException();
        }
        Console.WriteLine(lastNameCommand);
        this.lastName= Console.ReadLine();
        if (string.IsNullOrEmpty(lastName))
        {
            throw new ArgumentNullException();
        }
        Console.WriteLine(salaryCommand);
        this.salary = int.Parse(Console.ReadLine());
        if (salary <= 0)
        {
            throw new ArgumentException();
        }
        Employee employee = new Employee(firstName, lastName, salary);
        return employee;
    }
    public void AddNewEmployeeToTheCompanyList()
    {
        String description = "Adding new employee to the company: " + 
                             this.company.GetCompanyName() + 
                             "\n" + 
                             "-----------------------------------------------------------------------";
        String successMessage = "Employee added successfully!";
        
        Console.WriteLine(description);
        Employee employee = CreateNewEmployee();
        company.AddEmployeeToEmployeesList(employee);
        Console.WriteLine(successMessage);
    }   
}