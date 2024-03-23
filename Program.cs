// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        RichCompound water = new RichCompound("Water");
        water.Display();
        RichCompound benzene = new RichCompound("benzene");
        benzene.Display();
        RichCompound ethanol = new RichCompound("ethanol");
        ethanol.Display();
    }
}
