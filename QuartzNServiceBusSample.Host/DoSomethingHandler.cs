using NServiceBus;
using NServiceBus.Logging;
using QuartzNServiceBusSample.Messages;


namespace QuartzNServiceBusSample.Host
{
    public class DoSomethingHandler : IHandleMessages<DoSomething>
    {
        private static readonly ILog Logger = LogManager.GetLogger("Name");
        public void Handle(DoSomething message)
        {
            Logger.Info("Doing something");
        }
    }
}