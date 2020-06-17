using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg",Line="Boil water",Platform="Pan"},
                new Command{Id=1, HowTo="Boil an egg2",Line="Boil water2",Platform="Pan2"},
                new Command{Id=2, HowTo="Boil an egg3",Line="Boil water3",Platform="Pan3"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg",Line="Boil water",Platform="Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }
    }
}