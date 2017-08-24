using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceB
{
    public class Message : IMessage
    {
        public string MessageTest
        {
            get
            {
                return "Hello from Service B";
            }

            set
            {
                
            }
        }
    }
}
