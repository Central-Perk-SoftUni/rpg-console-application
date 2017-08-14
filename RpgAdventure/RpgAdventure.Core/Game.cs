namespace RpgAdventure.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Core.Ninject.FactoryInstanceProviders;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Models.Interfaces.Factories;
    using RpgAdventure.Models.PlayableClasses.Classes.MageSpecialisations;
    using RpgAdventure.Models.PlayableClasses.Classes.Specialisations;
    using RpgAdventure.Models.Races;
    using RpgAdventure.Models.Skills;
    using RpgAdventure.Services.Interfaces.IO;
    using RpgAdventure.Services.IO;

    public class Game : IGame
    {
        private IPlayer player;
        private IEnemy enemy;
        private IReader consoleReader;
        private IWriter consoleWriter;
        private IConsoleManipulator consoleManipulator;
        private IPlayableClassFactory playableClassFactory;
        private static readonly ICollection<IPlayableClass> elfClasses = new List<IPlayableClass>()
        {
            new ArcaneMage(), new FireMage(), new FrostMage()
        };
        private static readonly ICollection<IPlayableClass> humanClasses = new List<IPlayableClass>()
        {
            new MarksmanshipHunter(), new ProtectionWarrior(), new FuryWarrior()
        };
        private static readonly ICollection<IPlayableClass> orcClasses = new List<IPlayableClass>()
        {
            new SurvivalHunter(), new BeastMasterHunter(), new ArmsWarrior()
        };
        private static readonly ICollection<ICastable> elfSkills = new List<ICastable>()
        {
            new OffensiveSkill("offence1", 20, 20),
            new DefensiveSkill("def1", 20, 20)
        };
        private static readonly ICollection<ICastable> humanSkills = new List<ICastable>()
        {
            new OffensiveSkill("offence1", 20, 20),
            new DefensiveSkill("def1", 20, 20)
        };
        private static readonly ICollection<ICastable> orcSkills = new List<ICastable>()
        {
            new OffensiveSkill("offence1", 20, 20),
            new DefensiveSkill("def1", 20, 20)
        };

        public Game(IWriter writer, IReader reader, IConsoleManipulator manipulator)
        { 
            this.consoleManipulator = manipulator;
            this.consoleWriter = writer;
            this.consoleReader = reader;
        }

        public IPlayer Player => this.player;

        public IEnemy Enemy => this.enemy;

        public void CreatePlayer()
        {
            IRace race = null;
            IPlayableClass playableClass = null;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Choose a race: ");
            sb.AppendLine("1. Elf");
            sb.AppendLine("2. Human");
            sb.AppendLine("3. Orc");
            ChooseRace(sb, race);
            

        }

        private void ChooseRace(StringBuilder sb, IRace race)
        {
            int choice = int.Parse(this.consoleReader.Read());
            switch (choice)
            {
                case 1:
                    List<IPlayableClass> availableClasses = new List<IPlayableClass>(){};
                    race = new Elf(elfSkills, elfClasses);
                    break;
                case 2:
                    race = new Human(humanSkills, humanClasses);
                    break;
                case 3:
                    race = new Orc(orcSkills, orcClasses);
                    break;
                default:
                    this.consoleWriter.WriteLine("Invalid choice! Please choose again.");
                    ChooseRace(sb, race);
                    break;
            }
        }

        public void SpawnEnemy()
        {
            
        }

        public void Battle(IPlayer player, IEnemy enemy)
        {
            
        }
    }
}
