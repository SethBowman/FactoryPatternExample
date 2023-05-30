using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class AndroidPhone : IMobilePhone
    {
        public void Call()
        {
            Console.WriteLine("Making a call using a Android phone..");
        }
    }
}
