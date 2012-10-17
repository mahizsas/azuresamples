using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebRole1
{
    using MvcWebRole1.Infrastructure;

    public class ConfigurationSettings
    {
        public ConfigurationSettings(IConfigurationProvider provider)
        {
            this.Value = provider.GetSettingValue("Value");
        }

        public string Value { get; private set; }
    }
}