namespace ListaPłac;

public class Menu
{
    private static String option1 = "Print sum of all employees salary";
    private static String option2 = "Display all employees data";
    private static String option3 = "Add new employee";
    private static String option4 = "End program";

    private String[] MenuOptions = new String[4]{option1, option2, option3, option4 };

    private Company company;
    private Employee employee;

    public Menu()
    {
        
    }
    public Menu(Company company)
    {
        this.company = company;
        employee = new Employee(company);
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Enter a number to select an option:");
        for (int i = 0; i < MenuOptions.Length; i++)
        {
            Console.WriteLine(i+1 + " - " + MenuOptions[i]);
        }
    }

    public void PerformAnActionFromTheMenu()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        company.DisplaySumOfSalariesOfAllEmployees();
                        break;
                    case 2:
                        Console.WriteLine(company.ToString());
                        break;
                    case 3:
                        employee.AddNewEmployeeToTheCompanyList();
                        break;
                    case 4:
                        exit = true;
                        Console.WriteLine("The program is closed.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid number from the menu.");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}