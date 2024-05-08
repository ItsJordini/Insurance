namespace KomodoInsurance;

// Manages Devs and dev teams
public class DeveloperRepo
{
    // List to store the devs
    private List<Developer> developers;

    // Constructor
    public DeveloperRepo()
    {
        developers = new List<Developer>();
    }

    // Method to add a developer
    public void AddDeveloper(Developer developer)
    {
        developers.Add(developer);
    }

    // Method to remove a developer
    public void RemoveDeveloper(Developer developer)
    {
        developers.Remove(developer);
    }

    // Method to retrieve all developers
    public List<Developer> GetAllDevelopers()
    {
        return developers;
    }
}

