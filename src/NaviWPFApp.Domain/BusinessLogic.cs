using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviWPFApp.Domain
{
    public class BusinessLogic
    {
        private int counter = 0;

        public bool CountSomething()
        {
            return ++counter > 10;
        }
    }
}
