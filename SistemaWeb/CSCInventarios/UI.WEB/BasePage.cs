using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace UI.WEB
{
    public abstract class BasePage<T> : Page where T : class
    {        

            protected override void OnInit(EventArgs e)
            {
                Injectar();

                base.OnInit(e);
            }

            protected void Injectar()
            {
                var contex = HttpContext.Current;

                if (contex == null)
                {
                    return;
                }

                var injector = contex.ApplicationInstance as IInjector;

                if (injector.InjectorContariner == null)
                {
                    throw new InvalidOperationException("No Injector");
                }

                var container = injector.InjectorContariner;

                if (container == null)
                {
                    throw new InvalidOperationException("No Unity container found");
                }

                container.LoadConfiguration();
                container.BuildUp(this as T);

            }

            public void injectar02()
            {
                using (IUnityContainer container = new UnityContainer())
                {
                    container.LoadConfiguration();
                    container.BuildUp(this.GetType(), this);
                }
            }
        }

}