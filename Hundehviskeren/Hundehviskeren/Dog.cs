using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundehviskeren
{ 
    //Hva kan beskrive en hund
    //hva kan en hund eie
    //Hva kan en hund gjøre
    //løpe, leke, spise, sove, bjeffe, destroyFurniture, bite,legHump
    //Pause til 13.00
    internal class Dog
    {
        string color;
        string race;
        string size;
        string[] toys;
        public int age;
        string name;
        string gender;
        int hunger;
        int satisfaction;

        public Dog()
        {

        }
        public Dog(string startName, int startAge)
        {
            name = startName;
            age = startAge;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }
        public void Play()
        {
            Console.WriteLine($"{name} is playing");
            satisfaction++;
        }
        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
            hunger++;
        }
        public void Sleep()
        {

        }
        public void Hump(string humpObject)
        {
            Console.WriteLine($"{name} is humping {humpObject}");
            satisfaction += 30;
        }
        public void StareIntoTHeAbyssInCorner()
        {
            //Dedikert til Linn
            Console.WriteLine($"{name} is staring into the abyss while sitting in corner and pondering life desicions");
        }
        public void Bark()
        {

        }
    }
}
