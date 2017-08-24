using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ServiceA
{
    public class Message : IMessage
    {
        public string MessageTest
        {
            get
            {
                return "Hello from Service A";
            }

            set
            {
                
            }
        }
    }
}
