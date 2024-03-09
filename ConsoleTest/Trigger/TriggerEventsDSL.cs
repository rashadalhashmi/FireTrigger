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
            string TypeName = typeof(TTrigger).Name;

            var types = Assembly.GetExecutingAssembly().GetTypes();

            Type interfaceType = types.FirstOrDefault(t => t.Name == TypeName);

            if (interfaceType != null)
            {
                // Filter the types that implement T interface
                var implementingClasses = types.Where(type => interfaceType.IsAssignableFrom(type) && type.IsClass);

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
