using System;
using System.Collections.Generic;
using MiddleLayer;
namespace Factory
{
    public static class Factory //simple factory pattern
    {

        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        static Factory()
        {
           
        }
        public static CustomerBase Create(string typecast)
        {  
            if (custs.Count == 0)//Design pattern:Lazy loading
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }
            return custs[typecast];
        }
    }
}
