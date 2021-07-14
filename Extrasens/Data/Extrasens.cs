using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Extrasens.Data
{
    public class Extrasens
    {

        Random prubRandom = new Random();
        
        public int AbraKadabra()
        {
            return prubRandom.Next(10, 99);;
        }
    }
}
