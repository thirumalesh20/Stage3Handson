using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CaseStudy_Observer_Dp
{
    public interface INotificationObserver
    {
        string Name { get; }

        void OnServerDown();
    }
}
