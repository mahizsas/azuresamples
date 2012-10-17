namespace MvcWebRole1.Infrastructure
{
    public interface IConfigurationProvider
    {
        string GetSettingValue(string settingName);
    }
}