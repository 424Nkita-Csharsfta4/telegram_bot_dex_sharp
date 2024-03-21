namespace Domain.Entyti.ValueObject;

public class FullName
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? MiddleName { get; set; } = null;

    public FullName(string firstname, string lastName, string middleName)
    {
        FirstName = firstname;
        LastName = lastName;
        MiddleName = middleName;
    }
}