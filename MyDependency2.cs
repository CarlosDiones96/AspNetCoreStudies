namespace DependencyInjection1
{
    public class MyDependency2 : IMyDependency2
    {
        private readonly ILogger<MyDependency2> _logger;

        public MyDependency2(ILogger<MyDependency2> logger)
        {
            _logger = logger;
        }

        public void WriteMessage2(string message)
        {
            _logger.LogInformation(  $"MyDependency2.WriteMessage Message: {message}");
        }
    }
}
