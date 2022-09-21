using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_02_02
{
    public class Palme
    {
        public int Amzius { get; private set; }
        public int VaisiuKiekis { get; private set; }
      
        public Palme(int amzius)
        {
            Amzius = amzius;
        }

        public void Prideti1MenAmziaus()
        {
            Amzius = Amzius + 1;
            if (Amzius > 12)
            {
                Amzius = 0;
                VaisiuKiekis = 0;
            }
            else if (Amzius >= 5 && Amzius <= 12)
            {
                VaisiuKiekis = Amzius * 3;
            }
            else
            {
                VaisiuKiekis = 0;
            }

            Console.WriteLine($"Palmės amžius yra {Amzius} mėn");
            Console.WriteLine($"Palmės vaisių kiekis yra {VaisiuKiekis}");
           
            

        }

    }

   
   
}
