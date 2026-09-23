using System;

namespace oop_2
{
    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
            count = 0;
        }
        public Shipment this[int index]
        {
            get
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (shipments != null && index >= 0 && index < count)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string code]
        {
            get
            {
                if (shipments != null && !string.IsNullOrWhiteSpace(code))
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (shipments[i].TrackingCode != null &&
                            shipments[i].TrackingCode.Equals(code, StringComparison.OrdinalIgnoreCase))
                        {
                            return shipments[i];
                        }
                    }
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new Shipment[10];
            }

            if (count < 10)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }
            return false;
        }

        public int Count
        {
            get { return count; }
        }
    }
}