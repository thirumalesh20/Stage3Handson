using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CaseStudy_Observer_Dp
{
    class JohnObserver : INotificationObserver
    {

        public string Name { get { return "John"; } }

        public void OnServerDown()
        {

            Console.WriteLine(Name + " Has No Data");
        }
    }
}
