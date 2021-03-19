using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class ConcreteChildPackage : Builder
    {
        private Product _product = new Product();
        public void BuildSavory()
        {
            _product.Add("Samosa");
        }

        public void BuildSweet()
        {
            _product.Add("Gulab jamun");
            _product.Add("Kheer");
        }

        public Product GetResults()
        {
            return _product;
        }
    }
}


