using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Laptop : Computer
    {
        public int ScreenSizeInches { get; set; }

        public Laptop(string Brand, decimal Price, int screenSizeInches)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.ScreenSizeInches = screenSizeInches;
        }

        public Laptop()
        {
        }

        public override string ToString()
        {
            
            return $"This " + this.Brand
            + " laptop has a " + this.ScreenSizeInches
            + " inch screen and costs $" + this.Price; 
        }
    }

    
}
