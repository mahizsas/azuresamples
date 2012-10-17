namespace MvcWebRole1.Infrastructure
{
    using Microsoft.WindowsAzure.ServiceRuntime;

    public class ServiceConfigurationProvider : IConfigurationProvider
    {
        public string GetSettingValue(string settingName)
        {
            return RoleEnvironment.GetConfigurationSettingValue(settingName);
        }
    }
}