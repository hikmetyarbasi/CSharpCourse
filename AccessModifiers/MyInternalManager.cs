using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class MyInternalManager
    {
        public void Accessible()
        {
            MyInternalClass MyInternalClass = new MyInternalClass();
            MyInternalClass.Access();
        }
    }
}
