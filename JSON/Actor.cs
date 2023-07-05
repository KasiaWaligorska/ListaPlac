namespace JSON;

public class Actor
{
    private string firstName { get; set; }
    private string lastName { get; set; }

    public Actor(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}