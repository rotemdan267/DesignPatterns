using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class MyClass
    {
        private MyClass()
        {
        }
        public static MyClass Create()
        {
            return new MyClass();
        }
    }
}
