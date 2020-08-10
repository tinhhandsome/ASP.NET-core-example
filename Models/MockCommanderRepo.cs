using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo= "how to 0", Line="Line 0", Platform="Platform 0"},
                new Command{Id=1, HowTo= "how to 1", Line="Line 1", Platform="Platform 1"},
                new Command{Id=2, HowTo= "how to 2", Line="Line 2", Platform="Platform 2"},
                new Command{Id=3, HowTo= "how to 3", Line="Line 3", Platform="Platform 3"},
                new Command{Id=4, HowTo= "how to 4", Line="Line 4", Platform="Platform 4"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil and Egg", Line="Boil water", Platform="Kettle & Pan"}; 
        }
    }
}