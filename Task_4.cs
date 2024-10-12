using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DZ_9_Dedok
{
    class Laptop
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double ProcessorFrequency { get; set; } 
        public int Cores { get; set; }
        public decimal Price { get; set; } 
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Manufacturer} {Model}, {ProcessorFrequency} GHz, {Cores} cores, {Price} USD, {Year} year";
        }
    }
}
