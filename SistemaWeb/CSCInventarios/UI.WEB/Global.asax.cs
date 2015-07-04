using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Practices.Unity;

namespace UI.WEB
{
    public class Global : System.Web.HttpApplication,IInjector
    {
        public static IUnityContainer InjectorContariner { get; set; }

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciarse la aplicación
            IUnityContainer container = new UnityContainer();
            InjectorContariner = container;
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Código que se ejecuta cuando se cierra la aplicación
            IUnityContainer container = new UnityContainer();
            InjectorContariner = container;
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Código que se ejecuta al producirse un error no controlado

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se inicia una nueva sesión

        }

        void Session_End(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando finaliza una sesión.
            // Nota: el evento Session_End se desencadena sólo cuando el modo sessionstate
            // se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
            // o SQLServer, el evento no se genera.

        }
        IUnityContainer IInjector.InjectorContariner
        {
            get { return InjectorContariner; }
        }
    }
}
