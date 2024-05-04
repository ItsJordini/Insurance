using System;
using System.Collections.Generic;

namespace KomodoInsurance.ConsoleApp
{
    // Manages Devs and dev teams
    public class DevManagementRepo
    {
        // List to store the devs
        private List<Developer> developers;

        // List to store the dev teams
        private List<Developer.DevTeam> devTeams;

        // Constructor
        public DevManagementRepo()
        {
            developers = new List<Developer>();
            devTeams = new List<Developer.DevTeam>();
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

        // Method to add a dev team
        public void AddDevTeam(Developer.DevTeam team)
        {
            devTeams.Add(team);
        }

        // Method to remove a dev team
        public void RemoveDevTeam(Developer.DevTeam team)
        {
            devTeams.Remove(team);
        }

        // Method to retrieve all dev teams
        public List<Developer.DevTeam> GetAllDevTeams()
        {
            return devTeams;
        }
    }
}