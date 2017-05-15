using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.Life = 100;
           // dragon.Atac = 10;
            dragon.ProtectionArbalest = 5;
            dragon.ProtectionMagic = 3;
            dragon.ProtectionSword = 6;

            Knight knight = new Knight();
            knight.Life = 100;
            knight.Protection = 2;

               
         
            while (dragon.Life >= 0 && knight.Life >= 0)
            {
                knight.GetAtac(dragon);
            }

                
           

            if (dragon.Life <= 0 && knight.Life > 0)
            {
                Console.WriteLine("You win!!!");
            }
            

            if (knight.Life <= 0 && dragon.Life > 0)
            {
                Console.WriteLine("Looser!!!");
            }


            Console.ReadKey();
            

        }

       



    }
}
