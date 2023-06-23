using System.Collections;

namespace ListaPłac;

public class Company
{
    // public List<Employee> EmployeesList;
    public ArrayList EmployeesList;
    private String companyName;
    public List<Company> CompanyList;

    public Company(String companyName)
    {
        this.companyName = companyName;
        this.EmployeesList = new ArrayList();
        // this.EmployeesList = new List<Employee>();
    }

    public String GetCompanyName()
    {
        return this.companyName;
    }

    public void DisplayAllEmployees()
    {
        foreach(Employee employee in EmployeesList)
        {
            Console.WriteLine(employee);
        }
    }
    
    public string ToString()
    {
        //hello
        string result = "Employees in " + companyName + ":\n";
        foreach (Employee employee in EmployeesList)
        {
            result += "Employee " + 
                      employee.FirstName + 
                      " " + 
                      employee.LastName + 
                      " with salary " + 
                      employee.Salary + 
                      "\n";
        }
        return result;
    }

    public void AddEmployeeToEmployeesList(Employee employee)
    {
        this.EmployeesList.Add(employee);
    }

    public int CountSumOfSalariesOfAllEmployees()
    {
        int sumOfSalary = 0;
        foreach (Employee employee in EmployeesList)
        {
            sumOfSalary += employee.Salary;
        }
        return sumOfSalary;
    }

    public void DisplaySumOfSalariesOfAllEmployees()
    {
        int sumOfSalary = CountSumOfSalariesOfAllEmployees();
        Console.WriteLine("\n" + "All employees in the company " + this.companyName + " earn a total of " + sumOfSalary + " dolars per month." +"\n");
    }
}