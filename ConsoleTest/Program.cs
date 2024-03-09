using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Configuration;

using System.Threading.Tasks;
using System.Collections;
using ConsoleTest.Trigger;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                TriggerEventsDSL.FireTriggerEvents<IAfterRegistrationTrigger, RegistrationParameters>(new RegistrationParameters());
                TriggerEventsDSL.FireTriggerEvents<IAfterUpdatRegistration,UpdateRegistrationParameters>(new UpdateRegistrationParameters());


                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

    }
}
