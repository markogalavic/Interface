using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DigitalProductModel : IProductModel 
    {
        public string Title { get; set; }
        public bool HasOrderBeenComplet{get;set;}
        public int TotalDownloundLeft { get; set; }
        public bool HasOrderBeenCompleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShipItem(CustomerModel costumer)
        {
            if (HasOrderBeenComplet == false)
            {
                Console.WriteLine($"Simulating emailing{ Title} to{costumer.EmailAddress}");
                TotalDownloundLeft -= 1;
                if (TotalDownloundLeft<1)
                {
                    HasOrderBeenComplet = true;
                    TotalDownloundLeft = 0;
                }
            }
        }
    }
}
