using System;

namespace Enemies
{
    /// <summary> Create an empty public class </summary>
    class Zombie
    {
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
    }
}
