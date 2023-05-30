using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class ApplePhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call using an Apple IPhone..");
        }
    }
}
