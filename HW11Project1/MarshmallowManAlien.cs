using System;
using System.Collections.Generic;
using System.Text;

namespace HW11Project1
{
    class MarshmallowManAlien : Alien
    {
        public MarshmallowManAlien(int health, string name) : base(health, name)
        {
            setDamage(1);
        }
    }
}
