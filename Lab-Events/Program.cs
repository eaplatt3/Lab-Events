using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company();

            comp.m_Name = "Best Buy";

            Customer jane = new Customer();
            jane.m_Name = "Jane";

            Customer mark = new Customer();
            mark.m_Name = "Mark";

            comp.ShipmentArrived += jane.ProcessShipmentArrivedEvent;
            comp.FireShipmentArrived("New Switches Arrived");

            comp.ShipmentArrived += mark.ProcessShipmentArrivedEvent;
            comp.FireShipmentArrived("New Xbox One Arrived");
        }
    }
}
