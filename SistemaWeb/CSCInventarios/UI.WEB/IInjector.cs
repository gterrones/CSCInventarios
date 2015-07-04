using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace UI.WEB
{
    public interface IInjector
    {
        IUnityContainer InjectorContariner { get; }
    }
}
