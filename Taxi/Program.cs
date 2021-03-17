using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taksi = new Taxi();

            taksi.DriverName = "Agung";
            taksi.OnDuty = true;
            taksi.NumPassenger = 15;

            taksi.TaxiInfo();
            taksi.PickupPassenger();
            taksi.DropoffPassenger();

            Console.ReadKey();
        }
    }
}
