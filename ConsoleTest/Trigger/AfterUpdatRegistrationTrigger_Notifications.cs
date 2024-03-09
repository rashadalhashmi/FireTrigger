using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Trigger
{
    public class AfterUpdatRegistrationTrigger_Notifications : IAfterUpdatRegistrationTrigger
    {
        public void DoEvent(UpdateRegistrationParameters obj)
        {
            Console.WriteLine("AfterUpdatRegistrationTrigger_Notifications");
        }
    }
}
