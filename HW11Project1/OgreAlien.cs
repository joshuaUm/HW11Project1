using System;
using System.Collections.Generic;
using System.Text;

namespace HW11Project1
{
    class OgreAlien : Alien
    {

        public OgreAlien(int health, string name) : base(health, name)
        {
            setDamage(6);
        }


    }
}
