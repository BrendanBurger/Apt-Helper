using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apt_Finder
{
    /// <summary>
    /// Apartments will be wieghted on points to compute a total score
    /// </summary>
    class Apartment
    {
        //100 max
        public String name = null; // shorthand
        public int score = 0;
        public int commute = 0; // 0 - 10
        public int price = 0; // 0 - 10 
        public int looks_in = 0; // 0 - 10
        public int rooms = 0; // 2 - 8 *2 for each
        public int utils = 0; // 0 - 7
        public int schools = 0; // 0 - 7
        public int parking = 0;//0 - 7
        public int neighborhood = 0; // 1 - 7
        public int starting = 0; // 1 - 7
        public int crime = 0; // 0 - 5
        public int yard = 0; //  0 - 5
        public int bonus = 0; // 0 - 5 
        public int hills = 0; // 1 - 5
        public int sqrSpace = 0; // 0 - 5
        public int floors = 1; // 1 - 2
        public int house = 0; // 0 - 1
        



        public Apartment(string name)
        {
            this.name = name;
        }

        public void computeScore()
        {
            score = price + commute + yard + schools + looks_in + utils + parking + rooms + bonus + neighborhood + hills + starting + floors + crime + house + sqrSpace;
        }

        public void print()
        {
            Console.WriteLine(name);
            Console.WriteLine("Commute" + commute);
            Console.WriteLine("Price" + price);
            Console.WriteLine("Yard" + yard);
            Console.WriteLine("Schools" + schools);
            Console.WriteLine("Looks in" + looks_in);
            Console.WriteLine("Utils" + utils);
            Console.WriteLine("parking " + parking);
            Console.WriteLine("Rooms " + rooms);
            Console.WriteLine("Bonus " + bonus);
            Console.WriteLine("Neighborhood " + neighborhood);
            Console.WriteLine("Hills " + hills);
            Console.WriteLine("Starting " + starting);
            Console.WriteLine("floors " + floors);
            Console.WriteLine("Crimes " + crime);
            Console.WriteLine("house " + house);
            Console.WriteLine("Score " + score);
        }







    }
}
