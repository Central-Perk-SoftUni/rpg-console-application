namespace RpgAdventure.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Models.Interfaces.Factories;
    using RpgAdventure.Models.PlayableClasses.Classes.MageSpecialisations;
    using RpgAdventure.Models.PlayableClasses.Classes.Specialisations;
    using RpgAdventure.Models.Races;
    using RpgAdventure.Models.Skills;

    public class Game : IGame
    {
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

        public Game()
        {
        }

        public void CreatePlayer(IPlayer player)
        {
            IRace race = null;
            IPlayableClass playableClass = null;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Choose a race: ");
            sb.AppendLine("1. Elf");
            sb.AppendLine("2. Human");
            sb.AppendLine("3. Orc");
            //this.consoleWriter.WriteLine(sb.ToString());
            race = this.ChooseRace(sb, race);
            sb.Clear();
            //this.consoleManipulator.ClearScreen();

            sb.AppendLine("Choose a class: ");
            int i = 1;
            sb.Append("1. ");
            sb.AppendLine(string.Join($"{Environment.NewLine}{++i}. ", race.PlayableClasses));
            //this.consoleWriter.WriteLine(sb.ToString());
            playableClass = this.ChooseClass(playableClass, race);

        }

        private IPlayableClass ChooseClass(IPlayableClass playableClass, IRace race)
        {
            //int choice = int.Parse(this.consoleReader.Read());
            //playableClass = race.PlayableClasses[choice];

            return playableClass;
        }

        private IRace ChooseRace(StringBuilder sb, IRace race)
        {
            //int choice = int.Parse(this.consoleReader.Read());
            switch (choice)
            {
                case 1:
                    List<IPlayableClass> availableClasses = new List<IPlayableClass>() { };
                    race = new Elf(elfSkills, elfClasses);
                    break;
                case 2:
                    race = new Human(humanSkills, humanClasses);
                    break;
                case 3:
                    race = new Orc(orcSkills, orcClasses);
                    break;
                default:
                    //this.consoleWriter.WriteLine("Invalid choice! Please choose again.");
                    this.ChooseRace(sb, race);
                    break;
            }

            return race;
        }

        public void SpawnEnemy(IEnemy enemy)
        {
            throw new NotImplementedException();
        }

        public void Battle(IPlayer player, IEnemy enemy)
        {
            throw new NotImplementedException();
        }

        public void EndGame()
        {
            throw new NotImplementedException();
        }
        
    }
}
