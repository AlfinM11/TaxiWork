using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine($"Driver Name {DriverName}");
            if (OnDuty) Console.WriteLine("On Duty : Yes");
            else Console.WriteLine("On Duty : No");
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }
        public void PickupPassenger()
        {
            Console.WriteLine($"{DriverName} Sedang menjemput penumpang");
        }
        public void DropoffPassenger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
        }
    }
}
