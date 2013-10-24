using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Logging;
using Castle.Windsor;

namespace Templates.App_Architecture.Services
{
    public interface IInjectableFilter
    {
        bool IsValid(ControllerContext context, ActionDescriptor descriptor);
        FilterScope Scope { get; }
        int? Order { get; }
    }
}
