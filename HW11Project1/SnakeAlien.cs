using System;
using System.Collections.Generic;
using System.Text;

namespace HW11Project1
{
    class SnakeAlien : Alien
    {
        public SnakeAlien(int health, string name) : base(health,name)
        {
            setDamage(10);
        }
    }
}
