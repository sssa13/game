using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Knight : Player
    {
        public int AtacSword { get; set; }
        public int AtacMagic { get; set; }
        public int AtacArbalets { get; set; }

        
       public void GetAtac( Dragon dragon)
        {
            Random rand = new Random();

            while (dragon.Life >= 0 && Life >= 0) 
            {
                AtacArbalets = rand.Next(5, 10);
                AtacSword = rand.Next(10, 15);
                AtacMagic = rand.Next(10, 20);
                dragon.Atac = rand.Next(5, 20);

                if (rand.Next(1, 100) > 50)
                {
                    Console.WriteLine("Atac knight!");
                    Console.WriteLine("Take weapon: 1 - Arbalets, 2 - Sword, 3 - Magic");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                        dragon.Life = dragon.Life - (AtacArbalets - dragon.ProtectionArbalest);
                    if (answer == "2")
                        dragon.Life = dragon.Life - (AtacSword - dragon.ProtectionSword);
                    if (answer == "3")
                        dragon.Life = dragon.Life - (AtacMagic - dragon.ProtectionMagic);
                }

                if (rand.Next(1, 100) > 50)
                {
                    Console.WriteLine("Atac dragon!");
                    Life = Life - (dragon.Atac - Protection);
                }
                

                Console.WriteLine("Dragon: " + dragon.Life);
                Console.WriteLine("Knight: " + Life);
            }

           



        }

        
    }
}
