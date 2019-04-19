using System;

namespace CSharpRefreshment
{
    public class Order
    {
        public int Id { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }

    }
}

