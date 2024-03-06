using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleTest.Trigger
{
    public class TriggerEventsDSL
    {


        public static void FireTriggerEvents<T>(object data) where T : ITrigger
        {
            string TypeName = typeof(T).Name;

            var types = Assembly.GetExecutingAssembly().GetTypes();

            Type interfaceType = types.First(t => t.Name == TypeName);

            if (interfaceType != null)
            {
                // Filter the types that implement T interface
                var implementingClasses = types.Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass);

                if (implementingClasses != null)
                {
                    // Fire Trigger in the implementing classes
                    foreach (var implementingClass in implementingClasses)
                    {
                        var instance = (ITrigger)Activator.CreateInstance(implementingClass);

                        instance.DoEvent(data);
                    }
                }
            }
        }
    }
}
