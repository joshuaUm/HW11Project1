using System;
using System.Collections.Generic;
using System.Text;

namespace HW11Project1
{
    class Alien
    {
        public const int SNAKE_ALIEN = 0;
        public const int OGRE_ALIEN = 1;
        public const int MARSHALLOW_MAN_ALIEN = 2;


        private int health; //0 = dead, 100 = full
        private string name;
        private int damage;
        

        public Alien( int health, string name)
        {
            
            this.health = health;
            this.name = name;
        }

        public int getHealth()
        {
            return health;
        }

        public string getName()
        {
            return name;
        }

        public int getDamage()
        {
            return damage;
        }



        public void setHealth(int health)
        {
            this.health = health;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setDamage(int damage)
        {
            this.damage = damage;
        }


        public override string ToString()
        {
            return  "\nName : " + name + "\n" +
                    "Health : " + health + "\n" + 
                    "Damage : " + damage + "\n";
        }

    }
}
