using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    class ConcreteAdultPackage : Builder
    {
        private Product _product = new Product();
        public void BuildSavory()
        {
            _product.Add("Samosa");
            _product.Add("Mirchi Bajji");
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
