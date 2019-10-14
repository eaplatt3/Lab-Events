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

        //public even Action ShipmentsArrived
        public event EventHandler <ShipmentArrivedEventArgs> ShipmentArrived; //allows passing data

        public void FireShipmentArrived(string description)
        {
            if (ShipmentArrived == null)
            {
                return;
            }

            ShipmentArrivedEventArgs x = new ShipmentArrivedEventArgs(description);

            ShipmentArrived(this, x);

        }

        public class ShipmentArrivedEventArgs : EventArgs
        {
            public string m_ShipmentArrivedDescription { get; set; }


            public ShipmentArrivedEventArgs(string description)
            {
                m_ShipmentArrivedDescription = description;
            }



        }
    }
}
