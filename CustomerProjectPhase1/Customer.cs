using System;

namespace MiddleLayer
{
  
    public class CustomerBase
    {
        public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            BillAmount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {

            throw new Exception("not implimented");
        
        }
    }
    public class Customer:CustomerBase
    {

        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer name is requied");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("phone is requied");
            }
            if (BillDate>= DateTime.Today)
            {
                throw new Exception("bill date is not proper");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is requied");
            }
            if (BillAmount == 0)
            {
                throw new Exception("Bill amount is requied");
            }
        }
    }
    public class Lead:CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer name is requied");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("phone is requied");
            }
        }
    }
}
