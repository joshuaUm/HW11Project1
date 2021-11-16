/// Homework No. 11 Project No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : November 15 2021
/// 
/// Problem Statement : Create a class called Vehicle, which has an association with Person class. Then create a Truck class derrived from Vehicle class.
/// 
/// Plan:
/// 1. Create Alien and derrived Alien class objects.
/// 2. Test toString() for each object.
/// 3. Create Alienpack object to contain aliens.
/// 4. Store each alien inside Alienpack array.
/// 5. Test CalculateDamage(), returning total damage of all aliens.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alien a = new Alien(1, "salien");
            SnakeAlien b = new SnakeAlien(20, "snake");
            OgreAlien c = new OgreAlien(10, "shrek");
            MarshmallowManAlien d = new MarshmallowManAlien(90, "smores");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);



            AlienPack fourpack = new AlienPack(4);

            fourpack.AddAlien(a, 0);
            fourpack.AddAlien(b, 1);
            fourpack.AddAlien(c, 2);
            fourpack.AddAlien(d, 3);


            Console.WriteLine("Alien damage  :  " + fourpack.CalculateDamage());





             

        }
    }
}


