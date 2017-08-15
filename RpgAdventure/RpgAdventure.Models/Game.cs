using System.Runtime.InteropServices.WindowsRuntime;
using RpgAdventure.Models.Exceptions;

namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Models.Interfaces.Factories;
    using RpgAdventure.Models.PlayableClasses.Classes.Specialisations;
    using RpgAdventure.Models.Skills;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Game : IGame
    {
        private const int StartingScore = 0;

        private int score;

        public Game(IPlayer player) : this(player, StartingScore)
        {           
        }

        public Game(IPlayer player, int score)
        {
            this.Player = player;
            this.Score = score;
        }


        public IPlayer Player { get; set; }

        public int Score
        {
            get { return this.score; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Score");
                }
                this.score = value;
            }
        }
    }
}