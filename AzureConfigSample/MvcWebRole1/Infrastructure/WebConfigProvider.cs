using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebRole1.Infrastructure
{
    using System.Configuration;

    public class WebConfigProvider : IConfigurationProvider
    {
        public string GetSettingValue(string settingName)
        {
            return ConfigurationManager.AppSettings[settingName];
        }
    }
}