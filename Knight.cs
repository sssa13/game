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

        
       public void Atac( Dragon dragon)
        {
            while (dragon.Life > 0 && Life > 0) 
            {
                string answer;
                answer = Console.ReadLine();
                if (answer == "1")
                    dragon.Life = dragon.Life - (AtacArbalets - dragon.ProtectionArbalest);
                if (answer == "2")
                    dragon.Life = dragon.Life - (AtacSword - dragon.ProtectionSword);
                if (answer == "3")
                    dragon.Life = dragon.Life - (AtacMagic - dragon.ProtectionMagic);

                Life = Life - (dragon.Atac - Protection);

                Console.WriteLine("Dragon: " + dragon.Life);
                Console.WriteLine("Knight: " + Life);
            } 
        }

        
    }
}
