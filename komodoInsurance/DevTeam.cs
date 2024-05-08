namespace KomodoInsurance;

public class DevTeam
{
    //ID for the team
    public int TeamId { get; set; }

    //Team Name
    public string TeamName { get; set; }

    //List of DevIDs repping the team members
    public List<int> TeamMembers { get; set; } //Store devIDS
}
