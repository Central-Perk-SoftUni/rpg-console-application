﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.Races
{
    public abstract class Race : IRace
    {
        private const string InvalidPlayableClassTypeException = "Invalid playable class type!";

        private ICollection<Type> playableClasses;

        public Race(ICollection<ICastable> skills, ICollection<Type> playableClasses)
        {
            this.Skills = skills;
            this.PlayableClasses = playableClasses;
        }


        public ICollection<ICastable> Skills { get; set; }

        public ICollection<Type> PlayableClasses
        {
            get { return this.playableClasses; }
            set
            {
                var validValues = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsAssignableFrom(typeof(PlayableClass)));
                if (validValues.Intersect(value).Count() != value.Count)
                {
                    throw new ArgumentException(InvalidPlayableClassTypeException);
                }
                this.PlayableClasses = value;
            }
        }
    }
}
