﻿using System;

namespace Enemies
{
    /// <summary> Create an empty public class </summary>
    class Zombie
    {
        int health;
        string name = "(No name)";

        /// <summary>Set a Zombie name</summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary> Defines health </summary>
        public int health;

        /// <summary>Initialize a <see cref="Zombie"/> class</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a <see cref="Zombie"/> 
        /// with <paramref name="value"/></summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        /// <summary>Returns the health Zombie</summary>
        public int GetHealth()
        {
            return health;
        }

         public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}