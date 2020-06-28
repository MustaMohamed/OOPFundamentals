namespace Solution.Core
{
    public interface ILogger
    {
        void Log(string message);

        void LogInfo(string message);

        void LogError(string message);
    }
}