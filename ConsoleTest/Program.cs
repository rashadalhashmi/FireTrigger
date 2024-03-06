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
                TriggerEventsDSL.FireTriggerEvents<IAfterUpdatRegistration>( new object());
                TriggerEventsDSL.FireTriggerEvents<IAfterRegistrationTrigger>(new object());

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }


    }


    public abstract class baseclass 
    {
        public EventParamsModelBase CreateModel<T>(string eventParameters) where T : EventParamsModelBase
        {
            var tyee = typeof(T);

            T afterResult = JsonConvert.DeserializeObject<T>(eventParameters);
            return afterResult;

        }
        public void PrintType<T>() where T :baseclass 
        {
            Console.WriteLine((typeof(T)));

            return  ;
        }

    }

    public class childclass :baseclass
    {
       

    }

    public class EventParamsModelBase
    {
        public string Body { get; set; }

        public string Subject { get; set; }

    }

    public class AfterReservationParamsModel : EventParamsModelBase
    {
    }

}
