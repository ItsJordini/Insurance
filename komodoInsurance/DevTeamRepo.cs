namespace KomodoInsurance;

//Manages DevTeam
public class DevTeamRepo
{
    // List to store the dev teams
    private List<DevTeam> _devTeams;

    // Method to add a dev team
    public void AddDevTeam(DevTeam team)
    {
        _devTeams.Add(team);
    }

    // Method to remove a dev team
    public void RemoveDevTeam(DevTeam team)
    {
        _devTeams.Remove(team);
    }

    // Method to retrieve all dev teams
    public List<DevTeam> GetAllDevTeams()
    {
        return _devTeams;
    }
}


