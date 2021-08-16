using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface IContract
    {
        bool Sign();
    }

    public class Employee : IContract
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public bool Sign()
        {
            Console.WriteLine($"{this.Name} - {this.EmpId} AGREED TO: NDA, RULES OF COMPANY CONDUCT, EMPLOYMENT BOND");
            return true;
        }
    }
    public class Client : IContract
    {
        public string Brand { get; set; }
        public string Location { get; set; }

        public bool Sign()
        {
            Console.WriteLine($"{this.Brand} from {this.Location} branch AGREED TO: NDA, DELIVERY SLAs, ON-TIME DELIVERY, 3-PHASED PRODUCT");
            return true;
        }
    }
    public class Vendor : IContract
    {
        public string Name { get; set; }
        public string VendorType { get; set; }
        public bool Sign()
        {
            Console.WriteLine($"{this.Name} {this.VendorType} AGREED TO: NDA, FEEDBACK CRITERIA, 5-YEARLY CONTRCT");
            return true;
        }
    }
}
