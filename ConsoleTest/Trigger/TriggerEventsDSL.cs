using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleTest.Trigger
{
    public class TriggerEventsDSL
    {

        public static void FireTriggerEvents<TTrigger,TParam>(TParam data) where TTrigger : ITrigger<TParam>
        {

            IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes().Where(type=>type.IsClass);

            Type interfaceType = typeof(TTrigger); 

            if (interfaceType != null)
            {
                // Filter the types that implement T interface
                var implementingClasses = types.Where(type => interfaceType.IsAssignableFrom(type));

                if (implementingClasses != null)
                {
                    // Fire Trigger in the implementing classes
                    foreach (var implementingClass in implementingClasses)
                    {
                        var instance = (ITrigger<TParam>)Activator.CreateInstance(implementingClass);

                        instance.DoEvent(data);
                    }
                }
            }
        }
    }
}
