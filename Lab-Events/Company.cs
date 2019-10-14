using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Events
{
    public class Company
    {
        public string m_Name { get; set; }



        public event Action ShipmentArrived;

        public void FireShipmentArrived(string description)
        {
            if (ShipmentArrived == null)
            {
                return;
            }

            ShipmentArrived();

        }

        public class ShipmentArrivedEventArgs
        {
            string m_ShipmetnArrivedDescription { get; set; }


            public ShipmentArrivedEventArgs()
            {
                m_ShipmetnArrivedDescription = "10 Tons of Metal";
                Console.WriteLine(m_ShipmetnArrivedDescription);
            }



        }
    }
}
