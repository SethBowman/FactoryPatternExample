using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class GooglePhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call using a Google phone..");
        }
    }
}
