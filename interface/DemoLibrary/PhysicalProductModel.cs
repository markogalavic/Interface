using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel:IProductModel
    {
         string Title { get; set; }
        string IProductModel.Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool HasOrderBeenCompleted { get;  set; }
        bool IProductModel.HasOrderBeenCompleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
