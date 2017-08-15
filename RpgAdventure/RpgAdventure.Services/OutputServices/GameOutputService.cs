using System;
using System.Collections.Generic;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.Interfaces.OutputServices;
using RpgAdventure.Utilities;

namespace RpgAdventure.Services.OutputServices
{
    public class GameOutputService : IGameOutputService
    {
        private  readonly IConsoleManipulator consoleManipulator;
        private  readonly IWriter writer;

        public GameOutputService(IConsoleManipulator consoleManipulator, IWriter writer)
        {
            this.consoleManipulator = consoleManipulator;
            this.writer = writer;
        }

        public void RaceSelectOutput(ICollection<Type> races)
        {
            this.RaceSelectOutput(races,new PrintCoordinates(Constants.OutputRow,Constants.OutputCol));
        }

        public void RaceSelectOutput(ICollection<Type> races,PrintCoordinates coordinates)
        {
            this.consoleManipulator.SetCursorAt(coordinates.OutputRow, coordinates.OutputCol);
            this.writer.WriteLine("Select a race:");
            int counter = 1;
            foreach (Type race in races)
            {
                this.consoleManipulator.SetCursorAt(coordinates.OutputRow + counter, coordinates.OutputCol);
                this.writer.WriteLine(race.Name);
                counter++;
            }
            Console.ReadKey();

        }
    }
}
