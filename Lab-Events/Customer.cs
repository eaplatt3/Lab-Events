using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Events
{
    public class Customer
    {
        public string m_Name { get; set; }

        public void ProcessShipmentArrivedEvent()
        {
            Console.WriteLine(m_Name + "Handled ShipmentArrived event");
        }

    }
}
