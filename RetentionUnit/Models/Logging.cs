using NLog;

namespace RetentionUnit.Models
{
    public class Logging
    {
        public Logging()
        {
            Log = LogManager.GetLogger(GetType().FullName);
        }

        protected Logger Log { get; }
    }
}
