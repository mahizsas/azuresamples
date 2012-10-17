using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole1.Controllers
{
    using System.Diagnostics;

    using Microsoft.WindowsAzure.ServiceRuntime;

    using MvcWebRole1.Infrastructure;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ConfigurationSettings settings;
            if (RoleEnvironment.IsAvailable)
            {
                settings = new ConfigurationSettings(new ServiceConfigurationProvider());
            }
            else
            {
                settings = new ConfigurationSettings(new WebConfigProvider());
            }

            return View(settings);
        }
    }
}
