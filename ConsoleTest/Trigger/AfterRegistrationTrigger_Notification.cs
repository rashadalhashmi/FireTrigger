using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Trigger
{
    public class AfterRegistrationTrigger_Notification : IAfterRegistrationTrigger
    {
        public void DoEvent(object obj)
        {
            Console.WriteLine("after Registration");
        }
    }
}
