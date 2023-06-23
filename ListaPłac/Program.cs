using ListaPłac;

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company("BigCompany");
        Menu menu = new Menu(company);
         Employee employee;
        
         int numberOfEmployees = 2;
         for (int i = 1; i <= numberOfEmployees; i++)
         {
             employee = new Employee();
        
             try
             {
                 employee.CreateNewEmployee();
             }
             catch (ArgumentNullException e)
             {
                 Console.WriteLine("Null is not allowed.");
             }
             catch (ArgumentException e)
             {
                 Console.WriteLine("Value must be bigger than 0");
             }
        
             company.AddEmployeeToEmployeesList(employee);
         }
        
        menu.PerformAnActionFromTheMenu();
    }
}