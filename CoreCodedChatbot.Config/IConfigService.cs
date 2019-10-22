namespace CoreCodedChatbot.Config
{
    public interface IConfigService
    {
        T Get<T>(string configKey);
    }
}