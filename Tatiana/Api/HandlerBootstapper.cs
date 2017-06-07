using Starcounter;
using System;
using System.Linq;
using System.Reflection;

namespace Tatiana.Api
{
    public static class HandlerBootstapper
    {
        public static void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            RegisterHandlers();
        }

        private static void RegisterHandlers()
        {
            var expectedType = typeof(IHandler);
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(p => expectedType.IsAssignableFrom(p) && !p.IsInterface);

            foreach(var handler in types)
            {
                IHandler instance = (IHandler)Activator.CreateInstance(handler);
                instance.Register();
            }
        }
    }
}
